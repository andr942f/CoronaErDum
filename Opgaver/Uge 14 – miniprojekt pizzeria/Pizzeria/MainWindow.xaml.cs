using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace Pizzeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Font e = new Font("Ariel", 55);
        public MainWindow()
        {
            InitializeComponent();
            double[] standard = { 65.00, 80.00, 125.00, 215.00 };
            Pizza1.Text = Descriptor("Napoli", "Med løg, kylling, dressing og chili", standard);
            Pizza2.Text = Descriptor("Palermo", "Med kebab, løg, dressing og chili", standard);
            Pizza3.Text = Descriptor("Catania", "Med skinke og champignon", standard);
        }
        public string Descriptor(string navn, string ingredienser, double[] prices) =>
            $"{navn.ToUpper()}\n" +
            $"{ingredienser}\n\n" +
            $"Alm.: {prices[0]} kr.\n" +
            $"Deep pan: {prices[1]} kr.\n" +
            $"Fam.: {prices[2]} kr.\n" +
            $"Mega: {prices[3]} kr.";
        private void Pizza1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Pizza2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Pizza3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
