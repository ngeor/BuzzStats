using System;

namespace BuzzStats.CrawlerService.DTOs
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Username { get; set; }

        public DateTime CreatedAt { get; set; }

        public int VotesUp { get; set; }

        public int VotesDown { get; set; }

        public bool IsBuried { get; set; }

        public Comment[] Comments { get; set; }
    }
}