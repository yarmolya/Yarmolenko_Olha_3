using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace laba2
{
    class Program
    {


        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> main = new List<int>();
            Dictionary<int, int> integer = new Dictionary<int, int>();

            for (int i = 0; i < 10; i++)
            {
                main.Add(rnd.Next(0, 99));
                integer.Add(i, main[i]);
            }
            Console.WriteLine("Dictionary: ");
            foreach (var kvp in integer)
            {
                
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            bool a;
            for (int i = 0; i < 10; i++)
            {
                a = integer.ContainsKey(main[i]);
                if (a == true)
                {

                    int numb = main[i];
                    for (int j = 0; j < i; j++)
                    {
                        numb += main[j];
                    }
                    main[i] = numb;
                    integer[i] = numb;

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("New dictionary: ");
            foreach (var kvp in integer)
            {

                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Json string: ");
            Console.Write(Newtonsoft.Json.JsonConvert.SerializeObject(integer, Formatting.Indented));
        }
    }
}