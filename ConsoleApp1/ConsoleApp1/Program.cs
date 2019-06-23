using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

       // int Func<int, int, int> Sum(int a, int b);
        static void Main(string[] args)
        {
            //  Print print = PrintNumber;
            //print(10);
            // Print printMoney = new Print(PrintMoney);
            // printMoney(20000);
            Func<int, int, int> add = (a,b)=>a+b;
          int result=  add(10, 10);
            Console.WriteLine(result);
            Console.ReadLine();

            Action<int> printMoney = PrintMoney;
            printMoney(20000);
        }
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("number: {0}", num);
            Console.ReadLine();
        }
        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0}", money);
            Console.ReadLine();
        }
    }
}
