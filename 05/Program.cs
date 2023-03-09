using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string censorLength;
            for (int s1 = 0; s1 < input.Length; s1++)  
            {
                censorLength = new string('*', word.Length); 
                input[s1] = input[s1].Replace(word, censorLength);
            }
            Console.WriteLine(string.Join(" ", input));           
        }
    }
}
