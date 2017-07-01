using NGSoftware.Common;

namespace BuzzStats.Data
{
    /// <summary>
    /// Data repository regarding Story Poll History.
    /// </summary>
    public interface IStoryPollHistoryDataLayer
    {
        StoryPollHistoryData Create(StoryPollHistoryData storyPollHistory);

        int Count(DateRange dateRange);
    }
}