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
        public double[] lavSelv = { 0.00, 0.00, 0.00, 0.00 };
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
            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Familie: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
            #endregion
        }

        #region Custom pizza UI
        /// <summary>
        /// The UI os the custom pizza
        /// </summary>
        /// <param name="item">name of item you want on  your pizza</param>
        /// <param name="alm">price for adding X to alm pizza</param>
        /// <param name="deep">price for adding X to deep pizza</param>
        /// <param name="fam">price for adding X to fam pizza</param>
        /// <param name="mega">price for adding X to mega pizza</param>
        /// <para">Click the same button more than once to get ekstra of said item on the pizza</para>
        /// <returns></returns>
        public string Write(string item, double alm, double deep, double fam, double mega)
        {
            if (!LavSelv.Text.Contains(item) || !LavSelv.Text.Contains($"Ekstra {item}"))
            {
                lavSelv[0] += alm;
                lavSelv[1] += deep;
                lavSelv[2] += fam;
                lavSelv[3] += mega;
            }
            else
            {
                lavSelv[0] = lavSelv[0] - alm - alm;
                lavSelv[1] = lavSelv[1] - deep - deep;
                lavSelv[2] = lavSelv[2] - fam - fam;
                lavSelv[3] = lavSelv[3] - mega - mega;
            }
            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Familie: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
            return LavSelv.Text.Contains($"Ekstra {item}") ?
                LavSelv.Text = LavSelv.Text.Replace($"Ekstra {item}", "") : LavSelv.Text.Contains(item) ?
                LavSelv.Text = LavSelv.Text.Replace(item, $"Ekstra {item}") : LavSelv.Text += item;
        }
        public void Drink(double alm, double deep, double fam, double mega)
        {
            string[] drinks = { "Cola", "Sprite", "Fanta", "Pepsi", "Water" };
            if (LavSelv.Text.Contains(drinks[0]))
            {
                lavSelv[0] += alm;
                lavSelv[1] += deep;
                lavSelv[2] += fam;
                lavSelv[3] += mega;
            }
            else if (LavSelv.Text.Contains(drinks[3]))
            {
                lavSelv[0] = lavSelv[0] - alm;
                lavSelv[1] = lavSelv[1] - deep;
                lavSelv[2] = lavSelv[2] - fam;
                lavSelv[3] = lavSelv[3] - mega;
            }


            LavSelv.Text = LavSelv.Text.Contains(drinks[0]) ?
                LavSelv.Text = LavSelv.Text.Replace(drinks[0], drinks[1]) :
            LavSelv.Text.Contains(drinks[1]) ?
                LavSelv.Text = LavSelv.Text.Replace(drinks[1], drinks[2]) :
            LavSelv.Text.Contains(drinks[2]) ?
                LavSelv.Text = LavSelv.Text.Replace(drinks[2], drinks[3]) :
            LavSelv.Text.Contains(drinks[3]) ?
                LavSelv.Text = LavSelv.Text.Replace(drinks[3], drinks[4]) :
            LavSelv.Text.Contains(drinks[4]) ?
                LavSelv.Text = LavSelv.Text.Replace(drinks[4], "") : LavSelv.Text += drinks[0];
            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Familie: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
        }
        #endregion

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
        private void Lille_Click(object sender, RoutedEventArgs e) => Drink(30, 40, 50, 60);

        private void Mellem_Click(object sender, RoutedEventArgs e) => Drink(40, 50, 60, 70);

        private void Stor_Click(object sender, RoutedEventArgs e) => Drink(50, 60, 70, 800);
        #endregion

        #region Paytime buttons
        /// <summary>
        /// A little layout helper for when you have to pay
        /// </summary>
        /// <param name="dis">Money amount</param>
        /// <returns></returns>
        public string Payhelp(double dis)
        {
            payment pay = new payment();
            pay.Show();
            return pay.tak.Text += $"Tak for købet! Det bliver: {dis} kr.";
        }

        /// <summary>
        /// Basic layout for when you have to pay
        /// </summary>
        /// <param name="one">AlmCheck</param>
        /// <param name="two">DeepCheck</param>
        /// <param name="three">FamCheck</param>
        /// <param name="four">Megacheck</param>
        /// <param name="Amount">Pay amount</param>
        public void PayIt(bool? one, bool? two, bool? three, bool? four, double[] Amount)
        {
            if (one == true)
                Payhelp(Amount[0]);
            else if (two == true)
                Payhelp(Amount[1]);
            else if (three == true)
                Payhelp(Amount[2]);
            else if (four == true)
                Payhelp(Amount[3]);
        }

        public void Pay_Click(object sender, RoutedEventArgs e) => PayIt(AlmCheck.IsChecked, DeepCheck.IsChecked, FamCheck.IsChecked, MegaCheck.IsChecked, lavSelv);
        private void Pay1_Click(object sender, RoutedEventArgs e) => PayIt(AlmCheck_NAPOLI.IsChecked, DeepCheck_NAPOLI.IsChecked, FamCheck_NAPOLI.IsChecked, MegaCheck_NAPOLI.IsChecked, standard);
        private void Pay2_Click(object sender, RoutedEventArgs e) => PayIt(AlmCheck_PALERMO.IsChecked, DeepCheck_PALERMO.IsChecked, FamCheck_PALERMO.IsChecked, MegaCheck_PALERMO.IsChecked, standard);
        private void Pay3_Click(object sender, RoutedEventArgs e) => PayIt(AlmCheck_CATANIA.IsChecked, DeepCheck_CATANIA.IsChecked, FamCheck_CATANIA.IsChecked, MegaCheck_CATANIA.IsChecked, standard);
        #endregion
    }
}
