using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.Entitis
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valePerHour, int hours)
        {
            Date = date;
            ValePerHour = valePerHour;
            Hours = hours;
        }

        public Double ToalValue()
        {
            return ValePerHour * Hours;
        }


        
    }
}
