using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Example
{
    class School
    {
        public string strSchoolName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public School(string strSchoolName, string strAddress)
        {
            this.strSchoolName = strSchoolName;
            this.strAddress = strAddress;
        }
    }
    class Student : School
    {
        public string strStudentName;
        private float fltSchoolFees;
        public float FltSchoolFees
        {
            get { return fltSchoolFees; }
            set { if(value > 0.0f)
                  fltSchoolFees = value; }
        }
        public Student(string strStudentName, 
                        float fltSchoolFees, 
                        float fltSchoolName, 
                        string strAddress) : base (strSchoolName, strAddress)
        {
            this.strStudentName = strStudentName;
            SchoolFees = fltSchoolFees;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student objS1;
            Console.Write("Enter the school: ");
            string mySchool = Console.ReadLine();
            Console.Write("Enter the address: ");
            string myAddress = Console.ReadLine();
            Console.Write("Enter the students naem: ");
            string myName = Console.ReadLine();
            Console.Write("Enter the school fee: ");
            float mySchoolFees = float.Parse(Console.ReadLine());

            objS1 = new Student("Tontan", -2f, "E2STEM", "Phnom Penh");

            Console.WriteLine("School name: {0}", objS1.strSchoolName);
            Console.WriteLine("Address name: {0}", objS1.Address);
            Console.WriteLine("Student name: {0}", objS1.strStudentName);
            Console.WriteLine("School fee: {0}", objS1.FltSchoolFees);
        }
    }
}
