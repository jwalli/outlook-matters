namespace OutlookMatters.Core.Mattermost.Interface
{
    public class Post
    {
        public string id { get; set; }
        public string channel_id { get; set; }
        public string message { get; set; }
        public string user_id { get; set; }
        public string root_id { get; set; }
    }
}