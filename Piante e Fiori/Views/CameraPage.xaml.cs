using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Piante_e_Fiori.EventHandlers;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Piante_e_Fiori.Views
{
    public sealed partial class CameraPage : Page, INotifyPropertyChanged
    {
        public CameraPage()
        {
            InitializeComponent();
        }

        private void CameraControl_PhotoTaken(object sender, CameraControlEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Photo))
            {
                Photo.Source = new BitmapImage(new Uri(e.Photo));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
