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

namespace FoodDrop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            canvas.Focus();
        }

        private void canvasKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                titulo.Visibility = Visibility.Collapsed;

                menuLabel.Visibility = Visibility.Collapsed;
            }
        }
    }
}
