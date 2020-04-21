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
    public sealed partial class Categorie_Piante : Page
    {
        public Categorie_Piante()
        {
            this.InitializeComponent();
        }

        //MENU SEZIONI

        private void ALBERIbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AlberiPage));
        }
        
        
        private void ARBUSTIbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ArbustiPage));
        }

        private void RAMPICANTIbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RampicantiPage));
        }

        private void PIANTE_GRASSEbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PianteGrassePage));
        }

        private void ROSAIbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RosaiPage));
        }

        private void PIANTE_ACQUATICHEbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PianteAcquaticheeRivaPage));
        }

        private void PIANTE_ESOTICHEbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PianteEsotichePage));
        }

        private void PIANTE_ANNUALIbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PianteAnnualiPage));
        }

        private void PIANTE_PERENNIbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ErbaceePerenniPage));
        }

        private void PIANTE_BULBOSEbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BulbosePage));
        }

        private void PPIANTE_ORTObtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrtoPage));
        }

        private void PIANTE_FRUTTETObtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FruttetoPage));
        }

        private void PIANTE_AROMATICHEbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AromatichePage));
        }

        private void PIANTE_APPARTAMENTObtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PianteAppartamentoPage));
        }

        
    }
}
