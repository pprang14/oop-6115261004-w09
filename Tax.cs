using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261004_w09
{
    class Tax
    {
        public static double calculate(double salary)
        {
            double tax = 0;
            double yearIncome = salary * 12;
            if (yearIncome <= 150000)
            {
                tax = 0;
            }
            else if (yearIncome <= 300000)
            {
                tax = (yearIncome - 150000) * 0.05;
            }
            else if (yearIncome <= 500000)
            {
                tax = (yearIncome - 300000) * 0.1 + 7500;
            }
            else if (yearIncome <= 750000)
            {
                tax = (yearIncome - 500000) * 0.15 + 20000 + 7500;
            }
            else if (yearIncome <= 1000000)
            {
                tax = (yearIncome - 750000) * 0.20 + 37500 + 20000 + 7500;
            }
            else if (yearIncome <= 2000000)
            {
                tax = (yearIncome - 1000000) * 0.25 + 50000 + 37500 + 20000 + 7500;
            }
            else if (yearIncome <= 5000000)
            {
                tax = (yearIncome - 2000000) * 0.30 + 250000 + 50000 + 37500 + 20000 + 7500;
            }

            else if (yearIncome >= 5000000)
            {
                tax = (yearIncome) * 0.35 + 900000 + 250000 + 50000 + 37500 + 20000 + 7500;
            }

            return tax;
        }
    }
}
