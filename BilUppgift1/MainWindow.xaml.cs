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

namespace BilUppgift1
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

        private void btnCalculateWeight_Click(object sender, RoutedEventArgs e)
        {
            int weightB, weightExtendedB, totalWeight;

            totalWeight = int.Parse(txtBoxTotalWeight.Text);
            weightB = 3500 - totalWeight;
            weightExtendedB = 4250 - totalWeight;

            //weightB = int.Parse(txtBoxBWeight.Text);
            //weightExtendedB = int.Parse(txtBoxExtendedBWeight.Text);

            txtBoxBWeight.Text = weightB.ToString();
            txtBoxExtendedBWeight.Text = weightExtendedB.ToString();

            //MessageBox.Show(weightB.ToString());
            //MessageBox.Show(weightExtendedB.ToString());
        }
    }
}