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

using Windows.Storage;
using Windows.ApplicationModel.Email;


// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=234238

namespace Piante_e_Fiori.Views
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class SegnalazioneErrori : Page
    {
        public SegnalazioneErrori()
        {
            this.InitializeComponent();
        }

        private void errore_informazioni_schede_botaniche_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: NOME PIANTA (ES.: ABETE), PARAGRAFO (ES.: MALATTIE), TESTO ERRATO ED EVENTUALE CORREZZIONE ";

            sendmail1.Visibility = Visibility.Visible;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void errore_immagini_piante_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: NOME GALLERY FOTOGRAFICA PIANTA (ES.:  IMMAGINI ABETE) E L'IMMAGINE ERRATA IDENTIFICANDOLA CON LA DESCRIZIONE. SELEZIONARE QUESTA OPZIONE SE SI RILEVA FOTO DI BASSA QUALITA' O SE E' DISPONIBILE UN'IMMAGINE MIGLIORE.";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Visible;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void errore_testi_descrittivi_immagini_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: NOME PIANTA (ES.: ABETE), TESTO DESCRITTIVO ERRATO ED EVENTUALE CORREZZIONE ";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Visible;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void Errore_battitura_testo_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: NOME PIANTA (ES.: ABETE), PARAGRAFO DOVE E' PRESENTE L'ERRORE DI BATTITURA";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Visible;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void errore_riproduzione_sintetizzatore_vocale_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: NOME PIANTA (ES.: ABETE), INFORMAZIONI/DIFETTI DELLA RIPRODUZIONE VOCALE";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Visible;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void errore_audio_sottofondo_schede_botaniche_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: NOME PIANTA (ES.: ABETE) E  DESCRIZIONE DEL PROBLEMI RILEVATI";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Visible;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void errore_interfaccia_grafica_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "RIPORTARE LE SEGUENTI INFORMAZIONI: DISPOSITIVO UTILIZZATO, VERSIONE SISTEMA OPERATIVO, DESCRIZIONE DEL PROBLEMA ";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Visible;
            sendmail8.Visibility = Visibility.Collapsed;
        }

        private void errore_informazioni_altri_problemi_radiobutton_Checked(object sender, RoutedEventArgs e)
        {
            msg_box.Text = "SCEGLIERE QUESTA OPZIONE SE IL PROBLEMA/ERRORE RISCONTRATO NON RIENTRA NELLE CATEGORIE PRECEDENTI";

            sendmail1.Visibility = Visibility.Collapsed;
            sendmail2.Visibility = Visibility.Collapsed;
            sendmail3.Visibility = Visibility.Collapsed;
            sendmail4.Visibility = Visibility.Collapsed;
            sendmail5.Visibility = Visibility.Collapsed;
            sendmail6.Visibility = Visibility.Collapsed;
            sendmail7.Visibility = Visibility.Collapsed;
            sendmail8.Visibility = Visibility.Visible;
        }




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



        private async void sendmail1_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8001 [schede botaniche]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        private async void sendmail2_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8002 [immagini piante]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        private async void sendmail3_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8003 [testi descrittivi immagini]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        private async void sendmail4_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8004 [errore di battitura]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        private async void sendmail5_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8005 [riproduzione sintetizzatore vocale]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);

        }

        private async void sendmail6_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8006 [audio di sottofondo]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);


        }

        private async void sendmail7_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8007 [interfaccia grafica]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);


        }

        private async void sendmail8_Click(object sender, RoutedEventArgs e)
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient("dev.studio@outlook.it"));
            string messageBody = "Inserisci qui sotto il tuo feedback. Più informazioni ci fornirai e più facilmente saremo in grado di risolvere bug e accogliere suggerimenti.";
            emailMessage.Subject = "Piante e Fiori: Errore 0X8008 [altri problemi]";
            emailMessage.Body = messageBody;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);


        }
    }
}

