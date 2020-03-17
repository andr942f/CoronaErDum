using System;
using System.Windows;

namespace lommeregner2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Video brugt som referance, har kørt det igennem op til flere gange og har modtaget en forståelse for hvordan det virker: https://www.youtube.com/watch?v=eSrsXt5bP50
        public MainWindow()
        {
            InitializeComponent();
        }
        #region B0-9
        private void B0_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "0";
        private void B1_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "1";
        private void B2_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "2";
        private void B3_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "3";
        private void B4_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "4";
        private void B5_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "5";
        private void B6_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "6";
        private void B7_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "7";
        private void B8_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "8";
        private void B9_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "9";

        #endregion

        #region Operator chooser
        private void Plus_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "+";
        private void Minus_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "-";
        private void Multiply_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "*";
        private void Divide_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "/";
        private void Dot_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + ".";
        private void para_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "()";
        private void PI_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "3.14";

        #region circumference
        private void Circle_Click(object sender, RoutedEventArgs e) => Window.Text = "r * r * 3.14";

        private void Square_Click(object sender, RoutedEventArgs e) => Window.Text = "l * b";

        private void Trapezoid_Click(object sender, RoutedEventArgs e) => Window.Text = "0.5 * (a + c) * h";

        private void Cone_Click(object sender, RoutedEventArgs e) => Window.Text = "h * r * r * 3.14 / 3";
        #endregion
        #endregion


        #region Remove & clear
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            Window.Text = "";
            LastQuery.Text = "";
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            Window.Text = "";
            LastQuery.Text = "";
        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (Window.Text != "")
                Window.Text = Window.Text.Remove(Window.Text.Length - 1);
        }
        #endregion

        /// <summary> Equals all numbers together
        /// <param> When clicked, calculate everything in the text window and write the result in the field above</param>
        /// </summary>
        /// <param name="sender">Ignore</param>
        /// <param name="e">Ignore</param>
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            // Call the "Eval" function from inside javascript using the Guid [0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC]
            Type id = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic lang = Activator.CreateInstance(id, false);
            lang.Language = "javascript";
            //end

            try
            {
                //"Eval" function being used
                //val a = eval("10 * 20") + <br>; = 200
                //val b = eval("2 + 2") + <br>; = 4
                // val c = eval("10 + 17") + <br>; = 27
                var input = lang.Eval(Window.Text.ToString());
                LastQuery.Text = Window.Text;
                Window.Text = $"{input}";
            }
            catch (SystemException)
            {
                Window.Text = "Syntax Error";
            }
        }
    }
}
