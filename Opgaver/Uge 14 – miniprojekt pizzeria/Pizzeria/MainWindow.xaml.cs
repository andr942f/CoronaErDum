using System;
using System.Windows;
using System.Windows.Controls;

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
        /// <returns></returns>
        public string Descriptor(string name, string ingredients) =>
            $"{name.ToUpper()}\n" +
            $"{ingredients}";
        public double[] standard = { 65.00, 80.00, 125.00, 215.00 };
        public double[] lavSelv = { 15.00, 20.00, 25.00, 30.00 };
        public MainWindow()
        {
            InitializeComponent();
            //Standard prices for pizzas (different pizza types have different prices, i did this so i could take into account if the program should be expanded)

            #region pizza descriptions
            Pizza1.Text = Descriptor("1) Napoli", "Med Tomatsovs, ost, løg, kylling, dressing, chili, ");
            Pizza2.Text = Descriptor("2) Palermo", "Med Tomatsovs, ost, kebab, løg, dressing, chili, ");
            Pizza3.Text = Descriptor("3) Catania", "Med Tomatsovs, ost, skinke, champignon, ");

            LavSelv.Text = "4) Lav selv\n".ToUpper() + "Med Tomatsovs, ost, ";
            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Familie: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
            SizeChoose1.Text = $"Alm.: {standard[0]} kr.\n" + $"Deep pan: {standard[1]} kr.\n" + $"Familie: {standard[2]} kr.\n" + $"Mega: {standard[3]} kr.\n";
            SizeChoose2.Text = $"Alm.: {standard[0]} kr.\n" + $"Deep pan: {standard[1]} kr.\n" + $"Familie: {standard[2]} kr.\n" + $"Mega: {standard[3]} kr.\n";
            SizeChoose3.Text = $"Alm.: {standard[0]} kr.\n" + $"Deep pan: {standard[1]} kr.\n" + $"Familie: {standard[2]} kr.\n" + $"Mega: {standard[3]} kr.\n";
            #endregion
        }

        #region Custom pizza UI
        /// <summary>
        /// The UI os the custom pizza
        /// (Click the same button more than once to get ekstra of said item on the pizza)
        /// </summary>
        /// <param name="IngList">name of TextBox changed</param>
        /// <param name="PriceList">start price used</param>
        /// <param name="price">price identifier for the PriceList</param>
        /// <param name="item">name of item you want on  your pizza</param>
        /// <param name="alm">price for adding X to alm pizza</param>
        /// <param name="deep">price for adding X to deep pizza</param>
        /// <param name="fam">price for adding X to fam pizza</param>
        /// <param name="mega">price for adding X to mega pizza</param>
        public string ToppingPick(TextBox IngList, TextBox PriceList, double[] price, string item, double alm, double deep, double fam, double mega)
        {
            if (!IngList.Text.Contains(item) || !IngList.Text.Contains($"Ekstra {item}"))
            {
                price[0] += alm;
                price[1] += deep;
                price[2] += fam;
                price[3] += mega;
            }
            else
            {
                price[0] = price[0] - alm - alm;
                price[1] = price[1] - deep - deep;
                price[2] = price[2] - fam - fam;
                price[3] = price[3] - mega - mega;
            }
            PriceList.Text = $"Alm.: {price[0]} kr.\n" + $"Deep pan: {price[1]} kr.\n" + $"Familie: {price[2]} kr.\n" + $"Mega: {price[3]} kr.\n";
            return IngList.Text.Contains($"Ekstra {item}") ?
                IngList.Text = IngList.Text.Replace($"Ekstra {item}", "") : IngList.Text.Contains(item) ?
                IngList.Text = IngList.Text.Replace(item, $"Ekstra {item}") : IngList.Text += item;
        }
        /// <summary>
        /// price of drinks/sizes
        /// </summary>
        /// <param name="alm">Price for a normal catagory drink</param>
        /// <param name="deep">price of a deep pan catagory drink</param>
        /// <param name="fam">price of a family catagory drink</param>
        /// <param name="mega">price of a mega catagory drink</param>
        public void DrinkPick(double alm, double deep, double fam, double mega)
        {
            string[] drinks = { "Cola", "Sprite", "Fanta", "Pepsi", "Water" };

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

            if (LavSelv.Text.Contains(drinks[0]))
            {
                lavSelv[0] += alm;
                lavSelv[1] += deep;
                lavSelv[2] += fam;
                lavSelv[3] += mega;
            }
            else if (LavSelv.Text.Contains(drinks[4]))
            {
                lavSelv[0] = lavSelv[0] - alm;
                lavSelv[1] = lavSelv[1] - deep;
                lavSelv[2] = lavSelv[2] - fam;
                lavSelv[3] = lavSelv[3] - mega;
            }


            SizeChoose.Text = $"Alm.: {lavSelv[0]} kr.\n" + $"Deep pan: {lavSelv[1]} kr.\n" + $"Familie: {lavSelv[2]} kr.\n" + $"Mega: {lavSelv[3]} kr.\n";
        }
        #endregion

        #region Toppings
        private void Løg_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, $"løg, ", 10, 20, 30, 40);

        private void Ananas_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "ananas, ", 11, 21, 26, 34);

        private void ChiliPeber_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "chili peber, ", 20, 30, 40, 50);

        private void Oliven_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "oliven, ", 5, 10, 15, 20);
        #endregion

        #region Crust and dough
        private void Indbagt_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "indbagt, ", 32, 42, 52, 62);

        private void Normal_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "normal, ", 30, 40, 50, 60);
        #endregion

        #region ingridents
        private void Paprika_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "paprika, ", 4, 8, 12, 16);

        private void Pizzakrydder_Click(object sender, RoutedEventArgs e) => ToppingPick(LavSelv, SizeChoose, lavSelv, "pizzakrydder, ", 2, 4, 6, 8);
        #endregion

        #region choose other pizzas to modify
        private void One1_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza3, SizeChoose3, standard, "skinke, ", 4, 8, 12, 16);
        private void One2_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza3, SizeChoose3, standard, "champignon, ", 4, 8, 12, 16);


        private void Two1_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza2, SizeChoose2, standard, "kebab, ", 4, 8, 12, 16);
        private void Two2_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza2, SizeChoose2, standard, "løg, ", 4, 8, 12, 16);
        private void Two3_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza2, SizeChoose2, standard, "dressing, ", 4, 8, 12, 16);
        private void Two4_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza2, SizeChoose2, standard, "chili, ", 4, 8, 12, 16);

        private void Three1_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza1, SizeChoose1, standard, "løg, ", 4, 8, 12, 16);
        private void Three2_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza1, SizeChoose1, standard, "kylling, ", 4, 8, 12, 16);
        private void Three3_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza1, SizeChoose1, standard, "dressing, ", 4, 8, 12, 16);
        private void Three4_Click(object sender, RoutedEventArgs e) => ToppingPick(Pizza1, SizeChoose1, standard, "chili, ", 4, 8, 12, 16);
        #endregion


        #region Choose size of pizza
        private void Alm_Click(object sender, RoutedEventArgs e) => AlmCheck.IsChecked ^= true;

        private void DeepPan_Click(object sender, RoutedEventArgs e) => DeepCheck.IsChecked ^= true;

        private void Fam_Click(object sender, RoutedEventArgs e) => FamCheck.IsChecked ^= true;

        private void Mega_Click(object sender, RoutedEventArgs e) => MegaCheck.IsChecked ^= true;

        #endregion

        #region Drinks
        private void Amount_of_drink_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Amount_of_drink.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Amount_of_drink.Text = Amount_of_drink.Text.Remove(Amount_of_drink.Text.Length - 1);
            }

        }

        private void Lille_Click(object sender, RoutedEventArgs e) => DrinkPick(2 * Convert.ToDouble(Amount_of_drink.Text), 5 * Convert.ToDouble(Amount_of_drink.Text), 6 * Convert.ToDouble(Amount_of_drink.Text), 8 * Convert.ToDouble(Amount_of_drink.Text));
        private void Mellem_Click(object sender, RoutedEventArgs e) => DrinkPick(4 * Convert.ToDouble(Amount_of_drink.Text), 6 * Convert.ToDouble(Amount_of_drink.Text), 7 * Convert.ToDouble(Amount_of_drink.Text), 9 * Convert.ToDouble(Amount_of_drink.Text));
        private void Stor_Click(object sender, RoutedEventArgs e) => DrinkPick(5 * Convert.ToDouble(Amount_of_drink.Text), 6 * Convert.ToDouble(Amount_of_drink.Text), 9 * Convert.ToDouble(Amount_of_drink.Text), 10 * Convert.ToDouble(Amount_of_drink.Text));
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
        public double count = 0;
        public void FullPrice(bool? alm, bool? deep, bool? fam, bool? mega)
        {
            if (alm == true)
                count += standard[0];
            if (deep == true)
                count += standard[1];
            if (fam == true)
                count += standard[2];
            if (mega == true)
                count += standard[3];
        }

        public void Pay_Click(object sender, RoutedEventArgs e)
        {
            if (AlmCheck.IsChecked == true)
                count += lavSelv[0];
            if (DeepCheck.IsChecked == true)
                count += lavSelv[1];
            if (FamCheck.IsChecked == true)
                count += lavSelv[2];
            if (MegaCheck.IsChecked == true)
                count += lavSelv[3];

            FullPrice(AlmCheck_NAPOLI.IsChecked, DeepCheck_NAPOLI.IsChecked, FamCheck_NAPOLI.IsChecked, MegaCheck_NAPOLI.IsChecked);
            FullPrice(AlmCheck_PALERMO.IsChecked, DeepCheck_CATANIA.IsChecked, FamCheck_CATANIA.IsChecked, MegaCheck_CATANIA.IsChecked);
            FullPrice(AlmCheck_CATANIA.IsChecked, DeepCheck_PALERMO.IsChecked, FamCheck_PALERMO.IsChecked, MegaCheck_PALERMO.IsChecked);
            Payhelp(count);
            count = 0;
        }
        #endregion
    }
}
