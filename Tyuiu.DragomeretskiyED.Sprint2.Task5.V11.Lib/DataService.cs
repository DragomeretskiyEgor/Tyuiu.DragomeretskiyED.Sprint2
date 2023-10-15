using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DragomeretskiyED.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindMonthName(int value)
        {
            string res;
            switch (value)
            {
                case 1:
                    res = "Январь";
                case 2:
                    res = "Февраль";
                case 3:
                    res = "Март";
                case 4:
                    res = "Апрель";
                case 5:
                    res = "Май";
                case 6:
                    res = "Июнь";
                case 7:
                    res = "Июль";
                case 8:
                    res = "Август";
                case 9:
                    res = "Сентябрь";
                case 10:
                    res = "Октябрь";
                case 11:
                    res = "Ноябрь";
                case 12:
                    res = "Декабрь";
                    throw new ArgumentException($"Месяй должен быть от 1 до 12. Значение {value}");
            }
            return res;
        }
    }
}
