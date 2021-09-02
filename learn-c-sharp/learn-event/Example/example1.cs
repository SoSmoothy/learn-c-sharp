using System;

namespace learn_event.Example
{
    class MyEventArgs : EventArgs
    {
        private string _data;
        
        public MyEventArgs(string data)
        {
            _data = data;
        }
        
        public string Data
        {
            get { return _data; }
        }
    }
        
    class Youtuber
    {
        public event EventHandler<MyEventArgs> Noti;
        
        public void UploadVideo(string videoTitle)
        {
            Noti?.Invoke(this, new MyEventArgs(videoTitle));
        }
    }
        
    class Subcriber
    {
        private string _name;
        
        public Subcriber(string name)
        {
            _name = name;
        }
        public void Sub(Youtuber youtuber)
        {
            youtuber.Noti += (sender, args) =>
            {
                Console.WriteLine($"{_name} đã nhận video từ mới với tiêu đề {args.Data}");
            };
        }
    }
    
    public class example1
    {
        
    }
}