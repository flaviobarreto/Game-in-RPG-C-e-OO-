using System;
using RPJ.srs.Entities;

namespace dotnet__poo{
    class Program{
        static void Main(string[]args){

            Hero arus = new Hero("Arus", 23, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
        }
    }
}