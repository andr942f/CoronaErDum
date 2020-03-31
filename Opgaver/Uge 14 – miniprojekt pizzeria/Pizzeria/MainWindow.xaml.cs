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
            Pizza1.Text = Descriptor("1) Napoli", "Med løg, kylling, dressing og chili", standard);
            Pizza2.Text = Descriptor("2) Palermo", "Med kebab, løg, dressing og chili", standard);
            Pizza3.Text = Descriptor("3) Catania", "Med skinke og champignon", standard);
            LavSelv.Text = "4) Lav selv\n".ToUpper() + "Med ";
            SizeChoose.Text = $"Alm.: { standard[0]} kr.\n" + $"Deep pan: {standard[1]} kr.\n" + $"Fam.: {standard[2]} kr.\n" + $"Mega: {standard[3]} kr.";
            #endregion
        }

        /// <summary>
        /// Insert and romove into your self made pizza
        /// </summary>
        /// <param name="item">name of item you want on  your pizza</param>
        /// <returns></returns>
        public string Write(string item) => LavSelv.Text.Contains(item) ? LavSelv.Text = LavSelv.Text.Replace(item, "") : LavSelv.Text += item;
        
        // if you want extra on your pizza
        private void Ekstra_Click(object sender, RoutedEventArgs e) => LavSelv.Text += "ekstra ";

        #region Toppings
        private void Løg_Click(object sender, RoutedEventArgs e) => Write("løg, ");

        private void Ananas_Click(object sender, RoutedEventArgs e) => Write("ananas, ");

        private void ChiliPeber_Click(object sender, RoutedEventArgs e) => Write("chili peber, ");

        private void Oliven_Click(object sender, RoutedEventArgs e) => Write("oliven, ");

        private void Sovs_Click(object sender, RoutedEventArgs e) => Write("sovs, ");

        private void Ost_Click(object sender, RoutedEventArgs e) => Write("ost, ");
        #endregion

        #region Crust and dough
        private void Indbagt_Click(object sender, RoutedEventArgs e) => Write("indbagt, ");

        private void Normal_Click(object sender, RoutedEventArgs e) => Write("normal, ");
        #endregion

        #region ingridents
        private void Paprika_Click(object sender, RoutedEventArgs e) => Write("paprika, ");

        private void Pizzakrydder_Click(object sender, RoutedEventArgs e) => Write("pizzakrydder, ");
        #endregion

        #region choose other pizzas to modify
        private void one1_Click(object sender, RoutedEventArgs e) => Write("Napoli, ");

        private void two2_Click(object sender, RoutedEventArgs e) => Write("Palermo, ");

        private void three3_Click(object sender, RoutedEventArgs e) => Write("Catania, ");
        #endregion

        #region Choose size of pizza
        private void Alm_Click(object sender, RoutedEventArgs e) => AlmCheck.IsChecked ^= true;

        private void DeepPan_Click(object sender, RoutedEventArgs e) => DeepCheck.IsChecked ^= true;

        private void Fam_Click(object sender, RoutedEventArgs e) => FamCheck.IsChecked ^= true;

        private void Mega_Click(object sender, RoutedEventArgs e) => MegaCheck.IsChecked ^= true;
        #endregion
    }
}
