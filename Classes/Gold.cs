using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Classes
{
    public class Gold
    {
        public void GoldCalculation()
        {
            //currecy => gold 
            System.Console.WriteLine("select your currency:");
            System.Console.WriteLine(" USD / EURO / WON / SUM");
            decimal Gold, currecy;
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "USD":
                    System.Console.Write("enter the amount of money:");
                    currecy = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Gold = currecy / 63;
                    System.Console.WriteLine($"your gold: {Gold}  gramm or  {Gold/1000} kg");
                break;

                case "EURO":
                    System.Console.Write("enter the amount of money:");
                    currecy = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Gold = currecy / 58;
                    System.Console.WriteLine($"your gold: {Gold}  gramm or  {Gold/1000} kg");
                break;

                case "WON":
                    System.Console.Write("enter the amount of money:");
                    currecy = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Gold = currecy / 84819;
                    System.Console.WriteLine($"your gold: {Gold}  gramm or  {Gold/1000} kg");
                break;

                case "SUM":
                    System.Console.Write("enter the amount of money:");
                    currecy = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Gold = currecy / 762400;
                    System.Console.WriteLine($"your gold: {Gold}  gramm or  {Gold/1000} kg");

                break;
            }
        }
    }
}