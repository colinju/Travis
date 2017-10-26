using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class ConvertTests
    {
        [TestMethod]
        public void TestEmpty()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("");

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestI()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("I");

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestIII()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("III");

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestV()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("V");

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestX()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("X");

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestL()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("L");

            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestC()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("C");

            //Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestD()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("D");

            //Assert
            Assert.AreEqual(500, result);
        }

        [TestMethod]
        public void TestM()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("M");

            //Assert
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void TestIV()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("IV");

            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestVI()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("VI");

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiple()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            var result = converter.Convert("MDCLXI");

            //Assert
            Assert.AreEqual(1661, result);
        }

        [TestMethod]
        public void TestException()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            Assert.ThrowsException<Exception>(() => converter.Convert("P"));
        }

        [TestMethod]
        public void TestExceptionMessage()
        {
            //Arrange
            var converter = new MyConverter();

            //Act
            Assert.ThrowsException<Exception>(() => converter.Convert("P"), "Nombre incorrect !");
        }

    }
}