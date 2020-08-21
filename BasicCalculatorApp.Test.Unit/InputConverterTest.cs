using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCalculatorApp.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertValidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }
    }
}
