namespace LeshaStackQueue;

class Program
{
    static void Main(string[] args)
    {
        // LeshaStack stack1 = new LeshaStack(4);
        //
        // stack1.Push(1);
        // stack1.Push(2);
        // stack1.Push(3);
        // stack1.Push(4);
        // stack1.Push(5);
        // stack1.Push(6);
        // Console.WriteLine("all elements are pushed");
        //
        // Console.WriteLine(stack1.Peek());
        // Console.WriteLine(stack1.Pop());
        // Console.WriteLine(stack1.Peek());
        // stack1.Pop();
        // Console.WriteLine(stack1.Peek());
        //
        // stack1.Pop();
        // Console.WriteLine(stack1.Peek());
        // stack1.Pop();
        // stack1.Pop();
        // stack1.Pop();
        //
        // stack1.Push(99);
        // Console.WriteLine(stack1.Peek());

        LeshaQueue queue1 = new LeshaQueue();
        queue1.Enqueue(1);
        queue1.Enqueue(2);
        queue1.Enqueue(3);
        queue1.Enqueue(4);
        queue1.Enqueue(5);
        queue1.Dequeue();
        queue1.Dequeue();
        queue1.Dequeue();
        queue1.Dequeue();
        //queue1.Dequeue();
        queue1.Peek();
        queue1.Enqueue(99);
        queue1.Peek();
        queue1.Dequeue();
        queue1.Peek();
        queue1.Dequeue();
        queue1.Peek();
        
    }
}