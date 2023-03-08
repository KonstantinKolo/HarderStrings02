using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            if (command[0] == "Append")
            {
                input = $"{input}{command[1]}";
            }
            else if (command[0] == "Remove")
            {
                input = input.Remove(int.Parse(command[1]), int.Parse(command[2]));
            }
            else if (command[0] == "Insert")
            {
                input = input.Insert(int.Parse(command[1]), command[2]);
            }
            else if (command[0] == "Replace") 
            {
                input = input.Replace(command[1], command[2]);
            }
            Console.WriteLine(input);
        }
    }
}
