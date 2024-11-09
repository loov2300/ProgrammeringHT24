using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FL4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // poliskontroll, nykterhet och hastighet.
            bool isSober = true;
            bool hasCorrectSpeed = true;
            int speed = 135, currentSpeedLimit = 90;

            if (!isSober)
            {
                // polisen låter mig inte köra vidare
            }

            bool loseLicense = speed - currentSpeedLimit > 30;
            if (!hasCorrectSpeed)
            {
                // får böter men får kanske köra vidare
                if (loseLicense)
                {
                    return;
                }
            }

            if (isSober == false || hasCorrectSpeed == false) // || symbolen är CTRL+ALT+< betyder att om ett av villkoren uppfylls så körs den
            {
                // ge böter
            }
        }
    }
}