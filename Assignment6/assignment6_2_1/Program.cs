//	Write a C# program to implement a stack by using array with push and pop operations.

using System.Collections.Generic;

class Program
{
    public static void Main(String[] args)
    {
        // Instantiate the class
        StackArray mystack = new StackArray(5); // hold 5 elements
        mystack.Push(1);
        mystack.Push(3);
        mystack.Push(5);
        mystack.Display();
        mystack.Pop();
        Console.WriteLine("After Pop: ");
        mystack.Display();
        Console.WriteLine("Continue Push Operation:");
        mystack.Push(5);
        mystack.Push(7);
        mystack.Display();
        
    }
}

// From lecture. Best to first create a class for stack
class StackArray
{
    private int[] data;
    private int top;
    public StackArray(int size)
    {
        this.data = new int[size]; //user can specify size
        this.top = -1;
    }
    public bool IsEmpty()
    {
        return this.top == -1;
    }
    public bool IsFull()
    {
        return this.top == data.Length - 1;
    }
    public void Push(int val)
    {
        if(IsFull())
        {
            Console.WriteLine("Stack is full. Cannot PUSH");
            return;
        }
        else
        {
            top++; //goes from -1 to 0
            data[top] = val;
        }
    }
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot POP!");
            return -1; //-1 condition cus it's empty
        }
        int val = data[top];
        top--;
        return val;
    }

    public void Display()
    {
        if(!IsEmpty())
        {
            for(int i = top; i>=0; i--)
            {
                Console.WriteLine(data[i]);
            }
        }
    }

    public int Peek()
    {
        if (IsEmpty()) {Console.WriteLine("Stack is empty"); return -1;}
        return data[top];
    }
}
