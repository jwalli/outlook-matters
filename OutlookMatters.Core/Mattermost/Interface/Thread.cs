﻿using System.Collections.Generic;

namespace OutlookMatters.Core.Mattermost.Interface
{
    public struct Thread
    {
        public string[] order;
        public Dictionary<string, Post> posts;
    }
}