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

namespace SomeAnimations
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void btnMarquee_Click(object sender, RoutedEventArgs e)
        {
            Marquee marquee = new Marquee();
            marquee.ShowDialog();

        }

 

        private void btnRollAnimation_Click(object sender, RoutedEventArgs e)
        {
            RollAnimation rollAnimation = new RollAnimation();
            rollAnimation.ShowDialog();
        }

        private void btnDripAnimation_Click(object sender, RoutedEventArgs e)
        {
            DripAnimation dripAnimation = new DripAnimation();
            dripAnimation.ShowDialog();
        }

        private void btnCameraAnimation_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
