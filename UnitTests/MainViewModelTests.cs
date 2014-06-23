using CrossViewModelCommunication.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class MainViewModelTests
    {
        private readonly MainViewModel _mainViewModel = new MainViewModel();

        [TestMethod]
        public void TitlePropertyTest()
        {
            const string expected = "Some title";
            _mainViewModel.Title = expected;
            Assert.AreEqual(expected, _mainViewModel.Title);
        }

        [TestMethod]
        public void BackgroundPropertyTest()
        {
            const string expected = "#ffffff";
            _mainViewModel.Background = expected;
            
            Assert.AreEqual(expected, _mainViewModel.Background);
        }

        [TestMethod]
        public void BackgroundPropertyChangedRaisedTest()
        {
            const string background = "#ffffff";
            const string expected = "Background";
            string actual = null;
            _mainViewModel.PropertyChanged += (sender, args) => actual = args.PropertyName;

            _mainViewModel.Background = background;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeBackgroundCommandTest()
        {
            const string expected = "#ffffff";
            _mainViewModel.ChangeBackgroundCommand.Execute(expected);
            Assert.AreEqual(expected, _mainViewModel.Background);
        }
    }
}
