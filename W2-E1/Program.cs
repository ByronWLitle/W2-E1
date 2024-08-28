using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize global variable
            double grade = 0.0;
            int roundGrade = 0;
            //Prompts user to give grade percentage
            Console.Write("What is a numeric score (0 to 100)? ");
            //Takes user input and stores in variable/memory
            grade = Convert.ToDouble(Console.ReadLine()); 
            //Rounds grade up if it is 0.05 to next grade
            roundGrade = Convert.ToInt32(Math.Round(grade));
            Console.WriteLine(roundGrade); //Output new grade
            switch (roundGrade/10) 
            {
                case 9:
                    Console.WriteLine($"The letter grade for score {grade} is: A");
                    break;
                case 8:
                    Console.WriteLine($"The letter grade for score {grade} is: B");
                    break;
                case 7:
                    Console.WriteLine($"The letter grade for score {grade} is: C");
                    break;
                case 6:
                    Console.WriteLine($"The letter grade for score {grade} is: D");
                    break;
                case 5:
                    Console.WriteLine($"The letter grade for score {grade} is: F");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
