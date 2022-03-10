using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

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

            corriendo = false;

            canvas.Focus();

            mainLoopHandler = new DispatcherTimer();

            mainLoopHandler.Tick += new EventHandler(mainLoop);
        }

        private void canvasKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                if (!corriendo)
                {
                    titulo.Visibility = Visibility.Collapsed;

                    menuLabel.Visibility = Visibility.Collapsed;

                    jugador.Visibility = Visibility.Visible;

                    corriendo = true;

                    mainLoopHandler.Start();

                }
            }
        }

        private void mainLoop(object sender, EventArgs e)
        {
            double inicio = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            procesarInput();

            actualizar();

            renderizar();

            double espera = inicio + 16 - DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            Thread.Sleep((int)espera);
 
        }

        private void procesarInput()
        {

        }

        private void actualizar()
        {

        }

        private void renderizar()
        {
   
            
        }

        private bool corriendo;

        private DispatcherTimer mainLoopHandler;

    }
}
