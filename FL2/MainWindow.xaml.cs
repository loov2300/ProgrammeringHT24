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

namespace FL2
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
            int currentYear = 2024, yearOfBirth, age;
            yearOfBirth = int.Parse(txtAge.Text);
            age = currentYear - yearOfBirth;
            txtAge.Text = age.ToString();

            // Formattera texten så att det blir åldern + år.
            // Stränginterpolation = dollartecken som "snyggar till" strängen.

            txtAge.Text = $"{age} år";
                                        // Båda gör samma sak fast skrivna på olika sätt.
            txtAge.Text = age + " år";
        }
    }
}