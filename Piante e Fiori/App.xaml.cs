using System;
using Microsoft.Services.Store.Engagement;
using Piante_e_Fiori.Services;
using Piante_e_Fiori.Views;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Piante_e_Fiori
{
    public sealed partial class App : Application
    {
        private Lazy<ActivationService> _activationService;

        private ActivationService ActivationService
        {
            get { return _activationService.Value; }
        }

        public App()
        {
            // TODO WTS: Replace the default 3D Launcher model with something appropriate to your app
            // For details see https://docs.microsoft.com/en-us/windows/mixed-reality/3d-app-launcher-design-guidance
            InitializeComponent();

            // Deferred execution until used. Check https://msdn.microsoft.com/library/dd642331(v=vs.110).aspx for further info on Lazy<T> class.
            _activationService = new Lazy<ActivationService>(CreateActivationService);
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (!args.PrelaunchActivated)
            {
                await ActivationService.ActivateAsync(args);
            }

            //Per ricevere nell'app notifiche che invio dal Dashboard https://docs.microsoft.com/it-it/windows/uwp/publish/send-push-notifications-to-your-apps-customers
            //Eseguire la registrazione per le notifiche push
            StoreServicesEngagementManager engagementManager = StoreServicesEngagementManager.GetDefault();
            await engagementManager.RegisterNotificationChannelAsync();
        }

        protected override async void OnActivated(IActivatedEventArgs args)
        {
            await ActivationService.ActivateAsync(args);

            //Comunicare a Dev Center che la tua app è stata avviata
            base.OnActivated(args);

            if (args is ToastNotificationActivatedEventArgs)
            {
                var toastActivationArgs = args as ToastNotificationActivatedEventArgs;

                StoreServicesEngagementManager engagementManager = StoreServicesEngagementManager.GetDefault();
                string originalArgs = engagementManager.ParseArgumentsAndTrackAppLaunch(
                    toastActivationArgs.Argument);

                // Use the originalArgs variable to access the original arguments
                // that were passed to the app.
            }


            //AVVIO APP CON WINDOWS
            string payload = string.Empty;
            if (args.Kind == ActivationKind.StartupTask)
            {
                var startupArgs = args as StartupTaskActivatedEventArgs;
                payload = ActivationKind.StartupTask.ToString();
            }
            
            NavigationService.Navigate(typeof(HomePagePage), payload);
            Window.Current.Activate();          
        }


        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var details = taskInstance.TriggerDetails as ToastNotificationActionTriggerDetail;

            if (details != null)
            {
                StoreServicesEngagementManager engagementManager = StoreServicesEngagementManager.GetDefault();
                string originalArgs = engagementManager.ParseArgumentsAndTrackAppLaunch(details.Argument);

                // Use the originalArgs variable to access the original arguments
                // that were passed to the app.
            }
        }

        private ActivationService CreateActivationService()
        {
            return new ActivationService(this, typeof(Views.HomePagePage), new Lazy<UIElement>(CreateShell));
        }

        private UIElement CreateShell()
        {
            return new Views.ShellPage();
        }

        protected override async void OnBackgroundActivated(BackgroundActivatedEventArgs args)
        {
            await ActivationService.ActivateAsync(args);
        }
    }
}
