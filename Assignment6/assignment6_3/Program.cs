/*
You are developing a program to manage a call queue of customers using the Queue  in C#. 
The program creates a queue of callers and demonstrates the functionality of enqueueing elements 
into the queue and iterating over the elements and dequeuing.

Use linked lists.
*/
using System.Collections.Generic;
using System;

// From Class
class Node
{
    public string data;
    public Node next;
    public Node(string val, Node next)
    {
        this.data = val;
        this.next = next;
    }

}

class Q
{
    Node front;
    Node rear;
    int size;
    public bool IsEmpty()
    {
        return this.size == 0;
    }
    public void Enqueue(string customers)
    {
        Node newNode = new Node(customers, null);
        if (IsEmpty())
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
        size++;
    }
    public string? Dequeue()
    {
        if(IsEmpty()) 
        {
            Console.WriteLine("Q is empty");
            return null;
            
        }
        string customers = front.data;
        front = front.next;
        size --;
        if (IsEmpty())
            rear = null;
        return customers;
    }
    public void Display()
    {
        Node temp = front;
        if(!IsEmpty())
        {
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        else
            Console.WriteLine("Q is empty");
    }

}

class Program 
{
    static void Main(string[] args)
    {
        //Instanciate class Q
        Q callQ = new Q();
        
        callQ.Enqueue("MaoMao");
        callQ.Enqueue("Jinshi");
        callQ.Enqueue("Gyokuyu");
        callQ.Enqueue("Lihaku");
        callQ.Enqueue("Pairin");
        callQ.Enqueue("Meimei");
        callQ.Enqueue("Lihua");
        callQ.Enqueue("Ah-Duo");
        callQ.Enqueue("Lishu");

        Console.WriteLine("Current Call Queue: ");
        callQ.Display();

        Console.WriteLine($"Current Caller: {callQ.Dequeue()}");
        Console.WriteLine($"Remaining Customers: ");
        callQ.Display();


    }
}