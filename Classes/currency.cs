using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz.Classes
{
    public class Currency
    {
        public void CurrencyCalculation()
        {
            // gold => currecy
            System.Console.WriteLine("select your currency:");
            System.Console.WriteLine(" USD / EURO / WON / SUM");
            int Gold, currecy;
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "USD":
                    System.Console.Write("Gold in gramm: ");
                    Gold = Convert.ToInt32(Console.ReadLine());
                    currecy = Gold * 63;
                    System.Console.WriteLine("your money:" + currecy + " USD\n");
                break;

                case "EURO":
                    System.Console.Write("Gold in gramm: ");
                    Gold = Convert.ToInt32(Console.ReadLine());
                    currecy = Gold * 58;
                    System.Console.WriteLine("your currecy: " + currecy + " EURO\n");
                break;

                case "WON":
                    System.Console.Write("Gold in gramm: ");
                    Gold = Convert.ToInt32(Console.ReadLine());
                    currecy = Gold * 84819;
                    System.Console.WriteLine("your currecy: " + currecy + " WON\n");
                break;
                case "SUM":
                    System.Console.Write("Gold in gramm: ");
                    Gold = Convert.ToInt32(Console.ReadLine());
                    currecy = Gold * 762400;
                    System.Console.WriteLine("your currecy: " + currecy + " SUM\n");
                break;
            }
        }
    }
}