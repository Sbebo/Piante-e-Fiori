using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Piante_e_Fiori.Helpers;
using Piante_e_Fiori.Services;

using Windows.ApplicationModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;




using Windows.ApplicationModel.Email;
using Windows.Storage;
using System.Linq;
using Windows.System;

using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;

using Windows.ApplicationModel.Background;
using System.Threading.Tasks;

using Piante_e_Fiori;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Devices.WiFi;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

using Windows.UI.Xaml.Shapes;
using Windows.UI.Notifications;
using Windows.UI.StartScreen;
using Windows.Data.Xml.Dom;
using Windows.UI.Popups;



using Windows.ApplicationModel.Store;
using PianteEFiori.Views;
using System.Diagnostics;

namespace Piante_e_Fiori.Views
{
    // TODO WTS: Add other settings as necessary. For help see https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/pages/settings-codebehind.md
    // TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere
    public sealed partial class SettingsPage : Page, INotifyPropertyChanged
    {
        int appRunCount = 0;
        private DataTransferManager dataTransferManager;
        private ElementTheme _elementTheme = ThemeSelectorService.Theme;
        Library1 library2 = new Library1();
        Library1 library1 = new Library1();

        public ElementTheme ElementTheme
        {
            get { return _elementTheme; }

            set { Set(ref _elementTheme, value); }
        }

        private string _versionDescription;

        public string VersionDescription
        {
            get { return _versionDescription; }

            set { Set(ref _versionDescription, value); }
        }

        public SettingsPage()
        {
            InitializeComponent();

            //dimensione riquadri home
            normali.IsChecked = library1.LoadSettingBool("Normali");
            medi.IsChecked = library1.LoadSettingBool("Medi");
            grandi.IsChecked = library1.LoadSettingBool("Grandi");
            salva_dimensioni_riquadri_home_ok.Visibility = Visibility.Collapsed;

           
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Initialize();
            // register this page as share source
            this.dataTransferManager = DataTransferManager.GetForCurrentView();
            this.dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);

            //AVVIO APP CON WINDOWS
            string payload = e.Parameter as string;

            if (!string.IsNullOrEmpty(payload))
            {
                activationText.Text = payload;


                if (payload == "StartupTask")
                {
                    requestButton.IsEnabled = false;
                    requestResult.Text = "Enabled";
                    SolidColorBrush brush = new SolidColorBrush(Colors.Gray);
                    requestResult.Foreground = brush;
                    requestPrompt.Foreground = brush;
                }
                            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e) //inserito io sempre per condivisione app
        {
            // unregister as share source
            this.dataTransferManager.DataRequested -= new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
        }

        private void Initialize()
        {
            VersionDescription = GetVersionDescription();
        }

        private string GetVersionDescription()
        {
            var appName = "AppDisplayName".GetLocalized();
            var package = Package.Current;
            var packageId = package.Id;
            var version = packageId.Version;

            return $"{appName} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }

        private async void ThemeChanged_CheckedAsync(object sender, RoutedEventArgs e)
        {
            var param = (sender as RadioButton)?.CommandParameter;

            if (param != null)
            {
                await ThemeSelectorService.SetThemeAsync((ElementTheme)param);
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


        //DA QUI IL MIO CODICE PERSONALIZZATO

        //GENERALI

        //Codice per permettere l'avvio dell'app Posta e inviare mail
        private async void ComposeEmail(Windows.ApplicationModel.Contacts.Contact recipient,
        string messageBody,
        StorageFile attachmentFile)
        {
            var emailMessage = new Windows.ApplicationModel.Email.EmailMessage();
            emailMessage.Body = messageBody;

            if (attachmentFile != null)
            {
                var stream = Windows.Storage.Streams.RandomAccessStreamReference.CreateFromFile(attachmentFile);

                var attachment = new Windows.ApplicationModel.Email.EmailAttachment(
                    attachmentFile.Name,
                    stream);

                emailMessage.Attachments.Add(attachment);
            }

            var email = recipient.Emails.FirstOrDefault<Windows.ApplicationModel.Contacts.ContactEmail>();
            if (email != null)
            {
                var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient(email.Address);
                emailMessage.To.Add(emailRecipient);
            }

            await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        // Mail per il feedback sull'app
        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti. Inserisci il numero della versione che stai usando.";
            emailMessage.Subject = "Piante e Fiori App: Feedback";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }
        // Mail per segnalazione problemi nell'app
        private void sendmail_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SegnalazioneErrori));
        }
       
        //Apertura di Feedback Hub
        private void Hubfeedback_Click(object sender, RoutedEventArgs e)
        {
            //var launcher = Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.GetDefault();
            //await launcher.LaunchAsync();
        }

        //Dopo 5 aperture vota l'app
        private async void Page_Loaded(object sender, RoutedEventArgs e)

