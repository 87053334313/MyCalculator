using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class KvadratnoeUravnenie
    {
        public static string KvUravnenie(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                string strX = "имеется два корня уравнения, т.к. Дискреминант больше нуля  ";
                double x1 = ((-b + (Math.Sqrt(D)) )/ (2 * a));
                double x2 = ((-b - (Math.Sqrt(D))) / (2 * a));
                string Sx1 = "Первый корень x1="+x1.ToString()+"   ";
                string Sx2 = "Второй корень x2="+x2.ToString()+"   ";
                string otvet = strX+Sx1+Sx2;
                return otvet;
            }
            else if (D == 0)
            {
                string strx = "имеется олин корень уравнения, т.к. Дискреминано равен нулю";
                double x = (-b) / (2 * a);
                string sx = "Корень уравненя=" + x.ToString();
                string otvet = strx + sx;
                return otvet;
            }
            else
            {
                string strX = "Нет корней, т.к. Дискрименант меньше нуля";
                string otvet = strX;
                return otvet;
            }
        }
    }
}
