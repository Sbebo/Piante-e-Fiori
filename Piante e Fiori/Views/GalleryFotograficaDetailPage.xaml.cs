using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Piante_e_Fiori.Helpers;
using Piante_e_Fiori.Models;
using Piante_e_Fiori.Services;

using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Piante_e_Fiori.Views
{
    public sealed partial class GalleryFotograficaDetailPage : Page, INotifyPropertyChanged
    {
        private DispatcherTimer _timer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(500) };
        private object _selectedImage;
        private ObservableCollection<SampleImage> _source;

        public object SelectedImage
        {
            get => _selectedImage;
            set
            {
                Set(ref _selectedImage, value);
                ApplicationData.Current.LocalSettings.SaveString(GalleryFotograficaPage.GalleryFotograficaSelectedIdKey, ((SampleImage)SelectedImage).ID);
            }
        }

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public GalleryFotograficaDetailPage()
        {
            // TODO WTS: Replace this with your actual data
            Source = SampleDataService.GetGallerySampleData();
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var sampleImage = e.Parameter as SampleImage;
            if (sampleImage != null && e.NavigationMode == NavigationMode.New)
            {
                SelectedImage = Source.FirstOrDefault(i => i.ID == sampleImage.ID);
            }
            else
            {
                var selectedImageId = await ApplicationData.Current.LocalSettings.ReadAsync<string>(GalleryFotograficaPage.GalleryFotograficaSelectedIdKey);
                if (!string.IsNullOrEmpty(selectedImageId))
                {
                    SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageId);
                }
            }

            var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation(GalleryFotograficaPage.GalleryFotograficaAnimationOpen);
            animation?.TryStart(previewImage);
            showFlipView.Begin();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                previewImage.Visibility = Visibility.Visible;
                ConnectedAnimationService.GetForCurrentView()?.PrepareToAnimate(GalleryFotograficaPage.GalleryFotograficaAnimationClose, previewImage);
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
