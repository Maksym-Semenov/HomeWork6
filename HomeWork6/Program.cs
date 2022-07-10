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
            List<int> list = new List<int>();
            Console.Write("Enter current value:\t");
            int currentValue = Convert.ToInt32(Console.ReadLine());
            int temp = currentValue;
            int count;
            try
            {
                if (currentValue > a && currentValue < b && currentValue > temp)
                {

                }

            }
            catch (Exception)
            {

                throw;
            }
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
            Console.WriteLine(list);
            Console.ReadLine();
        }
    }
}
