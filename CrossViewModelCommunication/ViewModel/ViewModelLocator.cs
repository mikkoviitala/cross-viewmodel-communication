using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace ExampleUsingViewModelLocator.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator : INotifyPropertyChanged
    {
        private string _background;
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<ContentPageViewModel>(true);
            SimpleIoc.Default.Register<MainViewModel>();
            Background = "#77BB11";
        }

        public MainViewModel MainVM { get { return ServiceLocator.Current.GetInstance<MainViewModel>(); } }

        public ContentPageViewModel ContentPageVM { get { return ServiceLocator.Current.GetInstance<ContentPageViewModel>(); } }

        public string Background
        {
            get { return _background; }
            set { _background = value; OnPropertyChanged(); }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}