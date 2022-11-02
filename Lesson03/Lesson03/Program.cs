using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Cube
    {
        private float fltSide;
        public Cube(float x)    //x is the float parameter
                                //x exits when Cube is called
                                //x is gone when Cube finishes running 
                                //x is also known as an automatic variable
        {
            fltSide = x;
        }
        public string GetSide()
        {
            return fltSide.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("type the length of the side for the cube: ");
            float x = float.Parse(Console.ReadLine());
            Cube c1Obj = new Cube(2.5f); //2.5f can replay bey y  //2.5f is the float argument
            Console.WriteLine("The length of the side of the cube is {0}", c1Obj.GetSide());
        }
    }
}
