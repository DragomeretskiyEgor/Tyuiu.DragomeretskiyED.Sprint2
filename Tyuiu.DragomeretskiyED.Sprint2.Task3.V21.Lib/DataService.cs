using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DragomeretskiyED.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y = 0;
            
            if (x > 0)
            {
               // x (x + 9 / x - 1)
            }
            else
            {
                if (x==0)
                {
                    // x^2 + 10 / x^2 - sin x^2 + 12
                }
                else
                {
                    if ((x > -3) && (x<0))
                    {
                        // y = Math.Sin(x)
                    }
                    else
                    {
                        if (x < -3)
                        {
                            //y = ((x - 5) / (x + 3)) + x
                        }
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
