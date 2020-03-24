using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace lommeregner2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Video brugt som udgangspunkt, har kørt det igennem op til flere gange og har modtaget en forståelse for hvordan det virker: https://www.youtube.com/watch?v=eSrsXt5bP50
        public MainWindow() => InitializeComponent();
        public void Write(string add) => Query.Text += add;
       
        #region B0-9
        private void B0_Click(object sender, RoutedEventArgs e) => Write("0");
        private void B1_Click(object sender, RoutedEventArgs e) => Write("1");
        private void B2_Click(object sender, RoutedEventArgs e) => Write("2");
        private void B3_Click(object sender, RoutedEventArgs e) => Write("3");
        private void B4_Click(object sender, RoutedEventArgs e) => Write("4");
        private void B5_Click(object sender, RoutedEventArgs e) => Write("5");
        private void B6_Click(object sender, RoutedEventArgs e) => Write("6");
        private void B7_Click(object sender, RoutedEventArgs e) => Write("7");
        private void B8_Click(object sender, RoutedEventArgs e) => Write("8");
        private void B9_Click(object sender, RoutedEventArgs e) => Write("9");
        #endregion
        // When clicked, add one of the following (depending on what is clicked) add to textbox
      
        #region Operator chooser
        private void Plus_Click(object sender, RoutedEventArgs e) => Write("+");
        private void Minus_Click(object sender, RoutedEventArgs e) => Write("-");
        private void Multiply_Click(object sender, RoutedEventArgs e) => Write("*");
        private void Divide_Click(object sender, RoutedEventArgs e) => Write("/");
        private void Dot_Click(object sender, RoutedEventArgs e) => Write(".");
        private void Para_Click(object sender, RoutedEventArgs e) => Write("()");
        private void PI_Click(object sender, RoutedEventArgs e) => Write("3.14");
        #endregion
        
        #region Circumference
            /// <summary>
            /// When clicked, make a cricle using the following 
            /// <para> equation: r * r * 3.14 </para>
            /// </summary>
            private void Circle_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    Can.Children.Clear();

                    string[] text = Query.Text.Split('*');

                    Ellipse ellipse = new Ellipse
                    {
                        Stroke = Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Height = int.Parse(text[0] + text[1]),
                        Width = int.Parse(text[0] + text[1])
                    };

                    Can.Children.Add(ellipse);
                }
                catch
                {
                    Query.Text = "Syntax error";
                }
            }


            /// <summary>
            /// When clicked, make a cricle using the following 
            /// <para> equation: l * b </para>
            /// </summary>
            private void Square_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    Can.Children.Clear();

                    string[] text = Query.Text.Split('*');

                    Rectangle rectangle = new Rectangle
                    {
                        Stroke = Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Height = int.Parse(text[0]),
                        Width = int.Parse(text[1])

                    };

                    Can.Children.Add(rectangle);

                }
                catch
                {
                    Query.Text = "Syntax error";
                }
            }


            /// <summary>
            /// When clicked, make a cricle using the following 
            /// <para> equation: (a + c) * h * 0.5  </para>
            /// <para> WIP</para>
            /// </summary>
            private void Trapezoid_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    Can.Children.Clear();

                    string[] text = Query.Text.Split('(', ')', '*', '+');


                    PointCollection points = new PointCollection();
                    points.Add(new Point(0, 0));
                    points.Add(new Point(int.Parse(text[1]), 0));
                    points.Add(new Point(int.Parse(text[2]), int.Parse(text[4])));
                    points.Add(new Point(0.50 * int.Parse(text[4]), int.Parse(text[4])));

                    Polygon polygon = new Polygon
                    {
                        Stroke = Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Points = points,
                    };

                    Can.Children.Add(polygon);
                }
                catch
                {
                    Query.Text = "Syntax error";
                }
            }


        /// <summary>
        /// When clicked, make a cricle using the following 
        /// <para> equation: h * r * r * 3.14 / 3  </para>
        /// <para> WIP  </para>
        /// </summary>
        private void Cone_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    Can.Children.Clear();

                    string[] text = Query.Text.Split('*', '/', ' ');
                    int h = int.Parse(text[0]);
                    int r = int.Parse(text[1] + text[2]);

                    Rectangle rectangle = new Rectangle
                    {
                        Stroke = Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Bottom,
                        Height = h,
                        Width = r
                    };

                    Ellipse ellipse = new Ellipse
                    {
                        Stroke = Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center,
                        Height = 10,
                        Width = r
                    };


                    Can.Children.Add(ellipse);
                    Can.Children.Add(rectangle);
                }
                catch
                {
                    Query.Text = "Syntax error";
                }
            }
        #endregion
       
        #region Delete stuff
            /// <summary>
            /// When clicked, Clear Entry 
            /// <para>Not the best solution, but it works (sort of)</para>
            /// </summary>
            private void CE_Click(object sender, RoutedEventArgs e)
            {
                Can.Children.Clear();
                string ce = Query.Text.TrimEnd('*', '/', '+', '-');
                if (Query.Text.Length != 1)
                    Query.Text = Query.Text.Remove(Query.Text.LastIndexOf(ce) + 1);

            }


            /// <summary>
            /// When clicked, Clear Equation
            /// </summary>
            private void C_Click(object sender, RoutedEventArgs e)
            {
                Can.Children.Clear();
                Query.Text = "";
                LastQuery.Text = "";
            }


            /// <summary>
            /// When clicked, remove 1 from length
            /// </summary>
            private void Backspace_Click(object sender, RoutedEventArgs e)
            {
                if (Query.Text != "")
                    Query.Text = Query.Text.Remove(Query.Text.Length - 1);
            }
        #endregion
       
        /// <summary> Equals all numbers together
        /// <para> When clicked, calculate everything in the text window and write the result in the field above</para>
        /// </summary>
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
                Can.Children.Clear();
                var input = lang.Eval(Query.Text.ToString());
                LastQuery.Text = $"{Query.Text} =";
                Query.Text = $"{input}";
            }
            catch (SystemException)
            {
                Query.Text = "Syntax Error";
            }
        }

    }
}
