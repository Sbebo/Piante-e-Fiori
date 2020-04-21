using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Microsoft.Toolkit.Uwp.UI.Controls;

using Piante_e_Fiori.Models;
using Piante_e_Fiori.Services;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Piante_e_Fiori.Views
{
    public sealed partial class RampicantiPage : Page, INotifyPropertyChanged
    {
        private Rampicanti _selected;

        public Rampicanti Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<Rampicanti> SampleItems { get; private set; } = new ObservableCollection<Rampicanti>();

        public RampicantiPage()
        {
            InitializeComponent();
            Loaded += RampicantiPage_Loaded;
        }

        private async void RampicantiPage_Loaded(object sender, RoutedEventArgs e)
        {
            SampleItems.Clear();

            var data = await RampicantiDataService.GetSampleModelDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (MasterDetailsViewControl.ViewState == MasterDetailsViewState.Both)
            {
                Selected = SampleItems.First();
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
