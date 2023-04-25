using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowComputerCalculateTangent
{
    public class MrkMathHelper
    {
        
        public static double AngleToRadian(double angle) // @mdrezak
        => angle * 3.14159265358979323846 / 180;//3.14159265358979323846 is PI (64 bit)

        public static double Sin2(double radian, double precision = 100)
        {
            double term = radian;
            double sum = 0;
            for (int i = 1; i <= precision; i += 2)
            {
                sum += term;
                term *= (-1) * radian * radian / ((i + 1) * i);
            }
            return sum;
        }


        public static double Tan(double radian, double precision = 100) // @mdrezak
        => Sin(radian,precision) / Cos(radian);

        public static double Sin(double radian, double precision = 100) // @mdrezak
        {
            double sinValue = radian;
            double term = radian;
            int i = 1;
            while (i < precision)
            {
                term = -term * radian * radian / ((2 * i) * (2 * i + 1));
                sinValue += term;
                i++;
            }
            return (sinValue);
        }

        public static double Cos(double radians) // @mdrezak
        {
            double cos = 1;
            double term = 1;
            int i = 2;
            while (Math.Abs(term) > 0.000001)
            {
                term *= -1 * radians * radians / (i * (i - 1));
                cos += term;
                i += 2;
            }
            return cos;
        }

    }
}
