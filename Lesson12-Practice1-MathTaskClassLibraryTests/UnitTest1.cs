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
            // �������� ������
            int a = 3;
            int b = 5;
            int expected = 15;

            // ��������� �������� � ������� ������������ ������
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // ��������� ���������� ���������� � ����������
            Assert.AreEqual(expected, actual);
        }
    }
}
