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
    public sealed partial class GalleryFotograficaPage : Page, INotifyPropertyChanged
    {
        public const string GalleryFotograficaSelectedIdKey = "GalleryFotograficaSelectedIdKey";
        public const string GalleryFotograficaAnimationOpen = "GalleryFotografica_AnimationOpen";
        public const string GalleryFotograficaAnimationClose = "GalleryFotografica_AnimationClose";

        private ObservableCollection<SampleImage> _source;

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public GalleryFotograficaPage()
        {
            // TODO WTS: Replace this with your actual data
            Source = SampleDataService.GetGallerySampleData();
            InitializeComponent();
        }

        private void ImagesGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selected = e.ClickedItem as SampleImage;
            ImagesGridView.PrepareConnectedAnimation(GalleryFotograficaAnimationOpen, selected, "galleryImage");
            NavigationService.Navigate<GalleryFotograficaDetailPage>(e.ClickedItem);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                var selectedImageId = await ApplicationData.Current.LocalSettings.ReadAsync<string>(GalleryFotograficaSelectedIdKey);
                if (!string.IsNullOrEmpty(selectedImageId))
                {
                    var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation(GalleryFotograficaAnimationClose);
                    if (animation != null)
                    {
                        var item = ImagesGridView.Items.FirstOrDefault(i => ((SampleImage)i).ID == selectedImageId);
                        ImagesGridView.ScrollIntoView(item);
                        await ImagesGridView.TryStartConnectedAnimationAsync(animation, item, "galleryImage");
                    }

                    ApplicationData.Current.LocalSettings.SaveString(GalleryFotograficaSelectedIdKey, string.Empty);
                }
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
