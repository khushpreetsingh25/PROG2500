using System;

namespace CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //DATA TYPES
            int myNum = 5;               // integer (whole number)
            double myDoubleNum = 5.99D;  // floating point number
            char myLetter = 'D';         // character
            bool myBool = true;          // boolean
            string myText = "Hello";     // string
            Console.WriteLine(myNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);

            // if/else and switch statements
            DisplayWeatherReport(15.0);  // Output: Cold.
            DisplayWeatherReport(24.0);  // Output: Perfect!

            void DisplayWeatherReport(double tempInCelsius)
            {
                if (tempInCelsius < 20.0)
                {
                    Console.WriteLine("Cold.");
                }
                else
                {
                    Console.WriteLine("Perfect!");

                    // --switch statement 
                    DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
                    DisplayMeasurement(5);   // Output: Measured value is 5.
                    DisplayMeasurement(30);  // Output: Measured value is 30; too high.
                    DisplayMeasurement(double.NaN);  // Output: Failed measurement.
                }
            }

            void DisplayMeasurement(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine($"Measured value is {measurement}; too low.");
                        break;

                    case > 15.0:
                        Console.WriteLine($"Measured value is {measurement}; too high.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Failed measurement.");
                        break;

                    default:
                        Console.WriteLine($"Measured value is {measurement}.");
                        break;
                }
            }

            //OPERATORS AND THEIR USAGE
            int sum1 = 100 + 50;     // 150 (100 + 50)
            int sum2 = sum1 + 250;   // 400 (150 + 250)
            int sum3 = sum2 + sum2;  // 800 (400 + 400)
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            // LOOP STRUCTURES:
            int x = 1;

            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("Khushpreet_Singh");

                // Increment the value of x for the next iteration
                x++;
            }
        }
    }
}