        {
            {
                //ShowToast("Welcome to Wifi Vision");
            }

            if (appRunCount == 5)

            {
                var messageDialog = new Windows.UI.Popups.MessageDialog("Per favore vota questa app", "Scrivin una recensione!");

                messageDialog.Commands.Add(new Windows.UI.Popups.UICommand("Vota l'app", new Windows.UI.Popups.UICommandInvokedHandler(CommandHandler)));
                messageDialog.Commands.Add(new Windows.UI.Popups.UICommand("Ho già votato", new Windows.UI.Popups.UICommandInvokedHandler(CommandHandler)));
                messageDialog.Commands.Add(new Windows.UI.Popups.UICommand("La prossima volta", new Windows.UI.Popups.UICommandInvokedHandler(CommandHandler)));

                messageDialog.DefaultCommandIndex = 0;
                messageDialog.CancelCommandIndex = 2;
                await messageDialog.ShowAsync();

            }
        }

        private async void CommandHandler(IUICommand command)

        {

            if (command.Label == "Vota l'app")

            {
                var uri = new Uri("ms-windows-store://review/?ProductId=9nblggh4s1n3");
                await Windows.System.Launcher.LaunchUriAsync(uri);
            }

        }

        

        


        private void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            Uri dataPackageUri = new Uri("https://www.microsoft.com/store/apps/9nblggh4s1n3"); //cntrollare
            DataPackage requestData = e.Request.Data;
            requestData.Properties.Title = "Piante e Fiori";
            requestData.SetWebLink(dataPackageUri);
            requestData.Properties.Description = "Condividi l'app con amici e colleghi!";
        }

