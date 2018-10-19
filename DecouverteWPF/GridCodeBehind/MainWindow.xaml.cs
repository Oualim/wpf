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

namespace GridCodeBehind
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // partie back (behind) 

            InitializeComponent();

            var _texBlock = new TextBlock() //creation d'une ligne
            {
                Text = "Test Commentaire"
            };

            var _grid = new Grid(); //creation d'un tableau


            RowDefinition _GridRow = new RowDefinition();
            _GridRow.Height = new GridLength(10.0, GridUnitType.Star);
            _grid.RowDefinitions.Add(_GridRow);


            RowDefinition _GridRow2 = new RowDefinition();
            _GridRow2.Height = new GridLength(10.0, GridUnitType.Star);
            _grid.RowDefinitions.Add(_GridRow2);

            RowDefinition _GridRow3 = new RowDefinition();
            _GridRow3.Height = new GridLength(17.0, GridUnitType.Star);
            _grid.RowDefinitions.Add(_GridRow3);

            Grid.SetRow(_texBlock, 0); //souhait d'ajouter dans la ligne 1

            _grid.Children.Add(_texBlock); //execute la demande d'ajout

            this.Content = _grid; // affiche
        }
    }
}
