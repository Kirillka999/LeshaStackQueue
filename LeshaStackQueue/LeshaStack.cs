namespace LeshaStackQueue;

public class LeshaStack
{
    private int[] _internalArray;
    private int _count;
    public int Capacity { get; private set; }
    
    public LeshaStack()
    {
        Capacity = 1;
        _internalArray = new int[Capacity];
    }

    public LeshaStack(int capacity)
    {
        if (capacity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than or equal to 0");
        }
        
        Capacity = capacity == 0 ? 1 : capacity;
        _internalArray = new int[Capacity];
    }

    public void Push(int element)
    {
        if (_internalArray.Length == _count)
        {
            if (Capacity == 0)
            {
                Capacity = 1;
            }
            else
            {
                Capacity = _internalArray.Length * 2;
            }
            Array.Resize(ref _internalArray, Capacity);
        }
        
        _internalArray[_count] = element;
        _count++;
    }
    
    public int Peek()
    {
        if (_count - 1 < 0)
        {
            throw new InvalidOperationException("Can not get latest element: stack is empty");
        }
        return _internalArray[_count - 1];
    }

    public int Pop()
    {
        if (_count - 1 < 0)
        {
            throw new InvalidOperationException("Can remove elements: stack is empty");
        }
        var tempElement = Peek();
        _count--;
        if (_count == _internalArray.Length / 2)
        {
            Capacity = _internalArray.Length / 2;
            Array.Resize(ref _internalArray, Capacity);
        }
        return tempElement;
    }
}