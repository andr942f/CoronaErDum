using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace lommeregner2._0
{
    public partial class Draw : MainWindow
    {
        public void Firkant()
        {
            try
            {
                Can.Children.Clear();

                string[] text = Window.Text.Split('*');

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
                Window.Text = "Syntax error";
            }
        }

        public void Cirkel()
        {
            try
            {
                Can.Children.Clear();

                string[] text = Window.Text.Split('*');

                Rectangle rectangle = new Rectangle
                {
                    Stroke = Brushes.White,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Height = int.Parse(text[0]),
                    Width = int.Parse(text[0])

                };

                Can.Children.Add(rectangle);

            }
            catch
            {
                Window.Text = "Syntax error";
            }
        }

        public void Trapez()
        {
            try
            {
                Can.Children.Clear();

                string[] text = Window.Text.Split('(', ')', '*', '+');


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
                Window.Text = "Syntax error";
            }
        }
    }
}
