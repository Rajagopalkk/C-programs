using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        /// <summary>
        /// Read & Print the integer elements in an Array.
        /// </summary>
        /// <param name="args"></param>
        static void Main_Renamed(string[] args)
        {
            //Console.WriteLine("What is the length of your array ?");
            //int arrLength = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Length is {arrLength}");
            ////Console.WriteLine("The Length is {1}",arrLength);
            //int[] myIntegerArr = new int[arrLength];
            #region Array Initialisation

            //myIntegerArr[0] = 10;
            //myIntegerArr[1] = 20;
            //myIntegerArr[2] = 30;
            //myIntegerArr[3] = 40;
            //myIntegerArr[4] = 50;

            //Console.WriteLine($"1st element : {myIntegerArr[0]} \t " +
            //    $"2nd element : {myIntegerArr[1]}\t" +
            //    $"3rd element : {myIntegerArr[2]}\t" +
            //    $"4th element : {myIntegerArr[3]}\t" +
            //    $"5th element : {myIntegerArr[4]}\t");
            #endregion
            #region Read from Console & display on console window
            //for (int i = 0; i < arrLength; i++)
            //{
            //    Console.WriteLine($"Please enter {i} element : ");
            //    myIntegerArr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"The elements are : \t");
            //for (int i = 0; i < arrLength; i++)
            //{
            //    Console.WriteLine(myIntegerArr[i]);
            //}
            // Console.ReadLine();
            #endregion

            #region additional

            //SumOfAllElements();
            #endregion
            #region Reverse
            //Console.WriteLine("please enter your number: ");
            //int myInt = int.Parse(Console.ReadLine());
            //int[] myArray = new int[myInt];
            //for(int i=0; i<myInt; i++)
            //{
            //    Console.WriteLine($"please enter your number : {i} ");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}
            //int reverse = myArray[0];
            //for(int i=0; i<myInt; i--)
            //{
            //    reverse = myArray[i];
            //}
            //Console.WriteLine($"Reversed Number: {reverse}");
            //Console.ReadLine();
            #endregion

            #region largest and smallest number
            FindSmallestAndLargestNumber();

            #endregion
            Console.ReadLine();
        }

        private static void FindSmallestAndLargestNumber()
        {
            Console.WriteLine("Please enter the lenght of the Array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Entered length {arrayLength}");
            int[] myInt = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Please enter the   {i + 1} number:");
                myInt[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myInt);     //Ascending Order
            Array.Reverse(myInt);  // Descensing Order
            Console.WriteLine($"Largest number: {myInt[arrayLength - 1]} Smallest Number :{myInt[0]}");
        }
        private static void SumOfAllElements()
        {
            Console.WriteLine("Please enter the lenght of the Array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Entered length {arrayLength}");
            int[] myInt = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Please enter the   {i + 1} number:");
                myInt[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;    
            for (int i = 0; i < arrayLength; i++)
            {
                sum = myInt[i] + sum;                    
            }
            Console.WriteLine($"Sum of all element: {sum}");
        }
    }
}
