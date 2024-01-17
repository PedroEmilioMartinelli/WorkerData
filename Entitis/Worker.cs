using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using SalaryWorker.Entitis.Enums;

namespace SalaryWorker.Entitis
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLeval Leval { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLeval leval, double baseSalary, Departament departament)
        {
            Name = name;
            Leval = leval;
            BaseSalary = baseSalary;
            Departament = departament;
        }


        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year  == year && contract.Date.Month == month)
                {
                    sum += contract.ToalValue();
                }
            }
           return sum;
        }


    }
    }       
