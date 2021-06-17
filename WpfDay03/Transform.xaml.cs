using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDay01
{
    /// <summary>
    /// Interaction logic for Transform.xaml
    /// </summary>
    public partial class Transform : Window
    {
        public Transform()
        {
            InitializeComponent();
        }

        private void Rect_MouseEnter(object sender, MouseEventArgs e)
        {
            //1
            DoubleAnimation Animation1 = new DoubleAnimation();

            //2
            Animation1.From = 50;
            Animation1.To = this.Width-200;
            Animation1.Duration = TimeSpan.FromSeconds(3);
            Animation1.AutoReverse = true;
            Animation1.RepeatBehavior = RepeatBehavior.Forever;
           
           
            //3
            // Rect.BeginAnimation(Rectangle.WidthProperty, Animation1);
            //  Rect.BeginAnimation(Rectangle.HeightProperty, Animation1);


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation Animation1 = new DoubleAnimation();

            //2
            Animation1.From = 50;
            Animation1.To = this.Width - 200;
            Animation1.Duration = TimeSpan.FromSeconds(3);
            Animation1.AutoReverse = true;
            Animation1.RepeatBehavior = RepeatBehavior.Forever;

            //3
         //   Rect.BeginAnimation(Rectangle.WidthProperty, Animation1);
            Animation1.To = this.Height- 200;
         //   Rect.BeginAnimation(Rectangle.HeightProperty, Animation1);

        }
    }
}
