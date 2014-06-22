using System.Windows.Input;
using ExampleUsingViewModelLocator.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace ExampleUsingViewModelLocator.ViewModel
{
    public class ContentPageViewModel : ViewModelBase
    {
        public ContentPageViewModel()
        {
            Title = "Content page title";

            ChangeBackgroundCommand = new RelayCommand<string>(param =>
                    Messenger.Default.Send(new ChangeBackgroundMessage(param)));
        }

        public string Title { get; set; }

        public ICommand ChangeBackgroundCommand { get; set; }
    }
}