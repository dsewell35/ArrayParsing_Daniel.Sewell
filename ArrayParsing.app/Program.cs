using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayParsing.app
{
    internal class Program //The following Program accepts an input to make an array the size
                           //The user desires to store grades and holds them until the end of the program.
    {

        static void Main(string[] args)
        {
            int counter;
            string keepGoing = "Y"; //Initializes a variable to start the loop

            while (keepGoing == "Y" || keepGoing == "y") //Starts a loop that will repeat as long as 
                                                         //the keepGoing Variable is y or Y
            {
                Console.WriteLine("How many scores would you like to register?");
                var inputCounter = Console.ReadLine(); //Placeholder to check if input is an int

                if (int.TryParse(inputCounter, out counter)) // Loop checks that the number of iterations is an int
                    Console.WriteLine($"You want to process: {counter} grades.");
                else
                    Console.WriteLine("This is not a number!");

                double[] testScores = new double[counter]; // Beginning of array

                for (int i = 0; i < testScores.Length; i++) //Steps through Loop
                {
                    while (true)
                    {


                        Console.WriteLine("Enter the next test score.");
                        var checkScores = Console.ReadLine(); //Placeholder to check if score input is a double
                        if (double.TryParse(checkScores, out testScores[i])) //Loop checks if input is a number and/or a double
                        {
                            Console.WriteLine($"You entered:" + testScores[i]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("This is not a fractional number");
                        }
                    }
                }
                Console.WriteLine("The scores you entered are: ");
                for (int i = 0; i < testScores.Length; i++)
                {
                    Console.WriteLine(testScores[i]);
                }


                Console.WriteLine("Do you want to reset? Y for yes, any other key to end program."); //Gets input to determine if there is more scores to input/resets program
                keepGoing = Console.ReadLine();



            }



        }

    }
}
