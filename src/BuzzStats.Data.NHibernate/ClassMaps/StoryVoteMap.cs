using FluentNHibernate.Mapping;
using BuzzStats.Data.NHibernate.Entities;

namespace BuzzStats.Data.NHibernate.ClassMaps
{
    public class StoryVoteMap : ClassMap<StoryVoteEntity>
    {
        public StoryVoteMap()
        {
            Table("StoryVote");
            Id(x => x.Id);
            References(x => x.Story).UniqueKey("uniqueVoter").Not.Nullable();
            Map(x => x.Username).UniqueKey("uniqueVoter").Not.Nullable();
            Map(x => x.CreatedAt).Not.Update().Not.Nullable();
        }
    }
}
