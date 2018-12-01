using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3KamalpreetKaurP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secNum;
            string operation;
            int answer;

            for (int i=0; ; i++)
            {
                try {
                    Console.Write("Enter first number.");
                    firstNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number.");
                    secNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter operation(plus,minus,multiply,divide).");
                    operation =(Console.ReadLine());

                    if (operation == "multiply")
                    {
                        answer = firstNum * secNum;
                        Console.WriteLine(firstNum + "x" + secNum + "=" + answer);
                    }
                    else if (operation == "divide")
                    {
                        answer = firstNum / secNum;
                        Console.WriteLine(firstNum + "/" + secNum + "=" + answer);
                    }
                    else if (operation == "plus")
                    {
                        answer = firstNum + secNum;
                        Console.WriteLine(firstNum + "+" + secNum + "=" + answer);
                    }
                    else if (operation == "minus")
                    {
                        answer = firstNum - secNum;
                        Console.WriteLine(firstNum + "-" + secNum + "=" + answer);
                    }
                    else 
                    {
                        Console.WriteLine("Entered operation is incorrect");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Enter valid value");
                }
            }
        }
    }
}
