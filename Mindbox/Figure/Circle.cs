using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : IFigure
    {
        #region Properties

        /// <summary>
        /// Радиус
        /// </summary>
        public double r { get; private set; }

        #endregion

        #region Constructors
        public Circle(double r)
        {
            this.r = r;

            //На максимум не проверяю.
            CheckPlus();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Проверка что радиус положителен.
        /// </summary>
        private void CheckPlus()
        {
            if (r <= 0)
                throw new Exception("Радиус должен быть положительным");
        }

        public double Square()
        {
            return Math.PI * r * r;
        }

        #endregion
    }
}
