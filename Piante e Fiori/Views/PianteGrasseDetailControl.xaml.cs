using System;

using Piante_e_Fiori.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Microsoft.Toolkit.Uwp;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Windows.System;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Microsoft.Toolkit.Uwp.UI.Extensions;
using Windows.UI.ViewManagement;
using Windows.ApplicationModel.DataTransfer;
using Microsoft.Toolkit.Uwp.Helpers;

using Windows.Graphics.Printing;
using Windows.UI.Xaml.Printing;

namespace Piante_e_Fiori.Views
{
    public sealed partial class PianteGrasseDetailControl : UserControl
    {
        public PianteGrasse MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as PianteGrasse; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(PianteGrasse), typeof(PianteGrasseDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        // The object for controlling the speech synthesis engine (voice).
        SpeechSynthesizer speech;
        // The media object for controlling and playing audio.
        //MediaElement mediaplayer;
        MediaElement fx1player;
        public PrintHelper _printHelper;

        public PianteGrasseDetailControl()
        {
            InitializeComponent();

            //OTTENERE VOCE DEL SINTETIZZATORE VOCALE
            speech = new SpeechSynthesizer();
            //mediaplayer = new MediaElement(); lasciare nascosto

            //mediaplayer.AudioCategory = AudioCategory.BackgroundCapableMedia; lasciare nascosto

            lstVoices.ItemsSource = SpeechSynthesizer.AllVoices;
            lstVoices.SelectedValuePath = "DisplayName";
            lstVoices.SelectedValue = SpeechSynthesizer.DefaultVoice.DisplayName;

            lstPitch.ItemsSource = new string[] { "default", "x-low", "low", "medium", "high", "x-high" };
            lstPitch.SelectedValue = "default";
            //Audio in background
            fx1player = new MediaElement();
            fx1player.Source = new Uri("ms-appx:///Assets/background_audio.wav");

            //mediaplayer.MediaEnded += Mediaplayer_MediaEnded; lasciare nascosto


        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as PianteGrasseDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }




        //INGRANDISCI IL LOGO DELLA PIANTA
        private void ingrandisci_logo_pianta_Click(object sender, RoutedEventArgs e)
        {
            LogoPiantaGrande.Visibility = Visibility.Visible;
            Principale.Opacity = 0.3;
        }
        // RIDUCI IL LOGO DELLA PIANTA
        private void riduci_logo_Click(object sender, RoutedEventArgs e)
        {
            LogoPiantaGrande.Visibility = Visibility.Collapsed;
            Principale.Opacity = 100;
        }





        //SINTETIZATORE VOCALE

        private void mostra_nascondi_opzioni_sintetizzatore_vocale_Checked(object sender, RoutedEventArgs e)
        {
            opzioni_sintetizzatore_vocale.Visibility = Visibility.Visible;

        }

        private void mostra_nascondi_opzioni_sintetizzatore_vocale_Unchecked(object sender, RoutedEventArgs e)
        {
            opzioni_sintetizzatore_vocale.Visibility = Visibility.Collapsed;

        }

        //PANNELLO PULSANTI PLAY-PAUSA-STOP-BACKGROUND AUDIO
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            mediaplayer.Play();
            sintetizzatore_statustxt.Text = "Sto riproducendo...";
            pr1.Visibility = Visibility.Visible;
            cortana_fiore.Visibility = Visibility.Collapsed;

        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaplayer.Pause();
            sintetizzatore_statustxt.Text = "Hai sospeso la riproduzione";
            pr1.Visibility = Visibility.Collapsed;
            cortana_fiore.Visibility = Visibility.Visible;

        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaplayer.Stop();
            sintetizzatore_statustxt.Text = "Hai interrotto la riproduzione";
            pr1.Visibility = Visibility.Collapsed;
            cortana_fiore.Visibility = Visibility.Visible;
        }

        //GRID SINTETIZZATORE VOCALE
        private void Mediaplayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }



        private async void ReadBoringText(string mytext)
        {
            //Retrieve the first female voice
            speech.Voice = SpeechSynthesizer.AllVoices
                .First(i => (i.Gender == VoiceGender.Female && i.Description.Contains("United States")));
            //VoiceInformation currentVoice = (VoiceInformation)lstVoices.SelectedItem;
            //speech.Voice = currentVoice;

            // Generate the audio stream from plain text.
            SpeechSynthesisStream stream = await speech.SynthesizeTextToStreamAsync(mytext);

            // Send the stream to the media object.
            mediaplayer.SetSource(stream, stream.ContentType);
            mediaplayer.Play();
        }

