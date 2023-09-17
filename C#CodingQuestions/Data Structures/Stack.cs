using System;

class Stack
{
    private int[] array;
    private int top;
    private int capacity;

    public Stack(int capacity)
    {
        this.capacity = capacity;
        array = new int[capacity];
        top = -1;
    }

    public void Push(int element)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push element.");
        }
        else
        {
            top++;
            array[top] = element;
            Console.WriteLine("Pushed element: " + element);
        }
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop element.");
            return -1; // You can throw an exception here if you prefer.
        }
        else
        {
            int poppedElement = array[top];
            top--;
            Console.WriteLine("Popped element: " + poppedElement);
            return poppedElement;
        }
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. No element to peek.");
            return -1; // You can throw an exception here if you prefer.
        }
        else
        {
            Console.WriteLine("Peeked element: " + array[top]);
            return array[top];
        }
    }

    public bool IsEmpty()
    {
        return (top == -1);
    }

    public bool IsFull()
    {
        return (top == capacity - 1);
    }

    static void Main(string[] args)
    {
        Stack stack = new Stack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.Pop();

        stack.Push(40);
        stack.Push(50);

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();
    }
}
