using System.Windows;
using Microsoft.Phone.Controls;

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
        }

        private void OnGeorgeViRulesChecked(object sender, RoutedEventArgs e)
        {
            StandardRules.IsChecked = false;
        }
    }
}