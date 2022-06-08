using Assignment2;
using NUnit.Framework;

namespace Assignment2Tests
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleTest1
        {
            #region Get Length Test Cases
            [Test]
            public void GetLength_DefaultLengthDefaultWidth_OutputRectangleLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();

                //Act
                int actualLength = rectangle.GetLength();

                //Assert
                Assert.AreEqual(1, actualLength);
            }

            [Test]
            public void GetLength_InputLength16andWidth10_OutputRectangleLength()
            {
                //Arrange
                int length = 16;
                int width = 10;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualLength = rectangle.GetLength();

                //Assert
                Assert.AreEqual(length, actualLength);
            }

            [Test]
            public void GetLength_InputLengthMinus18andWidth8_OutputRectangleLength()
            {
                //Arrange
                int length = -18;
                int width = 8;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualLength = rectangle.GetLength();

                //Assert
                Assert.AreEqual(length, actualLength);
            }
            #endregion

            #region Get Width Test Cases

            [Test]
            public void GetWidth_DefaultLengthDefaultWidth_OutputRectangleLength()
            {
                //Arrange
                Rectangle rectangle = new Rectangle();

                //Act
                int actualWidth = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(1, actualWidth);
            }

            [Test]
            public void GetWidth_InputLength12andWidth5_OutputRectangleLength()
            {
                //Arrange
                int length = 12;
                int width = 5;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualWidth = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(width, actualWidth);
            }

            [Test]
            public void GetWidth_InputLength26andWidthMinus14_OutputRectangleLength()
            {
                //Arrange
                int length = 26;
                int width = -14;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualWidth = rectangle.GetWidth();

                //Assert
                Assert.AreEqual(width, actualWidth);
            }
            #endregion

            #region Set Length Test Cases

            [Test]
            public void SetLength_InputLength238_OutputRectangleLength()
            {
                //Arrange
                int length = 238;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualLength = rectangle.SetLength(length);

                //Assert
                Assert.AreEqual(length, actualLength);
            }

            [Test]
            public void SetLength_InputLengthMinus45_OutputRectangleLength()
            {
                //Arrange
                int length = -45;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualLength = rectangle.SetLength(length);

                //Assert
                Assert.AreEqual(length, actualLength);
            }

            [Test]
            public void SetLength_InputLength0_OutputRectangleLength()
            {
                //Arrange
                int length = 0;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualLength = rectangle.SetLength(length);

                //Assert
                Assert.AreEqual(length, actualLength);

            }
            #endregion

            #region Set Width Test Cases

            [Test]
            public void SetWidth_InputWidth89_OutputRectangleLength()
            {
                //Arrange
                int width = 89;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualWidth = rectangle.SetWidth(width);

                //Assert
                Assert.AreEqual(width, actualWidth);
            }

            [Test]
            public void SetWidth_InputWidth5_OutputRectangleLength()
            {
                //Arrange
                int width = 5;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualWidth = rectangle.SetWidth(width);

                //Assert
                Assert.AreEqual(width, actualWidth);
            }

            [Test]
            public void SetWidth_InputWidthMinus73_OutputRectangleLength()
            {
                //Arrange
                int width = -73;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualWidth = rectangle.SetWidth(width);

                //Assert
                Assert.AreEqual(width, actualWidth);

            }
            #endregion

            #region Get Perimeter Test Cases
            [Test]
            public void GetPerimeter_InputMaxLengthInputMaxWidth_OutputRectanglePerimter()
            {
                //Arrange
                int length = 2147483647;
                int width = 2147483647;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualPerimeter = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(2 * (length + width), actualPerimeter);
            }

            [Test]
            public void GetPerimeter_InputLength90InputWidth75_OutputRectanglePerimter()
            {
                //Arrange
                int length = 90;
                int width = 75;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualPerimeter = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(2 * (length + width), actualPerimeter);
            }

            [Test]
            public void GetPerimeter_InputLength1InputWidth1_OutputRectanglePerimter()
            {
                //Arrange
                int length = 1;
                int width = 1;
                Rectangle rectangle = new Rectangle();

                //Act
                int actualPerimeter = rectangle.GetPerimeter();

                //Assert
                Assert.AreEqual(2 * (length + width), actualPerimeter);

            }
            #endregion

            #region Get Area Test Cases
            [Test]
            public void GetArea_InputMaxLengthInputMaxWidth_OutputRectangleArea()
            {
                //Arrange
                int length = 2147483647;
                int width = 2147483647;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualArea = rectangle.GetArea();

                //Assert
                Assert.AreEqual(length * width, actualArea);
            }

            [Test]
            public void GetArea_InputLength164InputWidth93_OutputRectangleArea()
            {
                //Arrange
                int length = 164;
                int width = 93;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualArea = rectangle.GetArea();

                //Assert
                Assert.AreEqual(length * width, actualArea);
            }

            [Test]
            public void GetArea_InputLengthMinus14InputWidthMinus9_OutputRectanglerArea()
            {
                //Arrange
                int length = -14;
                int width = -9;
                Rectangle rectangle = new Rectangle(length, width);

                //Act
                int actualArea = rectangle.GetArea();

                //Assert
                Assert.AreEqual(length * width, actualArea);

            }
            #endregion
        }
    }
}
