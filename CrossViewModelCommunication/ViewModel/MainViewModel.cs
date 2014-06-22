using System.Windows.Input;
using ExampleUsingViewModelLocator.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace ExampleUsingViewModelLocator.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _background;

        public MainViewModel()
        {
            Title = "Communication between ViewModels";
            Background = "#DEAA66";

            ChangeBackgroundCommand = new RelayCommand<string>(param => Background = param);
            Messenger.Default.Register<ChangeBackgroundMessage>(this, message => Background = message.Hex);
        }

        public string Title { get; set; }

        public string Background
        {
            get { return _background; }
            set { _background = value; RaisePropertyChanged("Background"); }
        }

        public ICommand ChangeBackgroundCommand { get; set; }
    }
}