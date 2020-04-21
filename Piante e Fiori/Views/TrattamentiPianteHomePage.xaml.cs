using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class TrattamentiPianteHomePage : Page
    {
        public TrattamentiPianteHomePage()
        {
            this.InitializeComponent();
        }

        private void gestione_trattamenti_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Trattamenti_Piante));
        }

        private void gestione_irrigazione_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Gestione_Irrigazione));
        }

        
    }
}
