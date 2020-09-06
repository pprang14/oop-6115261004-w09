using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6115261004_w09
{
    class BMI
    {
        public static double calculate(double w, double h)
        {
            return w / Math.Pow(h, 2);
        }
    }
}
