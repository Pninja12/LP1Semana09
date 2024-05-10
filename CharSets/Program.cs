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

            for(int i = 0; i < args.Length; i++)
            {
                string s;
                using StreamReader file = new StreamReader(args[i]);
                List<string> chars = new List<string>();
                while ((s = file.ReadLine()) != null)
                {
                    chars.Add(s);
                    if (s.Length > 2)
                    {
                        Console.Write("Error: File with 2 chars in same line");
                        Environment.Exit(1);
                    }
                }
                list_of_chars.Add(chars);
            }
            foreach (List<string> a in list_of_chars)
            {
                foreach (string b in a)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
