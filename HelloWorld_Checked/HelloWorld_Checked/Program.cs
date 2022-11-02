using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //There is integer variable named x also

namespace HelloWorld_Checked
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String UserName = Console.ReadLine();
            Console.Write("What is your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("What is your heiget in meter: ");
            float Height = float.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0}, and you reply your age as {1}, and your Height as {2}", UserName, Age.ToString(), Height);
            Console.ReadKey();   //This is needed if we start with debugging 
        }
    }
}
