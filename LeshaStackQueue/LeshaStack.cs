namespace LeshaStackQueue;

public class LeshaStack
{
    private int[] _internalArray;
    private int _count;
    public int Capacity { get; private set; }

    public int this[int index]
    {
        get
        {
            if (index > _count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return _internalArray[index];
        }
    }
    
    public LeshaStack()
    {
        Capacity = 1;
        _internalArray = new int[Capacity];
    }

    public LeshaStack(int capacity)
    {
        OutOfRangeChecker(capacity);
        
        Capacity = capacity;
        _internalArray = new int[Capacity];
    }

    public void AddElement(int element)
    {
        if (_internalArray.Length == _count)
        {
            Capacity = _internalArray.Length * 2;
            Array.Resize(ref _internalArray, Capacity);
        }
        
        _internalArray[_count] = element;
        _count++;
    }

    public void RemoveElement()
    {
        OutOfRangeChecker(_count - 1);
        _count--;
    }

    public int GetLatestElement()
    {
        if (_count - 1 < 0)
        {
            return 0;
        }
        return _internalArray[_count - 1];
    }

    public int GetAndRemoveLatestElement()
    {
        OutOfRangeChecker(_count - 1);
        _count--;
        return _internalArray[_count];
    }

    public override string ToString()
    {
        return GetLatestElement().ToString();
    }

    private void OutOfRangeChecker(int num)
    {
        if (num < 0)
        {
            throw new IndexOutOfRangeException();
        }
    }
}