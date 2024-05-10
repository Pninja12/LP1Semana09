using System;
using System.Collections;
using System.IO;

namespace FilePower2
{
        class Program
    {
        static void Main(string[] args)
        {
            string empty = " ";

            Console.WriteLine(args[0]);
            using StreamWriter file = new StreamWriter(args[0]);

            while(empty != "")
            {
                empty = Console.ReadLine();
                if (empty != "")
                file.WriteLine(empty);
            }
        }
    }
}
