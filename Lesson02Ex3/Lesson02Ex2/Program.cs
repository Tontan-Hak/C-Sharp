using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02Ex2
{
    class Phone
    {
        public string strModel;
        private float fltScreensize;

        public float ScreenSize
        {
            get { return fltScreensize; }
            set { if (value > 0)
                    fltScreensize = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone pObj = new Phone();
            Console.Write("Please enter model of the phone: ");
            pObj.strModel = (Console.ReadLine());
            Console.Write("Please enter the screen size: ");
            pObj.ScreenSize = float.Parse(Console.ReadLine());
            Console.WriteLine("Model of the phone: {0}, Screen size: {1}", pObj.strModel, pObj.ScreenSize);
            Console.ReadKey();
        }
    }
}
