using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HashSet<string>> list_of_chars = new List<HashSet<string>>();

            for(int i = 0; i < args.Length; i++)
            {
                string s;
                using StreamReader file = new StreamReader(args[i]);
                HashSet<string> chars = new HashSet<string>();
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
            

            HashSet<string> intersection= new HashSet<string>(list_of_chars[0]);

            intersection.IntersectWith(list_of_chars[1]);
            intersection.IntersectWith(list_of_chars[2]);
            

            List<string> final_list = new List<string>(intersection);
            final_list.Sort();
            foreach(string a in final_list)
            {
                Console.WriteLine(a);
            }
            
        }
    }
}