        private async void ReadSsmlText(string mytext)
        {
            VoiceInformation currentVoice = (VoiceInformation)lstVoices.SelectedItem;

            // The object for controlling the speech synthesis engine (voice).
            string Ssml =
                @"<speak version='1.0' " +
                "xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='" + currentVoice.Language + "'>" +
                //                "<voice name='" + currentVoice.DisplayName + "' gender='" + currentVoice.Gender.ToString() + "' xml:lang='" + currentVoice.Language + "'>" +
                "<voice name='" + currentVoice.DisplayName + "'>" +
                "<prosody pitch='" + lstPitch.SelectedItem.ToString() + "' rate='" + sldRate.Value.ToString() + "'>" + mytext + "</prosody>" +
                "</voice></speak>";

            // Generate the audio stream from plain text.
            SpeechSynthesisStream stream = await speech.SynthesizeSsmlToStreamAsync(Ssml);

            // Send the stream to the media object.
            mediaplayer.SetSource(stream, stream.ContentType);
            mediaplayer.Play();
        }

        private void Sintetizzatore_vocale_Checked(object sender, RoutedEventArgs e)
        {
            Sintetizzatore_vocale_grid.Visibility = Visibility.Visible;
            Container.Opacity = 0.3;
        }

        private void Sintetizzatore_vocale_UnChecked(object sender, RoutedEventArgs e)
        {
            Sintetizzatore_vocale_grid.Visibility = Visibility.Collapsed;
            Container.Opacity = 100;
        }

        private void informazioni_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            ReadSsmlText(Informazionitxt.Text);
            sintetizzatore_statustxt.Text = "Sto riproducendo le informazioni generali sulla pianta...";
            pr1.Visibility = Visibility.Visible;
            cortana_fiore.Visibility = Visibility.Collapsed;

            Play.IsEnabled = true;
            Pausa.IsEnabled = true;
            Stop.IsEnabled = true;
            BackgroundAudio.IsEnabled = true;

        }

        private void descrizione_botanica_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            ReadSsmlText(descrizione_botanicatxt.Text);
            sintetizzatore_statustxt.Text = "Sto riproducendo la descrizione botanica...";
            pr1.Visibility = Visibility.Visible;
            cortana_fiore.Visibility = Visibility.Collapsed;

            Play.IsEnabled = true;
            Pausa.IsEnabled = true;
            Stop.IsEnabled = true;
            BackgroundAudio.IsEnabled = true;
        }

        private void coltivazione_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            ReadSsmlText(coltivazionetxt.Text);
            sintetizzatore_statustxt.Text = "Sto riproducendo i metodi di coltivazione...";
            pr1.Visibility = Visibility.Visible;
            cortana_fiore.Visibility = Visibility.Collapsed;

            Play.IsEnabled = true;
            Pausa.IsEnabled = true;
            Stop.IsEnabled = true;
            BackgroundAudio.IsEnabled = true;
        }


        private void malattie_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            ReadSsmlText(malattietxt.Text);
            sintetizzatore_statustxt.Text = "Sto riproducendo le principali malattie...";
            pr1.Visibility = Visibility.Visible;
            cortana_fiore.Visibility = Visibility.Collapsed;

            Play.IsEnabled = true;
            Pausa.IsEnabled = true;
            Stop.IsEnabled = true;
            BackgroundAudio.IsEnabled = true;
        }



        private async void BackAudio_Cecked(object sender, RoutedEventArgs e)
        {
            var var_assets = await Package.Current.InstalledLocation.GetFolderAsync("Assets");
            // Audio file courtesy of Sclolex and freesound.org
            // http://www.freesound.org/people/Sclolex/sounds/177958/
            // Crative Commons 0 License - CC0 1.0 Universal (CC0 1.0) Public Domain Dedication
            var var_file = await var_assets.GetFileAsync("background_audio.wav");
            var var_stream = await var_file.OpenAsync(FileAccessMode.Read);

            fx1player.SetSource(var_stream, var_file.ContentType);
            fx1player.IsLooping = true;
            fx1player.Play();
        }

        private void BackAudio_UnCecked(object sender, RoutedEventArgs e)
        {
            fx1player.Stop();
        }

        private void sintetizzatore_vocale_btn_Checked(object sender, RoutedEventArgs e)
        {
            Sintetizzatore_vocale_grid.Visibility = Visibility.Visible;
        }

        private void sintetizzatore_vocale_btn_UnChecked(object sender, RoutedEventArgs e)
        {
            Sintetizzatore_vocale_grid.Visibility = Visibility.Collapsed;
        }

        //DUPLICA FINESTRA
        private async void duplica_finestra_btn_Click(object sender, RoutedEventArgs e)
        {
            CoreApplicationView newView = CoreApplication.CreateNewView();
            int newViewId = 0;
            await newView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Frame frame = new Frame();
                frame.Navigate(typeof(PianteGrassePage), null);
                Window.Current.Content = frame;
                // You have to activate the window in order to show it later.
                Window.Current.Activate();

                newViewId = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().Id;
            });
            bool viewShown = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(newViewId);
        }




        //CERCA SU INTERNET ALTRE INFORMAZIONI
        private async void cerca_informazioni_pianta_btn_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("{x:Bind LinkNomeComunePianta}"));
            //await Launcher.LaunchUriAsync(new Uri("https://www.bing.com/search?q= + {x:Bind NomeComunePianta}"));

        }


        //STAMPA PAGINA [NON FUNZIONANTE]







    }

}
