using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise1
{
    class Car
    {
        public string strModel;
        public string strBrand;
        public float fltPrice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car objCar1;         //part (b) declare an object name of type car
            objCar1 = new Car(); // Part (c) instantiate the object objCar1
            // Car objCar1 = new Car();

            Console.Write("What is the model of your car: ");
            objCar1.strModel = Console.ReadLine();
            Console.Write("What is the brand of your car: ");
            objCar1.strBrand = Console.ReadLine();
            Console.Write("What is the price of your car: ");
            objCar1.fltPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Car Model {0}, Brand is {1}, price is {2}", objCar1.strModel, objCar1.strBrand, objCar1.fltPrice);
        }
    }
}
