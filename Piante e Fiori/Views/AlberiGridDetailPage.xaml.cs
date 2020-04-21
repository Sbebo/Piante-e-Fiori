using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using Microsoft.Toolkit.Uwp.UI.Animations;

using Piante_e_Fiori.Models;
using Piante_e_Fiori.Services;

using Piante_e_Fiori.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Piante_e_Fiori.Views
{
    public sealed partial class AlberiGridDetailPage : Page, INotifyPropertyChanged
    {
        private Alberi _item;

        public Alberi Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public AlberiGridDetailPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is long alberoID)//orderID
            {
                var data = await AlberiDataService.GetContentGridDataAsync();
                Item = data.First(i => i.AlberoID == alberoID);//(i => i.OrderID == orderID);
            }
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                NavigationService.Frame.SetListDataItemForNextConnectedAnimation(Item);
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
