using System;
using System.Globalization;
using System.Collections.Generic;
using Employee.Entities;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee {i} data:");
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Outsourced(y/n)?");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.Write("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employees(name, hours, valuePerHour));
                }
            }
                Console.Write("\nPayments:\n");
                foreach(Employees e in list)
                {
                    Console.WriteLine(e.Name + "-$" + e.Payment().ToString("F2",CultureInfo.InvariantCulture));
                }
            }
        }
    }