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
            //Initialize variables to hold values
            double grade = 0.0;
            int roundGrade = 0;
            //Prompts user to give grade percentage
            Console.Write("What is a numeric score (0 to 100)? ");
            //Takes user input and stores in variable/memory
            grade = Convert.ToDouble(Console.ReadLine()); 
            //Rounds grade up if it is 0.05 to next grade
            roundGrade = Convert.ToInt32(Math.Round(grade));
            Console.WriteLine(roundGrade); //Output new grade
            //Divide roundGrade by 10 to make it fall into case structure
            switch (roundGrade/10) 
            {
                case 9:
                    Console.WriteLine($"The letter grade for score {grade} is: A"); //Output original grade and letter grade
                    break;
                case 8:
                    Console.WriteLine($"The letter grade for score {grade} is: B"); //Output original grade and letter grade
                    break;
                case 7:
                    Console.WriteLine($"The letter grade for score {grade} is: C"); //Output original grade and letter grade
                    break;
                case 6:
                    Console.WriteLine($"The letter grade for score {grade} is: D"); //Output original grade and letter grade
                    break;
                case 5:
                    Console.WriteLine($"The letter grade for score {grade} is: F"); //Output original grade and letter grade
                    break;
            }
            //Pause program to view
            Console.ReadLine();
        }
    }
}
