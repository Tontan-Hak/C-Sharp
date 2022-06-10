using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01ConsoleApp
{
    class student
    {
        public string strName;
        public string strCourse;
        public string strGroup;
        public int intAge;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj1, obj2;
            obj1 = new student();
            obj2 = new student();
            Console.Write("Enter the name for student 1: ");
            obj1.strName = Console.ReadLine();
            Console.Write("Enter the course name for student 2: ");
            obj1.strCourse = (Console.WriteLine());
            Console.Write("Enter the group name for student 1: ");
            obj1.strGroup = Console.WriteLine();
            Console.Write("Enter the age name for student 1: ");
            obj1.intAge = int.Parse(Console.WriteLine());

            Console.WriteLine("Your name is {0}, and you reply your age as {1}, and your Height as {2}", UserName, Age.ToString(), Height);
        }
    }
}
