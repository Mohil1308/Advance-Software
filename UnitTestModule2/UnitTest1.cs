using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using module_2_section;  // Make sure the namespace is correct


namespace UnitTestModule2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void testIfStatements()
        {

            try
            {
                int num = 25;
                int num2 = 35;
                string symbol = "=";
                if (symbol == "=")
                {
                    if (num == num2)
                    {
                        Assert.AreEqual(num, num2, 00.1, "Numbers are matched");
                    }
                    else
                    {
                        Assert.AreNotEqual(num, num2, 00.1, "Numbers are not matched");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Symbol is not correct.");
            }
        }
        [TestMethod]
        public void setParameterTest()
        {
            var r = new DrawRectangle();
            int x = 200, y = 200, width = 100, height = 100;
            r.set(x, y, height, width);
            Assert.AreEqual(200, 400);
        }

        [TestMethod]
        public void setParameterTest3()
        {
            var r = new DrawRectangle();
            int x = 100, y = 300, width = 200, height = 400;
            r.set(x, y, height, width);
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void setParameterTest2()
        {
            var l = new drawTriangle();
            int x = 200, y = 200, toX = 200, toY = 200;
            l.set(x, y, toX, toY);
            Assert.AreEqual(200, y);
        }
        [TestMethod]
        public void setmethodtest()
        {
            var circle = new DrawCircle();
            int x = 200, y = 200, radius = 100;
            circle.set(x, y, radius);
            Assert.AreEqual(200, y);
        }
    }
}