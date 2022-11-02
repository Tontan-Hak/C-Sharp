using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Ex3
{
    class Account
    {
        private string strType;
        private string strName;
        private float fltBalance;
        public float FltBalance
        {
            get { return fltBalance; }
            set { fltBalance = value; }
        }
        public Account(string PlsType, string GiveMeName, float ShowMeBalance)
        {
            strType = PlsType;
            strName = GiveMeName;
            fltBalance = ShowMeBalance;
        }
        public float CalInterest()
        {
            float ToCalInterest;
            ToCalInterest = fltBalance * 0.018f;
            return ToCalInterest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accObj;  
            Console.Write("Enter the type of the account: ");
            string type = Console.ReadLine();
            Console.Write("Enter the name of the account: ");
            string name = Console.ReadLine();
            Console.Write("Enter the balance of the account: ");
            float balance = float.Parse(Console.ReadLine());
            accObj = new Account(type, name, balance);  
            accObj.CalInterest();

            Console.WriteLine("balance ={0}, Interest = {1}", balance, accObj.CalInterest());
            Console.ReadKey();
        }
    }
}
