using System;

using Piante_e_Fiori.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Piante_e_Fiori.Views
{
    public sealed partial class ControlloSanitarioDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(ControlloSanitarioDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public ControlloSanitarioDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ControlloSanitarioDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
