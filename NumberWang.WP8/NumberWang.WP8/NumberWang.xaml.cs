using Microsoft.Phone.Controls;
using NumberWang.Engine;

namespace NumberWang
{
    public partial class NumberWang : PhoneApplicationPage
    {
        private NumberWangModel _numberWangModel = new NumberWangModel();

        public NumberWang()
        {
            InitializeComponent();
        }
    }
}