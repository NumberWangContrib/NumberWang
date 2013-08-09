using System;
using System.Globalization;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using NumberWang.Engine;

namespace NumberWang
{
    public partial class NumberWang : PhoneApplicationPage
    {
        private readonly NumberWangModel _numberWangModel = new NumberWangModel();

        private bool _isPlayerTwoTurn;

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

            SetScore(_isPlayerTwoTurn);

            _isPlayerTwoTurn = !_isPlayerTwoTurn;
        }

        private void SetScore(bool isPlayerTwoTurn)
        {
            var rndm = new Random(DateTime.UtcNow.Millisecond);

            if (isPlayerTwoTurn)
            {
                PlayerTwoRun.Text = string.Format(" {0}", rndm.Next(-3504, 95643).ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                PlayerOneRun.Text = string.Format(" {0}",  rndm.Next(-3504, 95643).ToString(CultureInfo.InvariantCulture));
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string buttonIdValue = NavigationContext.QueryString["id"];
            

            if (!string.IsNullOrEmpty(buttonIdValue))
            {
                if (buttonIdValue == "single")
                {
                    PlayerOne.Visibility = Visibility.Collapsed;
                    PlayerTwo.Visibility = Visibility.Collapsed;
                    PlayerTurn.Visibility = Visibility.Collapsed;
                }
                else
                {
                    PlayerOne.Visibility = Visibility.Visible;
                    PlayerTwo.Visibility = Visibility.Visible;
                    PlayerTurn.Visibility = Visibility.Visible;
                }
            }
        }

    }
}