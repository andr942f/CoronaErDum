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
        public double[] standard = { 65.00, 80.00, 125.00, 215.00 };
        public double[] lavSelv= { 0.00, 0.00, 0.00, 0.00 };
        public MainWindow()
        {
            InitializeComponent();
            RABAT.Text = "Køb to, få én gratis";
            //Standard prices for pizzas (different pizza types have different prices, i did this so i could take into account if the program should be expanded)
           
            #region pizza descriptions
            Pizza1.Text = Descriptor("1) Napoli", "Med løg, kylling, dressing og chili", standard);
            Pizza2.Text = Descriptor("2) Palermo", "Med kebab, løg, dressing og chili", standard);
            Pizza3.Text = Descriptor("3) Catania", "Med skinke og champignon", standard);

            LavSelv.Text = "4) Lav selv\n".ToUpper() + "Med ";
            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Fam.: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
            #endregion
        }

        /// <summary>
        /// Insert and remove into your self made pizza
        /// </summary>
        /// <param name="item">name of item you want on  your pizza</param>
        /// /// <param name="alm">price for adding X to alm pizza</param>
        /// /// <param name="deep">price for adding X to deep pizza</param>
        /// /// <param name="fam">price for adding X to fam pizza</param>
        /// /// <param name="mega">price for adding X to mega pizza</param>
        /// <returns></returns>
        public string Write(string item, double alm, double deep, double fam, double mega)
        {
            if (LavSelv.Text.Contains(item))
            {
                lavSelv[0] -= alm;
                lavSelv[1] -= deep;
                lavSelv[2] -= fam;
                lavSelv[3] -= mega;
            }
            else
            {
                lavSelv[0] += alm;
                lavSelv[1] += deep;
                lavSelv[2] += fam;
                lavSelv[3] += mega;
            }
            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Fam.: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
            return LavSelv.Text.Contains(item) ? LavSelv.Text = LavSelv.Text.Replace(item, "") : LavSelv.Text += item;
        }

        // if you want extra on your pizza
        private void Ekstra_Click(object sender, RoutedEventArgs e) => LavSelv.Text += "ekstra ";

        #region Toppings
        private void Løg_Click(object sender, RoutedEventArgs e) => Write($"løg, ", 10, 20, 30, 40);

        private void Ananas_Click(object sender, RoutedEventArgs e) => Write("ananas, ", 11, 21, 26, 34);

        private void ChiliPeber_Click(object sender, RoutedEventArgs e) => Write("chili peber, ", 20, 30, 40, 50);

        private void Oliven_Click(object sender, RoutedEventArgs e) => Write("oliven, ", 5, 10, 15, 20);

        private void Sovs_Click(object sender, RoutedEventArgs e) => Write("sovs, ", 30, 40, 50, 60);

        private void Ost_Click(object sender, RoutedEventArgs e) => Write("ost, ", 30, 40, 50, 60);
        #endregion

        #region Crust and dough
        private void Indbagt_Click(object sender, RoutedEventArgs e) => Write("indbagt, ", 32, 42, 52, 62);

        private void Normal_Click(object sender, RoutedEventArgs e) => Write("normal, ", 30, 40, 50, 60);
        #endregion

        #region ingridents
        private void Paprika_Click(object sender, RoutedEventArgs e) => Write("paprika, ", 4, 8, 12, 16);

        private void Pizzakrydder_Click(object sender, RoutedEventArgs e) => Write("pizzakrydder, ", 2, 4, 6, 8);
        #endregion

        #region choose other pizzas to modify
        private void one1_Click(object sender, RoutedEventArgs e) => Write("Napoli, ", standard[0], standard[1], standard[2], standard[3]);

        private void two2_Click(object sender, RoutedEventArgs e) => Write("Palermo, ", standard[0], standard[1], standard[2], standard[3]);

        private void three3_Click(object sender, RoutedEventArgs e) => Write("Catania, ", standard[0], standard[1], standard[2], standard[3]);
        #endregion

        #region Choose size of pizza
        private void Alm_Click(object sender, RoutedEventArgs e) => AlmCheck.IsChecked ^= true;

        private void DeepPan_Click(object sender, RoutedEventArgs e) => DeepCheck.IsChecked ^= true;

        private void Fam_Click(object sender, RoutedEventArgs e) => FamCheck.IsChecked ^= true;

        private void Mega_Click(object sender, RoutedEventArgs e) => MegaCheck.IsChecked ^= true;

        #endregion

        #region Drinks
        private void Lille_Click(object sender, RoutedEventArgs e) => Write("Lille Drik, ", 30, 40, 50, 60);

        private void Mellem_Click(object sender, RoutedEventArgs e) => Write("Mellem Drik, ", 40, 50, 60, 70);

        private void Stor_Click(object sender, RoutedEventArgs e) => Write("Stor Drik, ", 50, 60, 70, 80);
        #endregion
    }
}
