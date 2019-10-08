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

namespace Proyecto2PJesusGastelum
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            btnGuardar.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            grdProductos.Children.Clear();
            switch (cbCategoria.SelectedIndex)
            {
                case 0:
                    grdProductos.Children.Add(new Carros());
                    break;
                case 1:
                    grdProductos.Children.Add(new Motos());
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }

        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            grdProductos.Children.Clear();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            grdProductos.Children.Clear();
        }

        
    }
}
