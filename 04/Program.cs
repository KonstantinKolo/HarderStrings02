using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('>').ToArray();
            int left = 0;
            char lastel;
            string lastst;
            for (int s1 = 1; s1 <= input.Length - 2; s1++)
            {
                if (int.Parse(input[s1]) > 0)
                {
                    left += int.Parse(input[s1]) - 1;
                }
                input[s1] = ">";
            }
            input[1] = ">>";
            lastst = input[input.Length - 1];
            lastel = lastst.ElementAt(0);
            left += lastel - '0';
            Console.WriteLine(left);
            lastst = lastst.Remove(0, left);
            input[input.Length - 1] = input[input.Length - 1].Replace(input[input.Length - 1], lastst);
            Console.WriteLine(lastst);
            Console.WriteLine(string.Join("", input));
        }
    }
}
