using System;

using Piante_e_Fiori.Models;
using Windows.Networking.Connectivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Piante_e_Fiori.Views
{
    public sealed partial class CalendarioLunareDetailControl : UserControl
    {
        public CalendarioLunare MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as CalendarioLunare; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(CalendarioLunare), typeof(CalendarioLunareDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public CalendarioLunareDetailControl()
        {
            InitializeComponent();
            UltimeNewsWebView.Navigate(new Uri("http://osservareilcielo.altervista.org/fasiluna.html")); //m.facebook.com/circolovelabellano/?fref=ts

            if (IsInternet())
            {
                this.internet_status.Visibility = Visibility.Collapsed; //internet
            }
            else
            {
                this.internet_status.Visibility = Visibility.Visible; //no internet

            }
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as CalendarioLunareDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }



        //MIO CODICE

        private void posizione_luna_btn_Checked(object sender, RoutedEventArgs e)
        {
            this.posizione_luna_grid.Visibility = Visibility.Visible;
        }

        private void posizione_luna_btn_UnChecked(object sender, RoutedEventArgs e)
        {
            this.posizione_luna_grid.Visibility = Visibility.Collapsed;
        }

        //WEBVIEW
        //STATO CONNESSIONE
        public static bool IsInternet()
        {

            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
            return internet;

        }

        private void close_internet_statusbtn_Click(object sender, RoutedEventArgs e)
        {
            internet_status.Visibility = Visibility.Collapsed;
        }

        private void Navigation_Starting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            pr1.Visibility = Visibility.Visible;
            pr1_text.Text = "Caricamento in corso...";

            UltimeNewsWebView.Visibility = Visibility.Collapsed;
        }

        private void Navigation_Completed(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            //pr1.Visibility = Visibility.Collapsed;
            pr1_text.Text = "Fatto!";

            string myUrl = sender.Source.ToString();
        }

        // Navigation failed
        private void Navigation_Failed(object sender, WebViewNavigationFailedEventArgs e)
        {
            internet_status.Visibility = Visibility.Visible;
            pr1.Visibility = Visibility.Collapsed;
        }
        private void close_navigation_failed_popup_Click(object sender, RoutedEventArgs e)
        {
            internet_status.Visibility = Visibility.Collapsed;
        }

        //GESTIRE LINK CHE APRIREBBERO UN NUOVO WEBVIEW E CHE FACCIO APRIRE DIRETTAMENTE QUI
        //private void New_Windows_Requested(WebView sender, WebViewNewWindowRequestedEventArgs args)
        //{
        //UltimeNewsWebView.Navigate(args.Uri);
        // args.Handled = true;
        //}


        private async void Load_Completed(object sender, NavigationEventArgs e)
        {
            string cssToApply = "";

            cssToApply += "a {display: none !important;}";


            await UltimeNewsWebView.InvokeScriptAsync("eval", new[] { "javascript:function addStyleString(str) { var node = document.createElement('style'); node.innerHTML = " +
                "str; document.body.appendChild(node); } addStyleString('" + cssToApply + "');" });
            UltimeNewsWebView.Visibility = Visibility.Visible;
            pr1.Visibility = Visibility.Collapsed;
        }

        //EVENTI

        // Aggiorna
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

            pr1.Visibility = Visibility.Visible;
            UltimeNewsWebView.Refresh();
            internet_status.Visibility = Visibility.Collapsed;
            UltimeNewsWebView.Visibility = Visibility.Collapsed;
        }

    }
}
