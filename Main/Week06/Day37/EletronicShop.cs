using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day37
{
    public class EletronicShop
    {
        public static double GetMoneySpent(double[] keyboardsPrice, double[] driversPrice, double budget)
        {
            double moneySpent = 0;

            foreach(var kbPrice in keyboardsPrice) {
                foreach(var dvPrice in driversPrice) {
                    var sum = kbPrice + dvPrice;

                    if(sum > moneySpent && sum <= budget) {
                        moneySpent = sum;
                    } 
                }
            }

            return moneySpent;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Keyboards Price: ");
            string keyboardsPriceStr = Console.ReadLine();
            var keyboards = keyboardsPriceStr.Trim().Split(' ');
            var keyboardsDoubleLst = new List<double>();

            foreach(var it1 in keyboards) {
                if(double.TryParse(it1, out double val)) {
                    keyboardsDoubleLst.Add(val);
                }
            }

            Console.Write("Drivers Price: ");
            string driversPriceStr = Console.ReadLine();
            var drivers = driversPriceStr.Trim().Split(' ');
            var driversDoubleLst = new List<double>();

            foreach(var it2 in drivers) {
                if(double.TryParse(it2, out double val)) {
                    driversDoubleLst.Add(val);
                }
            }

            Console.Write("Budget: ");
            if(double.TryParse(Console.ReadLine(), out double budget)) {
                var moneySpent = EletronicShop.GetMoneySpent(keyboardsDoubleLst.ToArray(), driversDoubleLst.ToArray(), budget);
                Console.WriteLine(moneySpent);
            }

        }
    }
    
}