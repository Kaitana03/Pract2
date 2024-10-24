using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    internal class Lib
    {
        public double Cos(int[] mas)
        {
            double OutValue = 0;
            for (int i = 0; i < mas.Length; i++) 
            {
                if (mas[i] < 3)
                {
                    OutValue += mas[i];
                }
            }
            return Math.Cos(OutValue);

        }

    }
}
