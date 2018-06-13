using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace КДЗ___Ярных_Роман
{
    /// <summary>
    /// Класс для работы с заданной функцией
    /// </summary>
    class Function
    {
        public bool GapPoint { get; private set; }
        public Func<double, double> MyFunc {private get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Function()
        {
            MyFunc = x =>
            {
                double res;
                if (x != -Y && Math.Exp(Math.Abs(x - Y)) != -x / 2.0)//Проверим, удовлетворяет ли точка x заданной области определения
                {
                    res = Math.Pow(Y, Math.Pow(Math.Abs(x), 1.0 / 3.0)) + Math.Cos(x) * Math.Cos(x) * Math.Cos(x) * ((Math.Abs(x - Y) * (1 + (Math.Sin(Z) * Math.Sin(Z)) / Math.Sqrt(x + Y))) / (Math.Exp(Math.Abs(x - Y)) + x / 2.0));
                    GapPoint = false;
                }
                else
                {
                    res = 0;
                    GapPoint = true;
                }
                return res; 
            };
        }
        /// <summary>
        /// Получаем значение функции в данной точке
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        public double this[double X]{
            get
            {
                return MyFunc(X);
            }
        }
    }
}
