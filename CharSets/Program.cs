using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> list_of_chars = new List<List<string>>();

            Console.WriteLine(args.Length);
            for(int i = 0; i < args.Length; i++)
            {
                string s;
                using StreamReader file = new StreamReader(args[i]);
                List<string> chars = new List<string>();
                while ((s = file.ReadLine()) != null)
                {
                    chars.Add(s);
                }
                list_of_chars.Add(chars);
            }
        }
    }
}
