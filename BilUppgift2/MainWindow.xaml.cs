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

namespace BilUppgift2
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            // 7 tecken. 3 bokstäver + mellanslag + 3 siffror.
            // Bygg en metod som tar registreringsnumret som indata och returnerar true
            // om antal tecken är 7, annars false. 

            bool hasCorrectLength = true;
            string sign;
            sign = txtBoxNumber.Text;

            if (sign.Length == 7)
            {
                //return;
                MessageBox.Show(hasCorrectLength.ToString());
            }
            else
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken.");
            }
        }
    }
}