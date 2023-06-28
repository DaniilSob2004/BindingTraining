using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace BindingTraining
{
    public partial class MainWindow : Window
    {
        private bool isClick = false;
        private Point oldPoint, newPoint;
        private double currentX, currentY;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            oldPoint = e.GetPosition(this);
            isClick = true;
            rec.CaptureMouse();
        }

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isClick = false;
            rec.ReleaseMouseCapture();
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                newPoint = e.GetPosition(this);

                currentX = Double.Parse(textX.Text) + (newPoint.X - oldPoint.X);
                currentY = Double.Parse(textY.Text) + (newPoint.Y - oldPoint.Y);

                textX.Text = currentX.ToString();
                textY.Text = currentY.ToString();

                oldPoint = newPoint;
            }
        }
    }
}
