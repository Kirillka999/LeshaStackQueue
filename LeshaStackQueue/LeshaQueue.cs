namespace LeshaStackQueue;

public class LeshaQueue
{
    private int[] _internalArray;
    private int _tailCount;
    private int _headCount;
    
    public int Capacity { get; private set; }

    public LeshaQueue()
    {
        Capacity = 1;
        _internalArray = new int[Capacity];
    }
    
    public LeshaQueue(int capacity)
    {
        if (capacity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than or equal to 0");
        }
        Capacity = capacity;
        _internalArray = new int[Capacity];
    }

    public void Enqueue(int element)
    {
        if (_internalArray.Length == _tailCount)
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
        
        _internalArray[_tailCount] = element;
        _tailCount++;
    }
    
    public int Peek()
    {
        if (_headCount == _tailCount)
        {
            Array.Resize(ref _internalArray, 0);
            throw new InvalidOperationException("Can not get earliest element: queue is empty");
        }
        return _internalArray[_headCount];
    }

    public int Dequeue()
    {
        if (_headCount == _tailCount)
        {
            Array.Resize(ref _internalArray, 0);
            throw new InvalidOperationException("Can remove elements: queue is empty");
        }
        
        var tempElement = Peek();
        _headCount++;
        
        if (_tailCount != _headCount && _internalArray.Length % (_tailCount - _headCount) == 0)
        {
            Capacity = _tailCount - _headCount;
            var newArray = new int[Capacity];
            Array.ConstrainedCopy(_internalArray, _headCount, newArray, 0, _tailCount - _headCount);
            _internalArray = newArray;
            _headCount = 0;
            _tailCount = _internalArray.Length;
        }
        
        return tempElement;
    }
}