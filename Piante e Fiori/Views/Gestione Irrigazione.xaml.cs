using Piante_e_Fiori.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=234238

namespace Piante_e_Fiori.Views
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class Gestione_Irrigazione : Page
    {
        public Gestione_Irrigazione()
        {
            this.InitializeComponent();

            ListViewAlarms.ItemsSource = DataModel.Alarms;
        }

        private void ButtonAddAlarm_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddAlarmPage));
        }

        private async void ListViewAlarms_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyAlarm alarm = e.ClickedItem as MyAlarm;

            MessageDialog dialog = new MessageDialog("Do you want to delete this alarm?");
            dialog.Commands.Add(new UICommand("Delete") { Id = "delete" });
            dialog.Commands.Add(new UICommand("Cancel"));

            var result = await dialog.ShowAsync();
            if (object.Equals(result.Id, "delete"))
            {
                await DataModel.DeleteAlarm(alarm);
            }
        }

        private void ButtonViewScheduled_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ViewScheduledToastsPage));
        }
    }
}
