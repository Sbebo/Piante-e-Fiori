using System;

using Piante_e_Fiori.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Piante_e_Fiori.Views
{
    public sealed partial class GlossarioDetailControl : UserControl
    {
        public Glossario MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Glossario; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(Glossario), typeof(GlossarioDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public GlossarioDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as GlossarioDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
