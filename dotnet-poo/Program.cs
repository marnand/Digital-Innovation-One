using System;
using dotnet_poo.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 2, "knight");
            Wizard wizard = new Wizard("Jennica", 23, "White wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(4));
            Console.WriteLine(wizard.Attack(9));
        }
    }
}
