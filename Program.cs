using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doviz.Classes;

namespace Doviz
{
    public class Program
    {
        public static void Main()
        {
            Currency currency = new Currency();
            Gold gold= new Gold();
            
            System.Console.WriteLine("Wellcome to Doviz!\n");
            Key:
            System.Console.WriteLine("1. Currency => Gold");
            System.Console.WriteLine("2. Gold => Currency");
            System.Console.WriteLine("3. Exit");
            string access = Console.ReadLine();
            Console.Clear();
            switch (access)
            {
                case "1":
                    gold.GoldCalculation();
                    goto Key;
                break;

                case "2":
                    currency.CurrencyCalculation();
                    goto Key;
                break;

                case "3":
                    System.Console.WriteLine("Thank you for using our service!");
                    Console.ReadKey();
                break;
                
            }
        }
    }
}

