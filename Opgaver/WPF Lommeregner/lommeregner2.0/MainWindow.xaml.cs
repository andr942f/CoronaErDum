using System.Windows;

namespace lommeregner2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        string operatorUse = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        public int ButtonInput(int times)
        {
            switch (operatorUse)
            {
                case "":
                    num1 = (num1 * 10) + times;
                    Input.Text = num1.ToString();
                    return times;
                default:
                    num2 = (num2 * 10) + times;
                    Input.Text = num2.ToString();
                    return times;
            }
        }
        #region B0-9
        private void B0_Click(object sender, RoutedEventArgs e) => ButtonInput(0);
        private void B1_Click(object sender, RoutedEventArgs e) => ButtonInput(1);
        private void B2_Click(object sender, RoutedEventArgs e) => ButtonInput(2);
        private void B3_Click(object sender, RoutedEventArgs e) => ButtonInput(3);
        private void B4_Click(object sender, RoutedEventArgs e) => ButtonInput(4);
        private void B5_Click(object sender, RoutedEventArgs e) => ButtonInput(5);
        private void B6_Click(object sender, RoutedEventArgs e) => ButtonInput(6);
        private void B7_Click(object sender, RoutedEventArgs e) => ButtonInput(7);
        private void B8_Click(object sender, RoutedEventArgs e) => ButtonInput(8);
        private void B9_Click(object sender, RoutedEventArgs e) => ButtonInput(9);

        #endregion

        public string OperatorInput(string use)
        {
            operatorUse = use;
            Input.Text = "0";
            return use;
        }
        #region Operator chooser
        private void Plus_Click(object sender, RoutedEventArgs e) => OperatorInput("+");
        private void Minus_Click(object sender, RoutedEventArgs e) => OperatorInput("-");
        private void Multiply_Click(object sender, RoutedEventArgs e) => OperatorInput("*");
        private void Divide_Click(object sender, RoutedEventArgs e) => OperatorInput("/");
        #endregion

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operatorUse)
            {
                case "+":
                    Input.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    Input.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    Input.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    Input.Text = (num1 / num2).ToString();
                    break;
            }
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (operatorUse == "")
                num1 = 0;
            else num2 = 0;
            Input.Text = "0";
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operatorUse = "";
            Input.Text = "0";
        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            switch (operatorUse)
            {
                case "":
                    num1 = (num1 - 1);
                    Input.Text = num1.ToString();
                    break;
                default:
                    num2 = (num2 - 1);
                    Input.Text = num2.ToString();
                    break;
            }
        }
    }
}
