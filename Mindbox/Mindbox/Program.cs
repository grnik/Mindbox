using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //При написании тестов не нужно, но мне так проще разрабатывать.

            IFigure figure1 = new Circle(1);
            double square = figure1.Square();
            Console.WriteLine(square.ToString());
            figure1 = new Circle(5);
            square = figure1.Square();
            Console.WriteLine(square.ToString());

            figure1 = new Triangle(1, 1, 1);
            square = figure1.Square();
            Console.WriteLine(square.ToString());
            figure1 = new Triangle(3, 4, 5);
            square = figure1.Square();
            Console.WriteLine(square.ToString());

        }
    }
}
