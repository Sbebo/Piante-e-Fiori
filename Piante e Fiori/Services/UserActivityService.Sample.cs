using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AdaptiveCards;

using Piante_e_Fiori.Activation;
using Piante_e_Fiori.Views;

using Windows.ApplicationModel;
using Windows.UI;
using Windows.UI.Shell;

namespace Piante_e_Fiori.Services
{
    public static partial class UserActivityService
    {
        public static async Task AddSampleUserActivity()
        {
            var activityId = nameof(SchemeActivationSamplePage);
            var displayText = "PIANTE E FIORI";
            var description = $"Torna alle schede botaniche '{Package.Current.DisplayName}' at {DateTime.Now.ToShortTimeString()}";
            var imageUrl = "ms-appx:///Assets/lotus_1600.png";
            //var imageUrl = "http://adaptivecards.io/content/cats/2.png";

            var activityData = new UserActivityData(activityId, CreateActivationDataSample(), displayText, Colors.DarkRed);
            var adaptiveCard = CreateAdaptiveCardSample(displayText, description, imageUrl);

            await UserActivityService.CreateUserActivityAsync(activityData, adaptiveCard);
        }

        private static SchemeActivationData CreateActivationDataSample()
        {
            var parameters = new Dictionary<string, string>()
            {
                { "paramName1", "paramValue1" },
                { "ticks", DateTime.Now.Ticks.ToString() }
            };
            return new SchemeActivationData(typeof(SchemeActivationSamplePage), parameters);
        }

        // TODO WTS: Change this to configure your own adaptive card
        // For more info about adaptive cards see http://adaptivecards.io/
        private static IAdaptiveCard CreateAdaptiveCardSample(string displayText, string description, string imageUrl)
        {
            var adaptiveCard = new AdaptiveCard();
            var columns = new AdaptiveColumnSet();
            var firstColumn = new AdaptiveColumn() { Width = "auto" };
            var secondColumn = new AdaptiveColumn() { Width = "*" };

            firstColumn.Items.Add(new AdaptiveImage()
            {
                Url = new Uri(imageUrl),
                Size = AdaptiveImageSize.Medium
            });

            secondColumn.Items.Add(new AdaptiveTextBlock()
            {
                Text = displayText,
                Weight = AdaptiveTextWeight.Bolder,
                Size = AdaptiveTextSize.Large
            });

            secondColumn.Items.Add(new AdaptiveTextBlock()
            {
                Text = description,
                Size = AdaptiveTextSize.Medium,
                Weight = AdaptiveTextWeight.Lighter,
                Wrap = true
            });

            columns.Columns.Add(firstColumn);
            columns.Columns.Add(secondColumn);
            adaptiveCard.Body.Add(columns);

            return AdaptiveCardBuilder.CreateAdaptiveCardFromJson(adaptiveCard.ToJson());
        }
    }
}
