using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPainter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int diameter = (int) Sizes.MEDIUM;
        private Brush brushColor = Brushes.Black;
        private bool shouldPaint = false;
        private bool shouldErase = false;

        private enum Sizes
        {
            SMALL = 4,
            MEDIUM = 8,
            LARGE = 12
            
        }

        public MainWindow()
        {
            InitializeComponent();
            alphaSlider.Value = 255;
        }

        private void slider_ValueChanged(object sender,
        RoutedPropertyChangedEventArgs<double> e)
        {
            // generates new color
            SolidColorBrush backgroundColor = new SolidColorBrush();
            backgroundColor.Color = Color.FromArgb(
               (byte)alphaSlider.Value, (byte)redSlider.Value,
               (byte)greenSlider.Value, (byte)blueSlider.Value);

            // set colorLabel's background to new color
            colorLabel.Background = backgroundColor;
            brushColor = backgroundColor;
        }
      
        private void PaintCircle(Brush circleColor, Point position)
        {
            Ellipse newEllipse = new Ellipse();

            newEllipse.Fill = circleColor;
            newEllipse.Width = diameter;
            newEllipse.Height = diameter;
           
            Canvas.SetTop(newEllipse, position.Y);
            Canvas.SetLeft(newEllipse, position.X);
            paintCanvas.Children.Add(newEllipse);
        }

        private void smallRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            diameter = (int) Sizes.SMALL;
        }

        private void mediumRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            diameter = (int)Sizes.MEDIUM;
        }

        private void largeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            diameter = (int) Sizes.LARGE;
        }

        private void paintCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            shouldPaint = true;
        }

        private void paintCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shouldPaint = false;
        }

        private void paintCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            shouldErase = true;
        }

        private void paintCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            shouldErase = false;
        }

        private void paintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(brushColor, mousePosition);
            }
            else if (shouldErase)
            {
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(paintCanvas.Background, mousePosition);
            }
        }

        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            int count = paintCanvas.Children.Count;

            if (count > 0)
                paintCanvas.Children.RemoveAt(count - 1);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            paintCanvas.Children.Clear();
        }

    }
}
