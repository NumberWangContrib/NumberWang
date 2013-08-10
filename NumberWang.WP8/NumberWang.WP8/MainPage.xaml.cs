using System;
using System.Windows;
using Microsoft.Phone.Controls;
using System.Windows.Controls;

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
            NavigationService.Navigate(new Uri("/NumberWang.xaml?id=single", UriKind.Relative));
        }

        private void OnRules(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Rules.xaml", UriKind.Relative));
        }

        private void OnMultiplayer(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NumberWang.xaml?id=multiplayer", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Source = new Uri("/Assets/Audio/Intro.mp3", UriKind.Relative);
        }
    }
}