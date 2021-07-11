﻿using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comissions = -1.0;

            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comissions = sales * 0.05; 
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comissions = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comissions = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comissions = sales * 0.12;
                    }
                    
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comissions = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comissions = sales * 0.75;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comissions = sales * 0.10;
                    }
                    else if (sales > 10000)
                    {
                        comissions = sales * 0.13;
                    }
                    
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comissions = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comissions = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comissions = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comissions = sales * 0.145;
                    }
                    
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
            Console.WriteLine($"{comissions:F2}");
            
        }
    }
}
