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
using System.Windows.Shapes;
using TpImgLgn.ViewModel;

namespace TpImgLgn
{
    /// <summary>
    /// Logique d'interaction pour MVVMWindow.xaml
    /// </summary>
    public partial class MVVMWindow : Window
    {
        public MVVMWindow()
        {
            InitializeComponent();
            this.DataContext = new PersonneViewModel(); //ce lien cree la liasison entre notre View et le ViewModel
        }

        

    }
}
