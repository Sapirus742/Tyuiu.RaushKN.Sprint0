﻿using Tyuiu.RaushKN.Sprint0.Task4.V0.Lib;

namespace Tyuiu.RaushKN.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substraction(15,5));
            Console.WriteLine(DataService.Multiplication(10,10));
            Console.WriteLine(DataService.Division(5,5));
            Console.ReadKey();
        }
    }
}
