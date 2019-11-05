using DomainProject.Entities.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Cavalo", "Quadrupede");
            Console.WriteLine(animal.ToString());
        }
    }
}
