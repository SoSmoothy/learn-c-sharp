namespace basic_about_c_sharp.basic.Generic
{
    public class ExampleList<T>
    {
        private T[] _data;

        public int Length()
        {
            return _data.Length;
        }

        public ExampleList(int length)
        {
            _data = new T[length];
        }

        public void Set(int index, T value)
        {
            if (index >= 0 && index < _data.Length) _data[index] = value;
        }

        public T Get(int index)
        {
            if (index >= 0 && index < _data.Length) return _data[index];
            return default(T);
        }
    }
}