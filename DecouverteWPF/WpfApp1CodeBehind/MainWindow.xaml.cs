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

namespace WpfApp1CodeBehind
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Cette partie n'a pas besoin de code xaml (partie front)

        public MainWindow()
        {
            InitializeComponent();

            LinearGradientBrush brush = new LinearGradientBrush();
            GradientStopCollection mesStopDeGradient = new GradientStopCollection
               {
                   new GradientStop(Colors.Orange, 0.5),
                   new GradientStop(Colors.HotPink, 1)
               };
            brush.GradientStops = mesStopDeGradient;

            TextBlock monTexte = new TextBlock
            {
                Text = "Affichage de text à partir de code C#",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = brush
            };

            var _grid = new Grid();
            _grid.Children.Add(monTexte);

            this.Content = _grid;

        }
    }
}
}
