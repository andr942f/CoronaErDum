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
        private void PandM_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text + "negate(0)";
        #endregion

        #region Remove & clear
        private void CE_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text.Remove(Window.Text.Length - Window.Text.Length);

        private void C_Click(object sender, RoutedEventArgs e) => Window.Text = Window.Text.Remove(Window.Text.Length - Window.Text.Length);
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (Window.Text != "")
                Window.Text = Window.Text.Remove(Window.Text.Length - 1);
        }
        #endregion

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Type id = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic lang = Activator.CreateInstance(id, false);
            lang.Language = "javascript";

            try
            {
                var input = lang.Eval(Window.Text.ToString());
                Window.Text = Window.Text + "=" + input;
            }
            catch (SystemException)
            {
                Window.Text = "Syntax Error";
            }
        }

    }
}
