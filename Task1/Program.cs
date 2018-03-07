using System;
using System.Linq;
using System.Collections.Generic;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int beltStudents = students - students / 6;
            double totalMoney = 0.0;

            double moneyForSabers = sabrePrice * Math.Ceiling(students + 0.1 * students);
            double moneyForRobes = robePrice * students;
            double moneyForBelts = beltPrice * beltStudents;
            totalMoney = moneyForSabers + moneyForRobes + moneyForBelts;
            if (totalMoney <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalMoney-moneyAmount):f2}lv more.");
            }
            
        }
    }
}
