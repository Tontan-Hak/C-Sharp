using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Excercisee_2
{
    internal class MedicalRecord
    {
        public string strPetientName;
        public string strDoctorName;
        public float fltFees;

        static void Main(string[] args)
        {
            MedicalRecord objM1,objM2;
            objM1 = new MedicalRecord();
            objM2 = new MedicalRecord();

            Console.Write("Enter the patient name: ");
            objM2.strPetientName = Console.ReadLine();
            Console.Write("Enter the doctor name: ");
            objM2.strDoctorName = Console.ReadLine();
            Console.Write("Enter the value of the member: ");
            objM2.fltFees = int.Parse(Console.ReadLine());

            Console.WriteLine("Movie title {0}, genre is {1}, year is {2}", objM2.strPetientName, objM2.strDoctorName, objM2.fltFees);
        }
    }
}

