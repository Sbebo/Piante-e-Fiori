using Piante_e_Fiori.Models;
using Piante_e_Fiori.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
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
    public sealed partial class Trattamenti_Piante : Page
    {
        public CalendarService lib = new CalendarService();
        //Library1 library1 = new Library1();
        public Trattamenti_Piante()
        {
            this.InitializeComponent();
          
        }

        //EVENTI SUL CALENDARIO
        private void New_Click(object sender, RoutedEventArgs e)
        {
            lib.New(StartDate, StartTime, Subject, Location, Details, Duration, AllDay);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            lib.Add(sender, StartDate, StartTime, Subject, Location, Details, Duration, AllDay);
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            lib.Calendar(StartDate, StartTime);
        }

       
    }
}
