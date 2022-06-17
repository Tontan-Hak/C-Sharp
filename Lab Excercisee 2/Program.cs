using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Excercisee_2
{
    internal class Movie
    {
        public string strTitle;
        public string strGenre;
        public int intYear;
    
        static void Main(string[] args)
        {
            Movie objMovie1;        
            objMovie1 = new Movie(); 

            Console.Write("What is the title of your movie: ");
            objMovie1.strTitle = Console.ReadLine();
            Console.Write("What is the genre of your movie: ");
            objMovie1.strGenre = Console.ReadLine();
            Console.Write("What is the year of your movie: ");
            objMovie1.intYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Movie title {0}, genre is {1}, year is {2}", objMovie1.strTitle, objMovie1.strGenre, objMovie1.intYear) ;
        }
    }
}
