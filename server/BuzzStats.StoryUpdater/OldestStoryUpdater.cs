﻿using Confluent.Kafka;
using log4net;
using System;
using System.Threading.Tasks;

namespace BuzzStats.StoryUpdater
{
    public class OldestStoryUpdater
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(OldestStoryUpdater));

        private readonly IMongoRepository repository;
        private readonly ISerializingProducer<Null, string> producer;
        private readonly string outputTopic;

        public OldestStoryUpdater(
            IMongoRepository repository,
            ISerializingProducer<Null, string> producer,
            string outputTopic)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.producer = producer ?? throw new ArgumentNullException(nameof(producer));
            this.outputTopic = outputTopic ?? throw new ArgumentNullException(nameof(outputTopic));
        }

        public async Task UpdateAsync()
        {
            var storyHistory = await repository.OldestCheckedStory();
            if (storyHistory == null)
            {
                Log.Info("No stories are known to story updater!");
                return;
            }

            var storyId = storyHistory.StoryId;
            Log.InfoFormat("Oldest checked story is {0}", storyId);
            await producer.ProduceAsync(outputTopic, null, storyId.ToString());
            await repository.UpdateLastCheckedDate(storyId);
        }

        public void Update()
        {
            Task.Run(async () => await UpdateAsync())
                .GetAwaiter()
                .GetResult();
        }
    }
}