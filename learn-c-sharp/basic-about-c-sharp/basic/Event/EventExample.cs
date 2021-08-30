using System;

namespace basic_about_c_sharp.basic.Event
{
    public class EventExample
    {
        internal class MyEventArgs : EventArgs
        {
            private string _data;

            public MyEventArgs(string data)
            {
                _data = data;
            }

            public string Data
            {
                get => _data;
                set
                {
                    _data = value;
                }
            }
        }

        internal class Publisher
        {
            public event EventHandler<MyEventArgs> DataChanged;

            public void Send(string a)
            {
                DataChanged?.Invoke(this,new MyEventArgs(a));
            }
        }

        internal class User
        {
            public void Sub(Publisher publisher)
            {
                publisher.DataChanged += GetDataFromPublisher;
            }

            private void GetDataFromPublisher(object sender, MyEventArgs args)
            {
                Console.WriteLine(args.Data);
            }
        }
    }
}