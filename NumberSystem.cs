using System;

namespace MyFirstProgram
{
    class NumberSystem
    {
        static void Main(string[] args)
        {
            //string firstName = "Hubsons";
            //string lastName = "Clark";
            //string PhoneNumber = "890898989";
            //int age = 20;
            //var propeties = new object[] { "Hubsons" , "Clark" , "890898989",20 };
            //PringDetails(propeties);
            //string inputstr1 = "Hello";
            //HelloString(out inputstr1);
            //CheckVsUncheck();
            #region Pallindrom
            // long numberToCheck = 0;
            //Console.WriteLine($"Enter a Number to Check whether it's pallindrom or not ");
            //var result = checkPallindromNumber(numberToCheck);
            //Console.WriteLine($"Resule is :{result}");
            #endregion

            #region swap two numbers
            Console.WriteLine("Enter number to check it is armstrong or not");
            int numberToCheck = int.Parse(Console.ReadLine());
            int temp = numberToCheck;
            int reminder,sum=0;
            while(numberToCheck > 0)
            {
                reminder = Convert.ToInt32(numberToCheck % 10);
                sum = sum+(reminder*reminder*reminder);
                numberToCheck = numberToCheck / 10;
            }
            if(numberToCheck==temp)
            {
                Console.WriteLine($"Entered {numberToCheck} is Armstrong number");
            }
            else
            
                Console.WriteLine($"Entered {numberToCheck} is Not Armstrong number");
            
            #endregion
            Console.ReadLine();
        }
        //private static void CheckVsUncheck()
        //{
            //int x = int.MaxValue;
            //int y = int.MaxValue;
            //var z = x + y;
            //checked
            //{
            //    int val = x + y;
            //    Console.WriteLine(val + 2);
            //}
        //    unchecked
        //    {
        //        int val = x + y;
        //        Console.WriteLine(val + 2);
        //    }
        //}

        //private static string  checkPallindromNumber(long numberToCheck)
        //{
        //    var IsPallindromNumber = string.Empty;
        //    numberToCheck = long.Parse(Console.ReadLine());
        //    long temp = numberToCheck;
        //    int reminder = 0; long sum = 0;
        //    while (numberToCheck > 0)
        //    {
        //        reminder = Convert.ToInt32(numberToCheck % 10);
        //        sum = sum * 10 + reminder;
        //        numberToCheck = numberToCheck / 10;
        //    }
        //    if (sum == temp)
        //         IsPallindromNumber = "Pallindrom Number";
        //    else
        //        IsPallindromNumber = "Not a Pallindrom Number";
        //    return IsPallindromNumber;
        //}

       
        //Ref Vs Out Vs Params
        //public static void HelloString(out string inputstr)
        //{
        //    inputstr = "world";
        //}
        //public static void PringDetails(params object[] args)
        //{
        //    Console.WriteLine($" First Name :{args[0]}\n Last Name :{args[1]}\n PhoneNumber :{args[2]}\n Age :{args[3]}");
        //}
    }
}
