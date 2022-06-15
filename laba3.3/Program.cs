using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3

{
 
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number: ");
            int end = Int32.Parse(Console.ReadLine());
            IEnumerable<int> numbers = Enumerable.Range(start, end);
            int last = numbers.Last();
            Console.Write("List of numbers: ");
            foreach (int i in numbers)
            {
                if (i == last)
                {
                    Console.Write(i);
                    Console.Write(".");
                }
                else
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
            }
            IEnumerable<int> doubleNum = numbers.Where(c => c > 9 && c < 100);

            if (doubleNum.Any())
            {
                int count = 0;
                foreach (int i in doubleNum)
                {
                    count++;
                }
                double average = doubleNum.Average();
                Console.WriteLine(" ");
                Console.WriteLine("The number of positive double figures: {0}.", count);
                Console.WriteLine("The average of this numbers: {0}.", average);
            }
            else
            { 
                Console.WriteLine(" ");
                Console.WriteLine("The number of positive double figures: 0");
                Console.WriteLine("The average of this numbers: 0.0");
            }
            
     }
    }
}
