using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Figure;

namespace Test
{
    [TestFixture]
    class TCircle
    {
        [Test]
        public void Create()
        {
            Circle circle = new Circle(1);

            Assert.AreEqual(Math.PI, circle.Square());
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void TestMinus(double r)
        {
            Assert.Throws<Exception>(delegate { new Circle(r); });
        }

        //Делаю упрощенный тест. Не беру мин, мах. Просто однозначение.
        [TestCase(1, 3.14)]
        public void TestNormal(double r, double result)
        {
            Circle circle = new Circle(1);

            Assert.AreEqual(result, Math.Round(circle.Square(), 2));
        }
    }
}
