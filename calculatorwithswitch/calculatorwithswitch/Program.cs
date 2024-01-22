using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal result = 0;
            string input;

            Console.WriteLine("Calculator");
            
            while (true)
            {
                Console.WriteLine("\nEnter a operation: ");

                Console.WriteLine("1 - addiction\n" + "2- subtraction\n" + "3- Divide\n" + "4- Multiplication\n" + "5-Operations History \n" + "6-Exit \n");

               
                

                input = Console.ReadLine();

                if ((input != "1") && (input != "2") && (input != "3") && (input != "4") && (input != "5")&&(input!="6"))
                {
                    Console.WriteLine("invalid Option! Try Again");
                    continue;
                }
                else if (input == "6")
                {
                  return;
                }
                                              
                Console.WriteLine("Enter one number: ");

                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter other number: ");

                num2 = Convert.ToDecimal(Console.ReadLine());

                switch (input)
                {


                    case "1":
                        result = num1 + num2; 
                        break;

                    case "2":
                        result = num1 - num2;
                        
                        break;

                    case "3":
                        result = num1 / num2; 
                        
                        break;

                    case "4":
                        result = num1 * num2;
                        
                     break;

                }
                Console.WriteLine($"The Total is: {result}");

            }
           














        }

    }

}
