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
            decimal value;

            if (!decimal.TryParse(txtGuess.Text, out value))
            {
                txtResult.Text = "Thats not even a number!";
                return;
            }

            NumberWangType result = _numberWangModel.TestNumberWang(value);

            txtResult.Text = result.ToWangString();

            txtGuess.Text = string.Empty;
        }
    }
}