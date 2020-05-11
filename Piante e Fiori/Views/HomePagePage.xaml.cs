using Piante_e_Fiori.Services;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.System;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Appointments;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Graphics.Imaging;
using Windows.Storage.Pickers;
using Windows.UI;
using Piante_e_Fiori.Models;
using System.Collections.ObjectModel;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.ViewManagement;

namespace Piante_e_Fiori.Views
{
    public sealed partial class HomePagePage : Page, INotifyPropertyChanged
    {
        
        Library1 library1 = new Library1();

        public ObservableCollection<Alberi> SampleItems { get; private set; } = new ObservableCollection<Alberi>();
        public HomePagePage()
        {
            InitializeComponent();

            //Visualizzazione con e senza immissione dei dati
            nome_socio_txthome.Text = library1.LoadSetting("Nome e Cognome Socio"); //pannello utente
            tipo_socio_txthome.Text = library1.LoadSetting("Tipologia di Socio");   // pannello utente
            nome_pianta_preferita.Text = library1.LoadSetting("Pianta Preferita");

            sesso_maschile.IsChecked = library1.LoadSettingBool("Sesso Maschile");
            sesso_femminile.IsChecked = library1.LoadSettingBool("Sesso Femminile");
            sesso_indefinito.IsChecked = library1.LoadSettingBool("Sesso Indefinito");

            pollice_biancobtn.IsChecked = library1.LoadSettingBool("Pollice Bianco");
            pollice_verde_basebtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Base");
            pollice_verde_mediobtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Medio");
            pollice_verde_avanzatobtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Avanzato");
            pollice_verde_espertobtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Esperto");

            normali.IsChecked = library1.LoadSettingBool("Normali");
            medi.IsChecked = library1.LoadSettingBool("Medi");
            grandi.IsChecked = library1.LoadSettingBool("Grandi");


            

           

        }
        /// <summary>
        /// Used to display messages to the user
        /// </summary>
        /// <param name="strMessage"></param>
        /// <param name="type"></param>


        //Fa parte di Windows Template Studio
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

        // Fine parte Windows Template Studio


        private void modifica_dati_Checked(object sender, RoutedEventArgs e)
        {
            ContentDialog_ModificaDati.Visibility = Visibility.Visible;
            //ContentArea.Opacity = 0.2;

        }



        public enum NotifyType
        {
            StatusMessage,
            ErrorMessage
        };




