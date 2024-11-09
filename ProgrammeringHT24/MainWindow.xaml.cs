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

namespace FL1
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string name = "Lovisa";
            MessageBox.Show("Hej " + name);

            btnOk.Content = name; // Byter namn på knappen till variabeln name.
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            string btnName = "Klickad";
            btnFirst.Content = btnName; // Byter innehåll på knappen till variabeln btnName
        }

        private void btnSecond_Click(object sender, RoutedEventArgs e)
        {
            string btnName = "Klickad";
            btnSecond.Content = btnName;
        }
    }
}