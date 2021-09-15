using System;

namespace learn_event
{
    class VideoArgs : EventArgs
    {
        private string _titleVideo;
        public VideoArgs(string titleVideo)
        {
            _titleVideo = titleVideo;
        }

        public string TitleVideo
        {
            get => _titleVideo;
        }
    }

    class Youtuber
    {
        public event EventHandler<VideoArgs> upload_video;

        public void Upload(string title)
        {
            upload_video?.Invoke(this, new VideoArgs(title));
        }
    }

    class User
    {
        private string _username;

        public String Username
        {
            get => _username;
            set => _username = value;
        }
        
        public void Sub(Youtuber youtuber)
        {
            youtuber.upload_video += (sender, args) =>
            {
                Console.WriteLine($"{_username} Get {args.TitleVideo}");
            };
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Youtuber youtuber = new Youtuber();
            User user1 = new User();
            user1.Username = "User 1";
            User user2 = new User();
            user2.Username = "User 2";
            
            user1.Sub(youtuber);
            user2.Sub(youtuber);
            
            youtuber.Upload("Hello World 1");
            youtuber.Upload("Hello World 2");
        }
    }
}