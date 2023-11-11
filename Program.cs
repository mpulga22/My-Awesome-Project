using System;
using System.Globalization;
using System.Xml;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to roll the dice");
         //   int count = Convert.ToInt32(Console.ReadLine());
           
        //    for (int i = 1; i <= count; i++)
        //    {    
        //         int result = Convert.ToInt32(Math.Pow(2,i));
        //         //raise 2^
        //         Console.WriteLine(result);
        //    }
            
            Random random = new Random();

            int roll1 = 0;
            int roll2 = 1;

            int attempts = 0;
               
            while(roll1!=roll2){
                Console.ReadKey();
                attempts+=1;
                roll1 = random.Next(1,7); 
                roll2 = random.Next(1,7);                 
                Console.WriteLine($"attempt:{attempts}");
                Console.WriteLine($"Dice 1:{roll1}, Dice 2 : {roll2}");
                
            }
            
                Console.WriteLine($"It took you {attempts} attemps to have {roll1} and {roll2} together");
              

             //wait before closing
            Console.ReadKey();
        }
    }
}
