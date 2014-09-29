using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Sep2014_Code_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary operation 

            //int value = 50;
            //string result = (value >= 60 && value < 80) ? "A+" : "out";

            //Sum application using for loop

            //int upperValue = "";

            //int result = GetSumUntil(upperValue);

            //Console.WriteLine(result);
            //Console.ReadKey();

            double[] numbers = new double[5];
            double sum = 0;
            Console.WriteLine("This program adds five numbers");

            //insertion area
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine("Enter number " + (index + 1).ToString());
                string userInput = Console.ReadLine();
                numbers[index] = Convert.ToDouble(userInput);

                
            }



            //calculation area
            for (int count = 0; count < numbers.Length; count++)
            {
                sum = sum + numbers[count];
            }


            Console.WriteLine("Sum of five numbers is: " + sum);
            Console.ReadKey();



        }

        public static int GetSumUntil(int upperValue)
        {
            int result = 0;
            for (int counter = 0; counter < upperValue; counter++)
            {
                result = result + counter;
            }

            return result;
        }
       
    }
}
