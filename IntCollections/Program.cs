using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 10, -30, 10, -5};
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(10);
            stack.Push(-30);
            stack.Push(10);
            stack.Push(-5);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(10);
            queue.Enqueue(-30);
            queue.Enqueue(10);
            queue.Enqueue(-5);
            HashSet<int> hashset = new HashSet<int>() {1, 10, -30, 10, -5};
            int conta = 0;


            Console.Write("List:");
            conta = 0;
            foreach(int item in list)
            {
                Console.Write($" {item}");
                if (conta != list.Count)
                {
                    Console.Write(",");
                }
                conta += 1;
            }
            Console.WriteLine("");

            Console.Write("Stack:");
            conta = 0;
            foreach(int item in stack)
            {
                Console.Write($" {item}");
                if (conta != stack.Count)
                {
                    Console.Write(",");
                }
                conta += 1;
            }
            Console.WriteLine("");

            Console.Write("Queue:");
            conta = 0;
            foreach(int item in queue)
            {
                Console.Write($" {item}");
                if (conta != queue.Count)
                {
                    Console.Write(",");
                }
                conta += 1;
            }
            Console.WriteLine("");

            Console.Write("HashSet:");
            conta = 0;
            foreach(int item in hashset)
            {
                Console.Write($" {item}");
                if (conta != hashset.Count)
                {
                    Console.Write(",");
                }
                conta += 1;
            }
            Console.WriteLine("");
        }
    }
}
