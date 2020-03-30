using System.Windows;

namespace Pizzeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Description and and setup of the menu card
        /// <para>Made more than two sizes, whoops</para>
        /// </summary>
        /// <param name="name">Name of pizza</param>
        /// <param name="ingredients">List of ingredients</param>
        /// <param name="prices">Price of pizza</param>
        /// <returns></returns>
        public string Descriptor(string name, string ingredients, double[] prices) =>
            $"{name.ToUpper()}\n" +
            $"{ingredients}\n\n" +
            $"Alm.: {prices[0]} kr.\n" +
            $"Deep pan: {prices[1]} kr.\n" +
            $"Fam.: {prices[2]} kr.\n" +
            $"Mega: {prices[3]} kr.";
        public MainWindow()
        {
            InitializeComponent();
            //Standard prices for pizzas (different pizza types have different prices, i did this so i could take into account if the program should be expanded)
            double[] standard = { 65.00, 80.00, 125.00, 215.00 };

            #region pizza descriptions
            Pizza1.Text = Descriptor("Napoli", "Med løg, kylling, dressing og chili", standard);
            Pizza2.Text = Descriptor("Palermo", "Med kebab, løg, dressing og chili", standard);
            Pizza3.Text = Descriptor("Catania", "Med skinke og champignon", standard);
            #endregion
        }
    }
}
