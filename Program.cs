using System;
using System.Globalization;
using System.Xml;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] equations = new string[3];
            int[] answers = new int[3];
            for(int a = 0; a <= equations.Length-1;a++){

                #region form equation
            Random random = new Random();
            int[] numbers = new int[3];

            for(int number=0;number <= numbers.Length-1;number++){
                numbers[number] =   random.Next(1,9);
            }

            string[] operations = {"+","-","*","/"};
            string[] usedoperations = new string[2];
            
            for(int i = 0; i <= usedoperations.Length - 1 ; i++){
                usedoperations[i] = operations[random.Next(0,operations.Length-1)];
            }
          
            for(int i = 0; i<=numbers.Length-1;i++){

                if(i>0){
                   equations[a]+= usedoperations[i-1];

                   switch(usedoperations[i-1]){
                    case "+":
                        answers[a]+=numbers[i];
                        break;
                    case "-":
                        answers[a]-=numbers[i];
                        break;
                    case "*":
                        answers[a]*=numbers[i];
                        break;
                    case "/":
                        answers[a]/=numbers[i];
                        break;
                    
                   }
                }else{
                     answers[a]+=numbers[i];
                }
                     equations[a]+= (numbers[i]);
            }

           #endregion
               Console.Write(equations[a]+"=");   
                int input = Convert.ToInt32(Console.ReadLine());

            if(input == answers[a]){
                Console.WriteLine("correct");
            }else{
                 Console.WriteLine("Incorrect");
             
            }  
                      }
           
             //wait before closing
            Console.ReadKey();
        }
    }
}
