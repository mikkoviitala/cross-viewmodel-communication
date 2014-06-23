using System;
using System.Windows;
using System.Windows.Media;
using CrossViewModelCommunication.Converter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StringBrushConverterTests
    {
        private readonly StringBrushConverter _converter = new StringBrushConverter();

        [TestMethod]
        public void ConvertTest()
        {
            const string hex = "#FFFFFFFF";
            Assert.IsTrue((_converter.Convert(hex, null, null, null) is SolidColorBrush));
        }

        [TestMethod]
        [ExpectedException(typeof (FormatException))]
        public void ConvertThrowsExceptionTest()
        {
            _converter.Convert("not-a-hex", null, null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void ConvertBackThrowsExceptionTest()
        {
            _converter.ConvertBack(null, null, null, null);
        }
    }
}
