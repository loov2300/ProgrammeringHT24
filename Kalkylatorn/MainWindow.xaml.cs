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

namespace Kalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _counter = 100; // Ökar räckvidden så att counter minskar med 1 efter varje klick.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            int result;
            result = int.Parse(txtFirstValue.Text) + int.Parse(txtSecondValue.Text);          
            txtResult.Text = result.ToString();
        }

        private void btnDivition_Click(object sender, RoutedEventArgs e)
        {
            double result;  // Kör double istället för att det kan ofta bli decimaltal med division.
            result = double.Parse(txtFirstValue.Text) / double.Parse(txtSecondValue.Text);
            txtResult.Text = result.ToString();
            // Tips!
            // Math.Round(vad som ska avrundas, hur många decimaler)
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            int result;
            result = int.Parse(txtFirstValue.Text) * int.Parse(txtSecondValue.Text);
            txtResult.Text = result.ToString();
        }

        private void btnSubstraction_Click(object sender, RoutedEventArgs e)
        {
            int result;
            result = int.Parse(txtFirstValue.Text) - int.Parse(txtSecondValue.Text);
            txtResult.Text = result.ToString();

            _counter--;
            txtResult.Text = _counter.ToString();
        }
    }
}