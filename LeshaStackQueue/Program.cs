namespace LeshaStackQueue;

class Program
{
    static void Main(string[] args)
    {
        LeshaStack stack1 = new LeshaStack(1);
        
        stack1.AddElement(1);
        stack1.AddElement(2);
        stack1.AddElement(3);
        stack1.AddElement(4);
        stack1.AddElement(5);
        stack1.AddElement(6);
        
        Console.WriteLine(stack1.GetLatestElement());
        Console.WriteLine(stack1.GetAndRemoveLatestElement());
        Console.WriteLine(stack1.GetLatestElement());
        stack1.RemoveElement();
        Console.WriteLine(stack1.GetLatestElement());
        
        stack1.RemoveElement();
        Console.WriteLine(stack1.GetLatestElement());
        stack1.RemoveElement();
        stack1.RemoveElement();
        stack1.RemoveElement();
        
        stack1.AddElement(99);
        
        //Console.WriteLine(stack1.GetAndRemoveLatestElement());

        Console.WriteLine();
        Console.WriteLine(stack1[0]);
        Console.WriteLine(stack1);





    }
}