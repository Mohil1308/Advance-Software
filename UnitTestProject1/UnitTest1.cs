using ASE__ASSINGMENT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        DrawingControl ctrl = new DrawingControl();

        [TestMethod]
        public void TestDrawLine()
        {
            ctrl.DrawLine(100, 300);
            Assert.IsTrue(DrawingShapes.isUnitValid);
        }
        //Method for unit test to Draw Square
        [TestMethod]
        public void TestSquare()
        {
            ctrl.DrawSquare(25);
            Assert.IsTrue(DrawingShapes.isUnitValid);
        }
        //Method for unit to Draw Circle
        [TestMethod]
        //Method for unit test to Move pen
        public void TestMove()
        {
            ctrl.MovePoint(20, 100);
            Assert.IsTrue(DrawingShapes.isUnitValid);
        }

        //Method for unit test to Draw Triangle
        [TestMethod]
        public void TestTriangle()
        {
            ctrl.DrawTriangle(120, 150, 170);
            Assert.IsTrue(DrawingShapes.isUnitValid);
        }
        //Method for unit test to Draw Rectangle
        [TestMethod]
        public void TestRectangle()
        {
            ctrl.DrawRect(100, 300);
            Assert.IsTrue(DrawingShapes.isUnitValid);
        }

        [TestMethod]
        public void TestCircle()
        {
            ctrl.DrawCircle(25);
            Assert.IsTrue(DrawingShapes.isUnitValid);
        }
    }
}
