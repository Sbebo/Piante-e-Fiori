using Piante_e_Fiori.Models;
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
    public sealed partial class AddAlarmPage : Page
    {
        public AddAlarmPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            string name = TextBoxName.Text;
            TimeSpan time = TimePickerTime.Time;
            bool onlyOnce = ComboBoxRepeats.SelectedIndex == 0;

            var alarm = new MyAlarm()
            {
                Name = name,
                TimeOfDay = time
            };

            if (onlyOnce)
            {
                if (time < DateTime.Now.TimeOfDay)
                {
                    // If time for today has already passed, set it for tomorrow
                    alarm.SingleFireTime = DateTime.Today.AddDays(1).Add(time);
                }
                else
                {
                    // Otherwise, set it for today at the time
                    alarm.SingleFireTime = DateTime.Today.Add(time);
                }
            }
            else
            {
                alarm.DaysOfWeek = new DayOfWeek[]
                {
                    DayOfWeek.Sunday,
                    DayOfWeek.Monday,
                    DayOfWeek.Tuesday,
                    DayOfWeek.Wednesday,
                    DayOfWeek.Thursday,
                    DayOfWeek.Friday,
                    DayOfWeek.Saturday
                };
            }

            await DataModel.AddAlarm(alarm);

            Frame.GoBack();
        }
    }
}
