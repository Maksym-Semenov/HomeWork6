using System;
using System.Collections.Generic;

namespace HomeWork6
{
    internal class Program
    {
        public static List <int> ReadNumber(int startRange, int finishRange)
        {
            List<int> list = new List<int>(10);
            
            int count = 0;
            try
            {
                int forComparison = startRange;
            action4:
                Console.Write($"Enter current value more than {forComparison}:\t");
                bool successParse = int.TryParse(Console.ReadLine(), out int currentValue);
                if (successParse)
                {
                    if (currentValue > startRange && currentValue < finishRange && currentValue > forComparison && count < 10)
                    {
                        list.Add(currentValue);
                        count++;
                        forComparison = currentValue;
                        goto action4;
                    }
                    else if (currentValue < startRange || currentValue > finishRange)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your current value is out of range");
                        Console.ResetColor();
                        goto action4;
                    }
                    else if (currentValue <= forComparison)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Current value must be more than last value");
                        Console.ResetColor();
                        goto action4;
                    }
                    else if (count >= 10)
                    {
                        return list;
                    }
                    else
                    {
                        throw new Exception("It's wrong value!");
                    }
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Your type is not right!");
                    Console.ResetColor();
                    goto action4;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t HomeWork 6");
     action1:
            Console.Write("Enter starting value of range:\t");
            bool successParse1 = int.TryParse(Console.ReadLine(), out int startRange);
            if (successParse1)
            {
                goto action2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Your type is not right!");
                Console.ResetColor();
                goto action1;
            }
     action2:
            Console.Write("Enter last value of range:\t");
            bool successParse2 = int.TryParse(Console.ReadLine(), out int finishRange);
            if (successParse2)
            {
                goto action3;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Your type is not right!");
                Console.ResetColor();
                goto action2;
            }
     action3:
            List<int> list = new List<int>(10);
            list = ReadNumber(startRange, finishRange);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("\t Your sequence of values:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
