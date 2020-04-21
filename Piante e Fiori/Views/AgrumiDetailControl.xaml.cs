using System;

using Piante_e_Fiori.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Piante_e_Fiori.Views
{
    public sealed partial class AgrumiDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(AgrumiDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public AgrumiDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as AgrumiDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
