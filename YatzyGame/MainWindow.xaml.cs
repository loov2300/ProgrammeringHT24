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

namespace YatzyGame
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
            int diceOne, diceTwo, diceThree, diceFour, diceFive, total;

            //diceOne = int.Parse(txtOnes.Text);
            //diceTwo = int.Parse(txtTwos.Text);
            //diceThree = int.Parse(txtThrees.Text);
            //diceFour = int.Parse(txtFours.Text);
            //diceFive = int.Parse(txtFives.Text);

            int categoryOnes, categoryTwos, categoryThrees, categoryFours, categoryFives, categorySixes;

            categoryOnes = int.Parse(txtOnes.Text);  
            categoryTwos = int.Parse(txtTwos.Text);
            categoryThrees = int.Parse(txtThrees.Text);
            categoryFours = int.Parse(txtFours.Text);
            categoryFives = int.Parse(txtFives.Text);
            categorySixes = int.Parse(txtSixes.Text);

            total = categoryOnes + categoryTwos + categoryThrees + categoryFours + categoryFives + categorySixes;

            if (categoryOnes != 1 && categoryOnes != 2 && categoryOnes != 3 && categoryOnes != 4 && categoryOnes != 5)  // kontrollera att summan av varje siffra är rimlig. t.ex man kan inte få 3 poäng på tvåor.
            {
                MessageBox.Show("Ogiltig inmatning av ettor. Försök igen.");
            }

            if (categoryTwos != 2 && categoryTwos != 4 && categoryTwos != 6 && categoryTwos != 8 && categoryTwos != 10)
            {
                MessageBox.Show("Ogiltig inmatning av tvåor. Försök igen.");
            }

            if (categoryThrees != 3 && categoryThrees != 6 && categoryThrees != 9 && categoryThrees != 12 && categoryThrees != 15)
            {
                MessageBox.Show("Ogiltig inmatning av treor. Försök igen.");
            }

            if (categoryFours != 4 && categoryFours != 8 && categoryFours != 12 && categoryFours != 16 && categoryFours != 20)
            {
                MessageBox.Show("Ogiltig inmatning av fyror. Försök igen.");
            }

            if (categoryFives != 5 && categoryFives != 10 && categoryFives != 15 && categoryFives != 20 && categoryFives != 25)
            {
                MessageBox.Show("Ogiltig inmatning av femmor. Försök igen.");
            }

            if (categorySixes != 6 && categorySixes != 12 && categorySixes != 18 && categorySixes != 24 && categorySixes != 30)
            {
                MessageBox.Show("Ogiltig inmatning av sexor. Försök igen.");
            }

            if (total >= 63)
            {
                txtBonus.Text = 50.ToString();
                //txtTotal.Text = total+txtBonus.Text;
                total += 50;
            }
            else if (total < 63)
            {
                txtBonus.Text = string.Empty;
            }

            txtTotal.Text = total.ToString();
        }
    }
}