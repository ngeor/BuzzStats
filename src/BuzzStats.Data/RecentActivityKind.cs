// --------------------------------------------------------------------------------
// <copyright file="RecentActivityKind.cs" company="Nikolaos Georgiou">
//      Copyright (C) Nikolaos Georgiou 2010-2013
// </copyright>
// <author>Nikolaos Georgiou</author>
// * Date: 2013/10/04
// * Time: 10:03 μμ
// --------------------------------------------------------------------------------

using System;

namespace BuzzStats.Data
{
    [Flags]
    public enum RecentActivityKind
    {
        Unknown = 0,
        NewStory = 1,
        NewStoryVote = 2,
        NewComment = 4,
        NewCommentVote = 8
    }
}