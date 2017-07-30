﻿using AutoMapper;
using BuzzStats.WebApi.DTOs;
using BuzzStats.WebApi.Storage;
using BuzzStats.WebApi.Storage.Entities;
using BuzzStats.WebApi.Storage.Repositories;
using BuzzStats.WebApi.UnitTests.TestHelpers;
using Moq;
using NGSoftware.Common.Messaging;
using NHibernate;
using NUnit.Framework;

namespace BuzzStats.WebApi.UnitTests.Storage
{
    [TestFixture]
    public class StoryUpdaterTest
    {
        private Mock<ISession> _mockSession;
        private Mock<IMapper> _mockStoryMapper;
        private Mock<StoryRepository> _mockStoryRepository;
        private Mock<IMessageBus> _mockMessageBus;
        
        private StoryUpdater _storyUpdater;

        [SetUp]
        public void SetUp()
        {
            MockHelper.InjectMocks(this);
            _storyUpdater = MockHelper.Create<StoryUpdater>(this);
        }

        [Test]
        public void Save_WhenStoryIsNew()
        {
            // arrange
            var story = new Story
            {
                StoryId = 42
            };

            var storyEntity = new StoryEntity
            {
                StoryId = 42
            };

            _mockStoryMapper.Setup(m => m.Map<StoryEntity>(story)).Returns(storyEntity);
            _mockStoryRepository.Setup(r => r.GetByStoryId(_mockSession.Object, 42)).Returns((StoryEntity)null);

            // act
            var result = _storyUpdater.Save(_mockSession.Object, story);

            // assert
            _mockSession.Verify(s => s.Save(storyEntity));
            _mockMessageBus.Verify(m => m.Publish(storyEntity));
            Assert.AreEqual(storyEntity, result);
        }
        
        [Test]
        public void Save_WhenStoryExists()
        {
            // arrange
            var story = new Story
            {
                StoryId = 42
            };

            var existingStory = new StoryEntity
            {
                StoryId = 42
            };
            
            var updatedStoryEntity = new StoryEntity();

            _mockStoryMapper.Setup(m => m.Map(story, existingStory))
                .Returns(updatedStoryEntity);
            
            _mockStoryRepository.Setup(r => r.GetByStoryId(_mockSession.Object, 42)).Returns(existingStory);

            // act
            var result = _storyUpdater.Save(_mockSession.Object, story);

            // assert
            _mockSession.Verify(s => s.Update(updatedStoryEntity));
            _mockMessageBus.Verify(m => m.Publish(updatedStoryEntity), Times.Never);
            Assert.AreEqual(updatedStoryEntity, result);
        }
    }
}