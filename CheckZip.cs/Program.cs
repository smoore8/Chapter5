﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zips = new int[] { 20617, 2345, 43235, 10845, 13443, 12365, 64432, 12346, 12356, 76423 };
            Console.Write("Enter your Zipcode: ");
            String input = Console.ReadLine();
            int n = Convert.ToInt32(input);


            for (int i = 0; i < zips.Length; i++)
            {
                if (n == zips[i])
                {
                    Console.WriteLine("Yes we deliver to your Zip Code");
                }
                else if (n != zips[i])
                {
                    Console.WriteLine("We do not deliver to your Zip Code. Sorry.");
                }
            }









        }
    }
}