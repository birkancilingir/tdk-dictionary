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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TdkDictionary.UserControls
{
    public sealed partial class PageHeader : UserControl
    {
        public PageHeader()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty PageTitleProperty = DependencyProperty.Register("PageTitle", typeof(String), typeof(UserControl), null);

        public String PageTitle
        {
            get { return (String)GetValue(PageTitleProperty); }
            set
            {
                SetValue(PageTitleProperty, value);                
            }
        }
    }
}
