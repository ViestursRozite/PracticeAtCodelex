using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public class Commission : Hourly
    {
        public double CommissionRate { get; set; }
        public double TotalSales { get; set; }
        public Commission(
            string eName, 
            string eAddress, 
            string ePhone, 
            string socSecNumber, 
            double rate,
            double percentOnSales)
            :base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            this.CommissionRate = percentOnSales;
        }

        public void AddSales(double totalSales)
        {
            this.TotalSales += totalSales;
        }

        public override double Pay()
        {
            var earned = base.Pay() + (this.TotalSales * this.CommissionRate);
            TotalSales = 0;
            //don't need to set the hoursWorked back to 0—why not?
            //cause base.Pay() sets _hoursWorked = 0
            return earned;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotals sales: " + this.TotalSales;
            return result;
        }
    }
}
