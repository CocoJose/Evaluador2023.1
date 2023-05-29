namespace Evaluator.Logic
{
    public class Stack<T>
    {
        private T[] _stack;
        private int _top;
        public Stack(int n)
        {
            N = n;
            _stack = new T[N];
        }

        public int N { get; }

        public bool IsEmpty => _top == 0; // cuando _top sea igual a cero IsEmpty es True de la contrario falso

        public bool IsFull => _top == N; // cuando _top sea igual a N IsFull es True de lo conytrario Falso

        public T GetItemInTop() => _stack[_top - 1];    

        public void Push(T item) // apilar
        {
            if (IsFull)
            {
                throw new Exception("Stack full.");
            }
            _stack[_top] = item;
            _top++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack empty.");
            }
            var item = _stack[_top - 1];
            _top--;
            return item;
        }
    }
}
