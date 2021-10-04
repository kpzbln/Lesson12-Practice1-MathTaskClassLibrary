using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson12_Practice1_MathTaskClassLibrary;

namespace Lesson12_Practice1_MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTest1
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
