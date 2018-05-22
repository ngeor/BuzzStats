﻿using Confluent.Kafka;
using Confluent.Kafka.Serialization;
using System;

namespace BuzzStats.Kafka
{
    public class ConsumerApp<TKey, TValue> : BaseConsumerApp<TKey, TValue>
    {
        public ConsumerApp(
            string brokerList,
            string consumerId,
            IDeserializer<TKey> keyDeserializer,
            IDeserializer<TValue> valueDeserializer)
            : base(brokerList, consumerId, keyDeserializer, valueDeserializer)
        {

        }
    }
}
