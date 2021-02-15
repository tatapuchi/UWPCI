using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPTest2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            //var dialog = new ContentDialog()
            //{

            //    Title = "Delete",
            //    Content = "Confirm Delete?",
            //    PrimaryButtonText = "Yes",
            //    SecondaryButtonText = "Cancel"


            //};

            //await dialog.ShowAsync();

            //var menu = new PopupMenu();
            //menu.Commands.Add(new UICommand("5 Stars", null, 5));
            //menu.Commands.Add(new UICommand("4 Stars", null, 4));
            //menu.Commands.Add(new UICommand("3 Stars", null, 3));
            //menu.Commands.Add(new UICommand("2 Stars", null, 2));
            //menu.Commands.Add(new UICommand("1 Stars", null, 1));

            //var button = sender as Button;
            //var point = button.TransformToVisual(null).TransformPoint(new Point());
            //var result = await menu.ShowAsync(point);

        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout(sender as FrameworkElement);
        }
    }
}
