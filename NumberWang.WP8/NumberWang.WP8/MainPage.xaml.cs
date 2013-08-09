using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace NumberWang.WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void OnPlay(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NumberWang.xaml"));
        }
    }
}