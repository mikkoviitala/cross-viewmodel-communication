using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ExampleUsingViewModelLocator.ViewModel
{
    public class ContentPageViewModel : ViewModelBase
    {
        public ContentPageViewModel()
        {
            Title = "Content page title";

            ChangeBackgroundCommand = new RelayCommand(() =>
            {
                var locator = Application.Current.Resources["Locator"] as ViewModelLocator;
                if (locator != null)
                    locator.Background = "#22EE44";
            });
        }

        public string Title { get; set; }

        public ICommand ChangeBackgroundCommand { get; set; }
    }
}