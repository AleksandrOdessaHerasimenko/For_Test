using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace For_Test
{
    public class Calculator
    {
        public int Result;

        public void ShowRerult()
        {
            Console.WriteLine($"Результат - {Result}");
        }

        public int Multiply(int x, int y)
        {
            Result = x * y;
            return Result;
        }

        public int Subtract(int x, int y)
        {
            Result = x - y;
            return Result;
        }
        public int Sum(int x, int y)
        {
            Result = x + y;
            return Result;
        }
        public int Devision(int x, int y)
        {
           if(y==0)
            {
                Result = -1;
            }
         else
            {
                Result = x / y;
               

            }
            return Result;
        }
        public int RemainderOfDivision(int x, int y)
        {
            if (y == 0)
            {
                Result = -1;
            }
            else
            {
              
                Result = x % y;
            }
            return Result;
           

        }

        public void Res(int selectedIndex, int a, int b)
        {
            switch (selectedIndex)
            {
                case 0:
                    {
                      Sum(a, b);
                        break;
                    }
                case 1:
                    {
                      Subtract(a, b);
                        break;

                    }
                case 2:
                    {
                         Multiply(a, b);
                        break;
                    }
                case 3:
                    {

                         Devision(a, b);

                        break;

                    }
                case 4:
                    {

                         RemainderOfDivision(a, b);
                        break;
                    }
            }
        }
    }

    internal class Program
    {
        
            
            
            static void Main(string[] args)
            {
            Console.WriteLine("Введите первый оперант ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите новер который соответствует оператору: \"+\"-0; \"-\"-1;\"*\"-2;\"/\"-3;\"%\"-4; ");
            int selectedIndex = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй оперант ");
            int b = Int32.Parse(Console.ReadLine());
            Program program = new Program();
            Calculator calculator = new Calculator();   
            calculator.Res(selectedIndex, a, b);
            calculator.ShowRerult();

            Console.ReadKey();
            }
    
    }
}

