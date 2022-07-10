using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Program
    {
        public static List <int> ReadNumber(int a, int b)
        {
            List<int> list = new List<int>(10);
            
            int count = 0;
            try
            {
                int temp = a;
            step1:
                Console.Write("Enter current value:\t");
                int currentValue = Convert.ToInt32(Console.ReadLine());
                
                if (currentValue > a && currentValue < b && currentValue > temp && count < 10)
                {
                    list.Add(currentValue);
                    count++;
                    temp = currentValue;
                    goto step1;
                }
                else if (currentValue < temp)
                {
                    throw new Exception("It's wrong value!");
                    
                }
                goto step1;
                //else if (count >= 10)
                //{
                //    goto step2;
                //}
                else
                {
                    throw new Exception("It's wrong value!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        step2:
            return list;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10);
            Console.Write("Enter starting range:\t");
            int startRange = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter finishing range:\t");
            int finishRange = Convert.ToInt32(Console.ReadLine());
            list = ReadNumber(startRange, finishRange);
            Console.WriteLine(list.ToString());
            Console.ReadLine();
        }
    }
}
