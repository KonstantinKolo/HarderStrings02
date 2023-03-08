using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('@').ToArray();
            int firstSum = 0;
            int secondSum = 0;
            foreach(char element in input[0])
            {
                firstSum += element;
            }
            foreach (char element in input[1])
            {
                secondSum += element;
            }
            if (firstSum >= secondSum)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
