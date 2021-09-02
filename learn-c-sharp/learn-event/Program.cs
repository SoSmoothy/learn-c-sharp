using System;

namespace learn_event
{
    class GotoUrlArgs : EventArgs
    {
        private string _url;

        public GotoUrlArgs(string url)
        {
            _url = url;
        }

        public string Url
        {
            get { return _url; }
        }
    }

    class User
    {
        public event EventHandler<GotoUrlArgs> ChangeUrlEvent; 
        public void ChangeUrl(string url)
        {
            ChangeUrlEvent?.Invoke(this, new GotoUrlArgs(url));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.ChangeUrlEvent += (sender, urlArgs) =>
            {
                Console.WriteLine($"Change URL to {urlArgs.Url}");
            };
            
            user.ChangeUrl("google.com");
            user.ChangeUrl("bing.com");
        }
    }
}