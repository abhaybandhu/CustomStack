namespace CustomStackLib
{
    public class CustomStackClass<T>
    {
        const int _max = 10;
        int _count;
        T[] _stack;
        
        public CustomStackClass()
        {
            _stack = new T[_max];
            _count = 0;
        }

        public void Push(T new_item) => _stack[_count++] = new_item;
        //{
        //  
        //    if (_count == _max) return;
        //    _stack[_count++] = new_item;
        //}
        public T Pop()=>  _stack[--_count];
        

        public int Count() => _count;
    }
}
