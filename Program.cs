using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryWorker.Entitis;
using SalaryWorker.Entitis.Enums;
using System.Globalization;


namespace SalaryWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Departament's Name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Leval (Junior/Pleno/Senior): ");
            WorkerLeval leval = (WorkerLeval)Enum.Parse(typeof(WorkerLeval), Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departament deptament = new Departament(deptName);
            Worker worker = new Worker(name, leval,baseSalary ,deptament);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                Double valePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duraction (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valePerHour,hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and yer to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int Year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for  " + monthAndYear + ": " + worker.Income(Year, month).ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
