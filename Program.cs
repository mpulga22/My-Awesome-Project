using System;
using System.Xml;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="SkyNet";
        
            Console.WriteLine("A proud knight named...");
            string name = Console.ReadLine();
            
            Console.WriteLine($"{name} Walked into a bar, At the counter he met a ...");
            string friendName = Console.ReadLine();

            Console.WriteLine($"{friendName} asked him what he wanted to drink?");
            string drink = Console.ReadLine();

            Console.WriteLine($"{drink}! shouted {name} {friendName} shushed {name} quickly.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"But it was too late... A dragon ate them {name} and {friendName}.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---The End----");
            
            
            Console.ReadKey();
        }
    }
}
