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
            public void TestDrawLineWithVariables()
            {
                // Arrange: Declare variables
                ctrl.runCommands("var x1 100; var y1 300;");

                // Act: Draw a line using variables as coordinates
                ctrl.runCommands("drawline x1 y1;");

                // Assert: Check if the drawing was successful
                Assert.IsTrue(DrawingShapes.isUnitValid);
            }

            [TestMethod]
            public void TestSquareWithVariables()
            {
                // Arrange: Declare a variable for the square's side length
                ctrl.runCommands("var sideLength 25;");

                // Act: Draw a square using a variable for the side length
                ctrl.runCommands("designsquare sideLength;");

                // Assert: Check if the drawing was successful
                Assert.IsTrue(DrawingShapes.isUnitValid);
            }

            [TestMethod]
            public void TestMoveWithVariables()
            {
                // Arrange: Declare variables for the new position
                ctrl.runCommands("var newX 20; var newY 100;");

                // Act: Move the point to the new position using variables
                ctrl.runCommands("goto newX newY;");

                // Assert: Check if the movement was successful
                Assert.IsTrue(DrawingShapes.isUnitValid);
            }

            [TestMethod]
            public void TestTriangleWithVariables()
            {
                // Arrange: Declare variables for triangle vertices
                ctrl.runCommands("var vertex1 120; var vertex2 150; var vertex3 170;");

                // Act: Draw a triangle using variables for vertex coordinates
                ctrl.runCommands("designtriangle vertex1 vertex2 vertex3;");

                // Assert: Check if the drawing was successful
                Assert.IsTrue(DrawingShapes.isUnitValid);
            }

            [TestMethod]
            public void TestRectangleWithVariables()
            {
                // Arrange: Declare variables for rectangle dimensions
                ctrl.runCommands("var width 100; var height 300;");

                // Act: Draw a rectangle using variables for dimensions
                ctrl.runCommands("designrect width height;");

                // Assert: Check if the drawing was successful
                Assert.IsTrue(DrawingShapes.isUnitValid);
            }

            [TestMethod]
            public void TestCircleWithVariables()
            {
                // Arrange: Declare a variable for the circle's radius
                ctrl.runCommands("var radius 25;");

                // Act: Draw a circle using a variable for the radius
                ctrl.runCommands("designcircle radius;");

                // Assert: Check if the drawing was successful
                Assert.IsTrue(DrawingShapes.isUnitValid);
            }

            [TestMethod]
            public void TestDrawingCircle()
            {
                // Arrange
                DrawingControl drawingControl = new DrawingControl();
                string commands = "var a 50; designcircle a;";

                // Act
                drawingControl.runCommands(commands);

                // Assert
                // You can add assertions here to verify if the circle is drawn correctly
                // For example, you can check if the DrawingPaper contains a circle
            }

            [TestMethod]
            public void TestDrawingCircleWithInvalidParameters()
            {
                // Arrange
                DrawingControl drawingControl = new DrawingControl();
            string commands = "var a 50; designcircle;"; // Invalid command with missing parameter

            // Act & Assert
            Assert.IsTrue(DrawingShapes.isUnitValid);
            // Ensure that the method throws an exception for invalid parameters
        }

            [TestMethod]
            public void TestWhileLoop()
            {
                // Arrange
                DrawingControl drawingControl = new DrawingControl();
                string commands = "var a 500; var count 5; while count > 0; designcircle a; var a a-100; var count count-1; end;";

                // Act
                drawingControl.runCommands(commands);

                // Assert
                // Add assertions to verify if the circle is drawn and the loop executes correctly
            }

        [TestMethod]
        public void TestWhileLoopWithIncrement()
        {
            // Arrange
            DrawingControl drawingControl = new DrawingControl();
            string commands = "var a 500; var count 1; while count < 5; designcircle a; var a a-100; var count count+1; end;";

            // Act
            drawingControl.runCommands(commands);

            // Assert
            // Add assertions to verify if the circle is drawn and the loop executes correctly
        }

        [TestMethod]
        public void TestWhileLoopWithIncrement1()
        {
            // Arrange
            DrawingControl drawingControl = new DrawingControl();
            string commands = "var count 1; while count < 5; designcircle count; var count count+1; end;";

            // Act
            drawingControl.runCommands(commands);

            // Assert
            // Add assertions to verify if the circle is drawn and the loop executes correctly
        }

        [TestMethod]
        public void TestWhileLoopWithMultipleShapes()
        {
            // Arrange
            DrawingControl drawingControl = new DrawingControl();
            string commands = "var count 1; while count < 5; designcircle count; designrectangle count 90; var count count+1; end;";

            // Act
            drawingControl.runCommands(commands);

            // Assert
            // Add assertions to verify if the shapes are drawn and if the loop executes correctly
        }

        [TestMethod]
        public void TestIfConditionWithCircleDesign()
        {
            // Arrange
            DrawingControl drawingControl = new DrawingControl();
            string commands = "var count 100; if count > 5; designcircle a;";

            // Act
            drawingControl.runCommands(commands);

            // Assert
            // Add assertions to verify if the circle is drawn when the condition is met
        }
    }
    }
