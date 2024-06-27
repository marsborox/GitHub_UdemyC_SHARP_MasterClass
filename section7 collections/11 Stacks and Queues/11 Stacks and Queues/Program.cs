using System.ComponentModel.DataAnnotations;

namespace _11_Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {//define stack
            Stack<int> stack = new Stack<int>();
            //add element to stack using Push()
            stack.Push(1);

            
            //Peek wil lreturn element at the top without removing it
            Console.WriteLine("Top Value is: {0}",stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top Value is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top Value is: {0}", stack.Peek());

            int myStackItem = stack.Pop();
            Console.WriteLine("Popped item : {0}", myStackItem);
            Console.WriteLine("Top Value is: {0}", stack.Peek());
            while (stack.Count > 0) {

            Console.WriteLine("top value is {0}", stack.Pop());
            Console.WriteLine("Current stack is {0}", stack.Count);
            }

            //Display numbers in reverse order and add to stack
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> myStack = new Stack<int>();
            int j = numbers.Length-1; //noo lebo length je 7 ale index zacina od 0
            while (j >= 0) 
            {
                Console.WriteLine("pushed value {0}", numbers[j]);
                myStack.Push(numbers[j]);
                j--;
            }
            Console.WriteLine("second try");
            Stack<int> myStack2 = new Stack<int>();
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine("pushed value {0}", numbers[i]);
                myStack2.Push(numbers[i]);
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);// add item to queue
            Console.WriteLine("The value at the front of the queue is {0}",queue.Peek());
            queue.Enqueue(2);// add item to queue
            Console.WriteLine("The value at the front of the queue is {0}",queue.Peek());
            queue.Enqueue(3);// add item to queue
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
            queue.Enqueue(4);// add item to queue
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
            queue.Dequeue();//removne
            int queueItem = queue.Dequeue(); //removne tiez, ak nema co da error!!!
            Console.WriteLine("dequeued item {0}",queueItem);
            Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());

            Queue<int> queue2 = new Queue<int>();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            queue2.Enqueue(3);
            queue2.Enqueue(4);
            queue2.Enqueue(5);

            
            while (queue2.Count > 0)
            {
                Console.WriteLine("Current queue count is: {0}",queue2.Count);
                Console.WriteLine("{0} has been removed from queue", queue2.Dequeue()); //aj tu to spravi aj keby si nejaku variable 
                                                                        //vyrobim a samostnatne dam dequeue
            }
        }
    }
   

}
