using System.Windows;
using Microsoft.Phone.Controls;
using NumberWang.Engine;

namespace NumberWang
{
    public partial class NumberWang : PhoneApplicationPage
    {
        private readonly NumberWangModel _numberWangModel = new NumberWangModel();

        public NumberWang()
        {
            InitializeComponent();
        }

        private void OnPlay(object sender, RoutedEventArgs e)
        {
            bool result = _numberWangModel.IsNumberWang(69);

            txtResult.Text = result ? "That's NumberWang!!" : "Not Numberwang";
        }
    }
}