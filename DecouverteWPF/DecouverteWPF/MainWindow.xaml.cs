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

namespace DecouverteWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // partie back
        public MainWindow()
        {
            InitializeComponent();

            this.firstTextB.Text = "totototo";

            LinearGradientBrush pinceau = new LinearGradientBrush();

            GradientStop stop1 = new GradientStop();
            stop1.Offset = 0;
            stop1.Color = Colors.Blue;
            pinceau.GradientStops.Add(stop1);

            GradientStop stop2 = new GradientStop();
            stop2.Offset = 0.3;
            stop2.Color = Colors.CadetBlue;
            pinceau.GradientStops.Add(stop2);

            GradientStop stop3 = new GradientStop();
            stop3.Offset = 1;
            stop3.Color = Colors.Green;
            pinceau.GradientStops.Add(stop3);

            this.firstTextB.Foreground = pinceau;


        }




    }
}