        //MENU UTENTE
        private void botanica_agraria_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BotanicaAgrariaPage));
        }

        //private void schede_botaniche_btn_Click(object sender, RoutedEventArgs e)
        //{
        //   this.Frame.Navigate(typeof(Categorie_Piante));
        //}

        // private void controllo_sanitario_btn_Click(object sender, RoutedEventArgs e)
        // {
        //      this.Frame.Navigate(typeof(ControlloSanitarioPage));
        // }
        private void progettazione_giardino_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InkDrawPage));
        }

        private void riconoscimento_pianta_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IdentificazionePiantaPage));
        }

        private void glossario_termini_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GlossarioPage));
        }

        private void guida_area_utente_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GuidaPage));
        }

        //  private void gestione_preferiti_btn_Click(object sender, RoutedEventArgs e)
        //  {
        //      this.Frame.Navigate(typeof(Preferiti));
        //  }

        private void gestione_trattamenti_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Trattamenti_Piante));//TrattamentiPianteHomepage
        }

        private void calendario_lunare_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.CalendarioLunarePage));
        }

        //Pulsanti per la sezione "i miei dati"

        private void modifica_dati_Click(object sender, RoutedEventArgs e)
        {
            //Dati_grid.Visibility = Visibility.Visible;

            menu_utente.Visibility = Visibility.Collapsed;

            this.New.Visibility = Visibility.Visible;


        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            nome.Text = string.Empty;
            nome_socio_txthome.Text = string.Empty;
            tipo_socio_txthome.Text = string.Empty;

            StatusText.Text = "Dati inseriti rimossi";

        }




        //load setting=sincronizza




        private void Menubtn_Checked(object sender, RoutedEventArgs e)
        {
            //if (this.menu_utente.Visibility == Visibility.Visible)
            // this.menu_utente.Visibility = Visibility.Collapsed;

            // else
            //this.menu_utente.Visibility = Visibility.Visible;

            //Dati_grid.Visibility = Visibility.Collapsed;

            menu_utente.Visibility = Visibility.Visible;

            New.Visibility = Visibility.Collapsed;


        }






        //IMMAGINE UTENTE
        private void sesso_maschile_Checked(object sender, RoutedEventArgs e)
        {
            immagine_utente_standard.Visibility = Visibility.Collapsed;
            immagine_utente_femminile.Visibility = Visibility.Collapsed;
            immagine_utente_maschile.Visibility = Visibility.Visible;
            bentornato_socio_txthome.Text = "BENTORNATO";
            background_immagine_utente.Background = new SolidColorBrush(Colors.LightBlue);

        }

        private void sesso_femminile_Checked(object sender, RoutedEventArgs e)
        {
            immagine_utente_standard.Visibility = Visibility.Collapsed;
            immagine_utente_maschile.Visibility = Visibility.Collapsed;
            immagine_utente_femminile.Visibility = Visibility.Visible;
            bentornato_socio_txthome.Text = "BENTORNATA";
            background_immagine_utente.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void sesso_indefinito_Checked(object sender, RoutedEventArgs e)
        {
            immagine_utente_standard.Visibility = Visibility.Visible;
            immagine_utente_maschile.Visibility = Visibility.Collapsed;
            immagine_utente_femminile.Visibility = Visibility.Collapsed;
            bentornato_socio_txthome.Text = "CIAO";
            background_immagine_utente.Background = new SolidColorBrush(Colors.LightGray);
        }

        //LIVELLO UTENTE
        private void pollice_biancobtn_Checked(object sender, RoutedEventArgs e)
        {
            tipo_socio_txthome.Text = "Pollice Bianco";
        }

        private void pollice_verde_basebtn_Checked(object sender, RoutedEventArgs e)
        {
            tipo_socio_txthome.Text = "Pollice Verde - Base";
        }

        private void pollice_verde_mediobtn_Checked(object sender, RoutedEventArgs e)
        {
            tipo_socio_txthome.Text = "Pollice Verde - Medio";
        }

        private void pollice_verde_espertobtn_Checked(object sender, RoutedEventArgs e)
        {
            tipo_socio_txthome.Text = "Pollice Verde - Esperto";
        }

        private void pollice_verde_avanzatobtn_Checked(object sender, RoutedEventArgs e)
        {
            tipo_socio_txthome.Text = "Pollice Verde - Avanzato";
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

        private void FRUTTI_BOSCObtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AltriFruttiPage));
        }

        private void PIANTE_AROMATICHEbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AromatichePage));
        }

        private void PIANTE_APPARTAMENTObtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PianteAppartamentoPage));
        }

        private async void duplica_finestra_btn_Click(object sender, RoutedEventArgs e)
        {
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(HomePagePage), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }

        private void Chiudi_ContentDialogModificaDati_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog_ModificaDati.Visibility = Visibility.Collapsed;
            //ContentArea.Opacity = 1;
            //nome.Text = library1.LoadSetting("Nome e Cognome Socio");
            StatusText.Text = "";
            nome_socio_txthome.Text = library1.LoadSetting("Nome e Cognome Socio"); //pannello utente
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {


            library1.SaveSettings("Nome e Cognome Socio", nome.Text);

            //library1.SaveSettings("Tipologia di Socio", tipo_socio.Text);


            library1.SaveSettingsBool("Sesso Maschile", sesso_maschile.IsChecked.Value);
            library1.SaveSettingsBool("Socio Femminile", sesso_femminile.IsChecked.Value);
            library1.SaveSettingsBool("Socio Indefinito", sesso_indefinito.IsChecked.Value);

            library1.SaveSettingsBool("Pollice Bianco", pollice_biancobtn.IsChecked.Value);
            library1.SaveSettingsBool("Pollice Verde - Base", pollice_verde_basebtn.IsChecked.Value);
            library1.SaveSettingsBool("Pollice Verde - Medio", pollice_verde_mediobtn.IsChecked.Value);
            library1.SaveSettingsBool("Pollice Verde - Avanzato", pollice_verde_espertobtn.IsChecked.Value);
            library1.SaveSettingsBool("Pollice Verde - Esperto", pollice_verde_avanzatobtn.IsChecked.Value);

            StatusText.Text = "Ok. Chiudere per aggiornare.";

        }

        //PERSONALIZZAZIONE GRANDEZZA RIQUADRI SCHEDE BOTANICHE
        private void Riquadri_Normali_Checked(object sender, RoutedEventArgs e)
        {
            ALBERIbtn.Width = 116;
            ALBERIbtn.Height = 116;
            ARBUSTIbtn.Width = 116;
            ARBUSTIbtn.Height = 116;
            PIANTE_ACQUATICHEbtn.Width = 116;
            PIANTE_ACQUATICHEbtn.Height = 116;
            PIANTE_ANNUALIIbtn.Width = 116;
            PIANTE_ANNUALIIbtn.Height = 116;
            PIANTE_APPARTAMENTObtn.Width = 116;
            PIANTE_APPARTAMENTObtn.Height = 116;
            PIANTE_AROMATICHEbtn.Width = 116;
            PIANTE_AROMATICHEbtn.Height = 116;
            PIANTE_BULBOSEbtn.Width = 116;
            PIANTE_BULBOSEbtn.Height = 116;
            PIANTE_ESOTICHEbtn.Width = 116;
            PIANTE_ESOTICHEbtn.Height = 116;
            PIANTE_FRUTTETObtn.Width = 116;
            PIANTE_FRUTTETObtn.Height = 116;
            PIANTE_GRASSEbtn.Width = 116;
            PIANTE_GRASSEbtn.Height = 116;
            PIANTE_ORTObtn.Width = 116;
            PIANTE_ORTObtn.Height = 116;
            PIANTE_PERENNIbtn.Width = 116;
            PIANTE_PERENNIbtn.Height = 116;
            RAMPICANTIbtn.Width = 116;
            RAMPICANTIbtn.Height = 116;
            ROSAIbtn.Width = 116;
            ROSAIbtn.Height = 116;
            ALTRI_FRUTTIbtn.Width = 116;
            ALTRI_FRUTTIbtn.Height = 116;

            library1.SaveSettingsBool("Normali", normali.IsChecked.Value);
        }

        private void Riquadri_Medi_Checked(object sender, RoutedEventArgs e)
        {
            ALBERIbtn.Width = 232;
            ALBERIbtn.Height = 232;
            ARBUSTIbtn.Width = 232;
            ARBUSTIbtn.Height = 232;
            PIANTE_ACQUATICHEbtn.Width = 232;
            PIANTE_ACQUATICHEbtn.Height = 232;
            PIANTE_ANNUALIIbtn.Width = 232;
            PIANTE_ANNUALIIbtn.Height = 232;
            PIANTE_APPARTAMENTObtn.Width = 232;
            PIANTE_APPARTAMENTObtn.Height = 232;
            PIANTE_AROMATICHEbtn.Width = 232;
            PIANTE_AROMATICHEbtn.Height = 232;
            PIANTE_BULBOSEbtn.Width = 232;
            PIANTE_BULBOSEbtn.Height = 232;
            PIANTE_ESOTICHEbtn.Width = 232;
            PIANTE_ESOTICHEbtn.Height = 232;
            PIANTE_FRUTTETObtn.Width = 232;
            PIANTE_FRUTTETObtn.Height = 232;
            PIANTE_GRASSEbtn.Width = 232;
            PIANTE_GRASSEbtn.Height = 232;
            PIANTE_ORTObtn.Width = 232;
            PIANTE_ORTObtn.Height = 232;
            PIANTE_PERENNIbtn.Width = 232;
            PIANTE_PERENNIbtn.Height = 232;
            RAMPICANTIbtn.Width = 232;
            RAMPICANTIbtn.Height = 232;
            ROSAIbtn.Width = 232;
            ROSAIbtn.Height = 232;
            ALTRI_FRUTTIbtn.Width = 232;
            ALTRI_FRUTTIbtn.Height = 232;

            library1.SaveSettingsBool("Medi", medi.IsChecked.Value);
        }

        private void Riquadri_Grandi_Checked(object sender, RoutedEventArgs e)
        {
            ALBERIbtn.Width = 350;
            ALBERIbtn.Height = 350;
            ARBUSTIbtn.Width = 350;
            ARBUSTIbtn.Height = 350;
            PIANTE_ACQUATICHEbtn.Width = 350;
            PIANTE_ACQUATICHEbtn.Height = 350;
            PIANTE_ANNUALIIbtn.Width = 350;
            PIANTE_ANNUALIIbtn.Height = 350;
            PIANTE_APPARTAMENTObtn.Width = 350;
            PIANTE_APPARTAMENTObtn.Height = 350;
            PIANTE_AROMATICHEbtn.Width = 350;
            PIANTE_AROMATICHEbtn.Height = 350;
            PIANTE_BULBOSEbtn.Width = 350;
            PIANTE_BULBOSEbtn.Height = 350;
            PIANTE_ESOTICHEbtn.Width = 350;
            PIANTE_ESOTICHEbtn.Height = 350;
            PIANTE_FRUTTETObtn.Width = 350;
            PIANTE_FRUTTETObtn.Height = 350;
            PIANTE_GRASSEbtn.Width = 350;
            PIANTE_GRASSEbtn.Height = 350;
            PIANTE_ORTObtn.Width = 350;
            PIANTE_ORTObtn.Height = 350;
            PIANTE_PERENNIbtn.Width = 350;
            PIANTE_PERENNIbtn.Height = 350;
            RAMPICANTIbtn.Width = 350;
            RAMPICANTIbtn.Height = 350;
            ROSAIbtn.Width = 350;
            ROSAIbtn.Height = 350;
            ALTRI_FRUTTIbtn.Width = 350;
            ALTRI_FRUTTIbtn.Height = 350;

            library1.SaveSettingsBool("Grandi", grandi.IsChecked.Value);
        }

        private void HomPage_Loaded(object sender, RoutedEventArgs e)
        {
            nome.Text = library1.LoadSetting("Nome e Cognome Socio");


            sesso_maschile.IsChecked = library1.LoadSettingBool("Sesso Maschile");
            sesso_femminile.IsChecked = library1.LoadSettingBool("Sesso Femminile");
            sesso_indefinito.IsChecked = library1.LoadSettingBool("Sesso Indefinito");


            pollice_biancobtn.IsChecked = library1.LoadSettingBool("Pollice Bianco");
            pollice_verde_basebtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Base");
            pollice_verde_mediobtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Medio");
            pollice_verde_espertobtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Avanzato");
            pollice_verde_avanzatobtn.IsChecked = library1.LoadSettingBool("Pollice Verde - Esperto");

            normali.IsChecked = library1.LoadSettingBool("Normali");
            medi.IsChecked = library1.LoadSettingBool("Medi");
            grandi.IsChecked = library1.LoadSettingBool("Grandi");
        }

        private void HomePage_Loading(FrameworkElement sender, object args)
        {
            //normali.IsChecked = library1.LoadSettingBool("Normali");
            //medi.IsChecked = library1.LoadSettingBool("Medi");
            //grandi.IsChecked = library1.LoadSettingBool("Grandi");
        }

        private async void invia_denaro_btn_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.paypal.me/devstudio649/5eur"));
        }
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AlberiGridPage));
        }

        
    }
}



//UTILE




//MODIFICA BAKGROUND PULSANTE
//button.Background = new SolidColorBrush(Colors.Red);

//MODIFICA TEXTBLOCK
//TextBlock textBlock = new TextBlock(new Run("A bit of text content..."));

//textBlock.Background = Brushes.AntiqueWhite;
//textBlock.Foreground = Brushes.Navy;

//textBlock.FontFamily = new FontFamily("Century Gothic");
//textBlock.FontSize = 12;
//textBlock.FontStretch = FontStretches.UltraExpanded;
//textBlock.FontStyle = FontStyles.Italic;
//textBlock.FontWeight = FontWeights.UltraBold;

//textBlock.LineHeight = Double.NaN;
//textBlock.Padding = new Thickness(5, 10, 5, 10);
//textBlock.TextAlignment = TextAlignment.Center;
//textBlock.TextWrapping  = TextWrapping.Wrap;

//textBlock.Typography.NumeralStyle = FontNumeralStyle.OldStyle;
//textBlock.Typography.SlashedZero  = true;
