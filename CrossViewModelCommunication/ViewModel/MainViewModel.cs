using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ExampleUsingViewModelLocator.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Title = "Communication between ViewModels";

            ChangeBackgroundCommand = new RelayCommand(() =>
                {
                    var locator = Application.Current.Resources["Locator"] as ViewModelLocator;
                    if (locator != null)
                        locator.Background = "#BEDEFE";
                });
        }

        public string Title { get; set; }

        public ICommand ChangeBackgroundCommand { get; set; }
    }
}