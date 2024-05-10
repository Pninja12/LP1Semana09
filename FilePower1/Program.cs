using System;
using System.Collections;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = " ";
            Queue lista = new Queue();

            while(empty != "")
            {
                empty = Console.ReadLine();
                if (empty != "")
                lista.Enqueue(empty);
            }
        }
    }
}
