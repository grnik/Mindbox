using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : IFigure
    {
        #region Properties

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        /// <summary>
        /// Треугольник прямоуголный.
        /// </summary>
        public bool Right
        {
            get
            {
                double a2 = A * A;
                double b2 = B * B;
                double c2 = C * C;

                double max;
                double sum;
                if (a2 < b2)
                {
                    max = b2;
                    sum = a2;
                }
                else
                {
                    max = a2;
                    sum = b2;
                }
                if (max < c2)
                {
                    sum += max;
                    max = c2;
                }
                else
                {
                    sum += c2;
                }

                return (sum == max);
            }
        }
        #endregion

        #region Constructors
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            //На максимум не проверяю.
            CheckPlusSide();
            CheckSumSide();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Проверка, что сумма двух сторон меньше третьей.
        /// </summary>
        private void CheckSumSide()
        {
            double max;
            double sum2;
            if (A < B)
            {
                max = B;
                sum2 = A;
            }
            else
            {
                max = A;
                sum2 = B;
            }
            if (max < C)
            {
                sum2 += max;
                max = C;
            }
            else
            {
                sum2 += C;
            }
            if (sum2 <= max)
                throw new Exception("Сумма двух сторон не может быть меньше длины третьей.");
        }

        /// <summary>
        /// Проверка что длина всех сторон положительная.
        /// </summary>
        private void CheckPlusSide()
        {
            if ((A <= 0) || (B <= 0) || (C <= 0))
                throw new Exception("Длина стороны треуголника должна быть больше 0");
        }

        public double Square()
        {
            //S = √(p·(p - a)·(p - b)·(p - c)), P = (a+b+c)/2 
            double P = (A + B + C) / 2;

            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }

        #endregion
    }
}
