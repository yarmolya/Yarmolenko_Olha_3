using System;
using System.Collections.Generic;


namespace laba3
{
    class Program
    {
        private static int CompareLinesByLength(string x, string y)
        {
            
                 
                    int retval = x.Length.CompareTo(y.Length);

                    if (retval != 0)
                    {
                        
                        return retval;
                    }
                    else
                    {
                      
                        return x.CompareTo(y);
                    }
                
            
        }

        private static string SeperateWords (string x)
        {
            string[] words = x.Split(' ');
            string max = "";
            for (int i = 0; i < words.Length; i++) { 
                if (words[i].Length > max.Length)
                {
                    max = words[i];
                }
            }
            return max;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Write the lines of poem and press Enter");
            var lines = new List<string> { };
            while (true)
            {
                String s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }
                else
                {
                    lines.Add(s);
                }
            }

            Console.WriteLine("Your poem: ");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Sort(CompareLinesByLength);
            Console.WriteLine(" ");
            Console.WriteLine("Your sorted by the length of lines poem: ");
            foreach (string line in lines)
            {
                
                Console.WriteLine(line);
                
            }
            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];
                lines[i] = SeperateWords(line);

            }
           
            string max = "";
            foreach(string line in lines)
            {
                if(line.Length > max.Length)
                {
                    max = line;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("The longest word in your poem is: ");
            Console.Write(max);
        }

       
    }
}