        private void share_appbtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI();
        }


        //Aggiungi/Rimuovi tile app dal menù start
        public void ToggleButton(bool showPinButton)
        {
            if (showPinButton)
            {
                btnSecTile.Content = "Aggiungi Tile";
                //btnSecTile.Icon = new SymbolIcon(Symbol.Pin);
                ShowToast("Tile rimossa");
            }
            else
            {
                btnSecTile.Content = "Rimuovi Tile";
                //btnSecTile.Icon = new SymbolIcon(Symbol.UnPin);
                ShowToast("Tile aggiunta");
            }
            this.btnSecTile.UpdateLayout();
        }



        //private void btnSecTile_Checked(object sender, RoutedEventArgs e)
        //{
        //   ShowToast("Tile is pinned");
        //  this.btnSecTile.UpdateLayout();
        //}
        // private void btnSecTile_OnUnchecked(object sender, RoutedEventArgs e)
        //{
        //    ShowToast("Tile is unpinned");
        //    this.btnSecTile.UpdateLayout();
        // }

        private async void btnSecTile_Click(object sender, RoutedEventArgs e)
        {
            Windows.Foundation.Rect rect = GetElementRect((FrameworkElement)sender);

            if (SecondaryTile.Exists("MyUnicTileID"))
            {
                SecondaryTile secondaryTile = new SecondaryTile("MyUnicTileID");

                bool isUnpinned = await secondaryTile.RequestDeleteForSelectionAsync(rect, Windows.UI.Popups.Placement.Above);
                ToggleButton(isUnpinned);
            }
            else
            {
                // Pin
                Uri square150x150Logo = new Uri("ms-appx:///Assets/Square150x150Logo.png");
                string tileActivationArguments = "Secondary tile was pinned at = " + DateTime.Now.ToLocalTime().ToString();
                string displayName = "Piante e Fiori";

                TileSize newTileDesiredSize = TileSize.Square150x150;
                SecondaryTile secondaryTile = new SecondaryTile("MyUnicTileID",
                                                                displayName,
                                                                tileActivationArguments,
                                                                square150x150Logo,
                                                                newTileDesiredSize);

                secondaryTile.VisualElements.Square44x44Logo = new Uri("ms-appx:///Assets/Square44x44Logo.png");
                secondaryTile.VisualElements.ShowNameOnSquare150x150Logo = true;
                secondaryTile.VisualElements.ForegroundText = ForegroundText.Light;

                bool isPinned = await secondaryTile.RequestCreateForSelectionAsync(rect, Windows.UI.Popups.Placement.Above);
                ToggleButton(!isPinned);

            }
        }

        public static Rect GetElementRect(FrameworkElement element)
        {
            GeneralTransform buttonTransform = element.TransformToVisual(null);
            Point point = buttonTransform.TransformPoint(new Point());
            return new Rect(point, new Size(element.ActualWidth, element.ActualHeight));
        }



        void ShowToast(string whattext)
        {
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);
            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            stringElements[0].AppendChild(toastXml.CreateTextNode(whattext));
            ToastNotification toast = new ToastNotification(toastXml);

            toast.Activated += ToastActivated;
            toast.Dismissed += ToastDismissed;
            toast.Failed += ToastFailed;

            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        private void ToastFailed(ToastNotification sender, ToastFailedEventArgs args) { }
        private void ToastDismissed(ToastNotification sender, ToastDismissedEventArgs args) { }
        private void ToastActivated(ToastNotification sender, object args) { }

        private void ShareButton_Click(object sender, RoutedEventArgs e)
        {
            DataTransferManager.ShowShareUI();
        }

        //Cancellare dati app
        private async void clear_databtn_Click(object sender, RoutedEventArgs e)
        {
            // Delete settings
            var files = await ApplicationData.Current.LocalFolder.GetFilesAsync();
            foreach (var file in files) await file.DeleteAsync(StorageDeleteOption.Default);
            appRunCount = 0;

            // Exit.
            Application.Current.Exit();

        }

        





        //INFO APP

        //Visualizza il changelog
        private void changelog_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Changelog));
        }

        // Vota e commenta l'app sullo store
        private async void votaecommentabtn_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?ProductId=9nblggh4s1n3"));
        }
        //Le altre mie app
        private async void le_nostre_app_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("ms-windows-store://publisher/?name=Simone Raspagni"));
        }


        //BETA TEST

        private async void start_BETA_TESTbtn_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "///Accetto di partecipare al programma Piante e Fiori Insider per ricevere build con nuove funzionalità in anteprima///Sono consapevole di poter ricevere una versione dell'applicazione con bug o altri problemi che pregiudicano il normale uso dell'app stessa///Posso uscire dal programma Insider e ricevere solo gli aggiornamenti pubblici contattando lo sviluppatore/// Benvenuto! Per iniziare fornisci di seguito l'indirizzo mail associato al tuo Account Microsoft ";
            emailMessage.Subject = "Piante e Fiori App: INIZIO PROGRAMMA INSIDER";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        private async void end_BETA_TESTbtn_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Desidero uscire dal programma Piante e Fiori Insider e ricevere quindi solo gli aggiornamenti pubblici";
            emailMessage.Subject = "Piante e Fiori App: FINE PROGRAMMA INSIDER";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        //AVVIO APP CON WINDOWS

        async private void requestButton_Click(object sender, RoutedEventArgs e)

        {

            StartupTask startupTask = await StartupTask.GetAsync("MyStartupId");        
            requestResult.Text = startupTask.State.ToString();
            switch (startupTask.State)

            {

                case StartupTaskState.Disabled:

                    // Task is disabled but can be enabled.
                    StartupTaskState newState = await startupTask.RequestEnableAsync();
                    requestResult.Text = newState.ToString();
                    Debug.WriteLine("Request to enable startup, result = {0}", newState);
                    break;

                case StartupTaskState.DisabledByUser:
                    // Task is disabled and user must enable it manually.
                    MessageDialog dialog = new MessageDialog(
                        "I know you don't want this app to run " +
                        "as soon as you sign in, but if you change your mind, " +
                        "you can enable this in the Startup tab in Task Manager.",
                        "TestStartup");

                    await dialog.ShowAsync();
                    requestResult.Text = "Disabilitato";
                    break;

                case StartupTaskState.DisabledByPolicy:
                    Debug.WriteLine("Startup disabled by group policy, or not supported on this device");
                    requestResult.Text = "Disabilitato";
                    break;

                case StartupTaskState.Enabled:
                    Debug.WriteLine("Startup is enabled.");
                    requestResult.Text = "Automatico";
                    break;

            }

        }

        //DONAZIONE SU PAYPAL
        private async void supportaci1_btn_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.paypal.me/devstudio649/1eur"));
        }

        private async void supportaci2_btn_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.paypal.me/devstudio649/2,50eur"));
        }

        private async void supportaci3_btn_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://www.paypal.me/devstudio649/5eur"));
        }


        //PERSONALIZZAZIONE GRANDEZZA RIQUADRI SCHEDE BOTANICHE
        private void Riquadri_Normali_Checked(object sender, RoutedEventArgs e)
        {
            //Anteprima_normali.Visibility = Visibility.Visible;
            //Anteprima_medi.Visibility = Visibility.Collapsed;
            //Anteprima_grandi.Visibility = Visibility.Collapsed;
            library1.SaveSettingsBool("Normali", normali.IsChecked.Value);
            //normali.IsChecked = library1.LoadSettingBool("Normali");
        }

        private void Riquadri_Medi_Checked(object sender, RoutedEventArgs e)
        {
            //Anteprima_normali.Visibility = Visibility.Collapsed;
            //Anteprima_medi.Visibility = Visibility.Visible;
            //Anteprima_grandi.Visibility = Visibility.Collapsed;
            library1.SaveSettingsBool("Medi", medi.IsChecked.Value);
            //medi.IsChecked = library1.LoadSettingBool("Medi");
        }

        private void Riquadri_Grandi_Checked(object sender, RoutedEventArgs e)
        {
            //Anteprima_normali.Visibility = Visibility.Collapsed;
            //Anteprima_medi.Visibility = Visibility.Collapsed;
            //Anteprima_grandi.Visibility = Visibility.Visible;

            library1.SaveSettingsBool("Grandi", grandi.IsChecked.Value);
            //grandi.IsChecked = library1.LoadSettingBool("Grandi");
        }

        private void Salvabtn_Click(object sender, RoutedEventArgs e)
        {
            library1.SaveSettingsBool("Grandi", grandi.IsChecked.Value);
            library1.SaveSettingsBool("Medi", medi.IsChecked.Value);
            library1.SaveSettingsBool("Normali", normali.IsChecked.Value);
            salva_dimensioni_riquadri_home_ok.Visibility = Visibility.Visible;
        }

        
    }
}

