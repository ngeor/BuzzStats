﻿namespace BuzzStats.Common
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder",
        "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources
    {
        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance",
            "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState
            .Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp =
                        new global::System.Resources.ResourceManager("BuzzStats.Common.Resources",
                            typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState
            .Advanced)]
        public static global::System.Globalization.CultureInfo Culture
        {
            get { return resourceCulture; }
            set { resourceCulture = value; }
        }

        /// <summary>
        ///   Looks up a localized string similar to Date.
        /// </summary>
        public static string Date
        {
            get { return ResourceManager.GetString("Date", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} days ago.
        /// </summary>
        public static string DaysAgo
        {
            get { return ResourceManager.GetString("DaysAgo", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Detected {0} minutes after creation.
        /// </summary>
        public static string DiffBetweenDetectedAtAndCreatedAtIs_X
        {
            get { return ResourceManager.GetString("DiffBetweenDetectedAtAndCreatedAtIs_X", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} hours ago.
        /// </summary>
        public static string HoursAgo
        {
            get { return ResourceManager.GetString("HoursAgo", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} minutes ago.
        /// </summary>
        public static string MinutesAgo
        {
            get { return ResourceManager.GetString("MinutesAgo", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} records.
        /// </summary>
        public static string N_Records
        {
            get { return ResourceManager.GetString("N_Records", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Recent Activity.
        /// </summary>
        public static string RecentActivity
        {
            get { return ResourceManager.GetString("RecentActivity", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Recent Stories.
        /// </summary>
        public static string RecentStories
        {
            get { return ResourceManager.GetString("RecentStories", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to seconds ago.
        /// </summary>
        public static string SecondsAgo
        {
            get { return ResourceManager.GetString("SecondsAgo", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Story.
        /// </summary>
        public static string Story
        {
            get { return ResourceManager.GetString("Story", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to User.
        /// </summary>
        public static string Username
        {
            get { return ResourceManager.GetString("Username", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Votes.
        /// </summary>
        public static string VoteCount
        {
            get { return ResourceManager.GetString("VoteCount", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Wrote new comment.
        /// </summary>
        public static string WhatNewComment
        {
            get { return ResourceManager.GetString("WhatNewComment", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Added new story.
        /// </summary>
        public static string WhatNewStory
        {
            get { return ResourceManager.GetString("WhatNewStory", resourceCulture); }
        }

        /// <summary>
        ///   Looks up a localized string similar to Voted story.
        /// </summary>
        public static string WhatNewStoryVote
        {
            get { return ResourceManager.GetString("WhatNewStoryVote", resourceCulture); }
        }
    }
}