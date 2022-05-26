using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main2(string[] args)
        {

            //<data-type>  <variable-name>
            int a = 5;
            int b = 5;
         


            //whether a number is positive or not
            int positiveNumber = 0;
            Console.WriteLine();
            if (positiveNumber > 0)
            {
                Console.WriteLine(positiveNumber + " is a positive Number");
            }
            else if (positiveNumber < 0)
            {
                Console.WriteLine(positiveNumber + " is not a positive Number");
            }
            else
            {
                Console.WriteLine(positiveNumber + " is neither postive nor negative");
            }
        }
    }
}
