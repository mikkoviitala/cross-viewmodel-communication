using CrossViewModelCommunication.Message;
using CrossViewModelCommunication.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ContentPageViewModelTests
    {
        private readonly ContentPageViewModel _pageViewModel = new ContentPageViewModel();

        [TestMethod]
        public void TitlePropertyTest()
        {
            const string expected = "Some title";
            _pageViewModel.Title = expected;
            Assert.AreEqual(expected, _pageViewModel.Title);
        }

        [TestMethod]
        public void BackgroundChangedMessageSentTest()
        {
            const string expected = "#ffffff";
            string actual = null;

            Messenger.Default.Register<ChangeBackgroundMessage>(this, message => actual = message.Hex);
            _pageViewModel.ChangeBackgroundCommand.Execute(expected);

            Assert.AreEqual(expected, actual);
        }
    }
}
