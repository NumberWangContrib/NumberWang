using System;
using System.Windows;
using Microsoft.Phone.Controls;
using NumberWang.Engine;

namespace NumberWang
{
    public partial class Rules : PhoneApplicationPage
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void StandardRulesChecked(object sender, RoutedEventArgs e)
        {
            GeorgeViRules.IsChecked = false;
            EustonConnectionRules.IsChecked = false;
            GoldVariantRules.IsChecked = false;

            GeorgeSelector();
        }

        private void OnGeorgeViRulesChecked(object sender, RoutedEventArgs e)
        {
            StandardRules.IsChecked = false;
            EustonConnectionRules.IsChecked = false;
            GoldVariantRules.IsChecked = false;

            GeorgeSelector();
        }

        private void GoldVariantChecked(object sender, RoutedEventArgs e)
        {
            GeorgeViRules.IsChecked = false;
            StandardRules.IsChecked = false;
            EustonConnectionRules.IsChecked = false;

            GeorgeSelector();
        }


        private void OnEustonConnectionChecked(object sender, RoutedEventArgs e)
        {
            GeorgeViRules.IsChecked = false;
            StandardRules.IsChecked = false;
            GoldVariantRules.IsChecked = false;

            GeorgeSelector();
        }

        private void GeorgeSelector()
        {
            GeorgeViRules.Content = George6thModel.GetGeorgeThe6th();
        }
    }
}