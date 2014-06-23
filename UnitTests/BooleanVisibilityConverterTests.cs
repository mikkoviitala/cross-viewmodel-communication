using System;
using System.Windows;
using CrossViewModelCommunication.Converter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BooleanVisibilityConverterTests
    {
        private readonly BooleanVisibilityConverter _converter = new BooleanVisibilityConverter();

        [TestMethod]
        public void ConvertTest()
        {
            var expected = Visibility.Visible;
            Assert.AreEqual(expected, _converter.Convert(true, null, null, null));

            expected = Visibility.Collapsed;
            Assert.AreEqual(expected, _converter.Convert(false, null, null, null));
        }

        [TestMethod]
        public void ConvertBackTest()
        {
            Assert.AreEqual(true, _converter.ConvertBack(Visibility.Visible, null, null, null));
            Assert.AreEqual(false, _converter.ConvertBack(Visibility.Collapsed, null, null, null));
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void ConvertThrowsExceptionTest()
        {
            _converter.Convert(null, null, null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertBackThrowsExceptionTest()
        {
            _converter.ConvertBack(null, null, null, null);
        }
    }
}
