﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay_5
{
    internal class PowerOfTwo
    {
        public static void PowerOfTwoNum()      //Creating method
        {
            Console.WriteLine("Please enter the range for power calculation");          //Taking user input 
            int n = Convert.ToInt32(Console.ReadLine());
            double result = 1;      //Initializing value

            for (int i = 1; i <= n; i++)        //For loop to check condition
            {
                //result = result*2;
                result = Math.Pow(2, i);
                Console.WriteLine("2^{0} = {1}", i, result);
            }

        }
    }
}
