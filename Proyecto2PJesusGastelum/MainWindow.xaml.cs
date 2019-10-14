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
            grdProductos.Children.Clear();
            switch (cbCategoria.SelectedIndex)
            {
                case 0:
                    grdProductos.Children.Add(new Piano());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 1:
                    grdProductos.Children.Add(new GuitarraElectrica());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 2:
                    grdProductos.Children.Add(new Bateria());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 3:
                    grdProductos.Children.Add(new Bajo());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 4:
                    grdProductos.Children.Add(new Maracas());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 5:
                    grdProductos.Children.Add(new Violin());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }

        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            switch (cbCategoria.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrEmpty(((Piano)grdProductos.Children[0]).txtMarca.Text) ||
                        string.IsNullOrEmpty(((Piano)grdProductos.Children[0]).txtModelo.Text) ||
                        string.IsNullOrEmpty(((Piano)grdProductos.Children[0]).txtColor.Text) ||
                        string.IsNullOrEmpty(((Piano)grdProductos.Children[0]).txtPrecio.Text) ||
                        string.IsNullOrEmpty(((Piano)grdProductos.Children[0]).txtEnvio.Text) ||
                        ((Piano)grdProductos.Children[0]).cbEstado.SelectedIndex == 0 || (
                        ((Piano)grdProductos.Children[0]).chxRobo.IsChecked == false &&
                        ((Piano)grdProductos.Children[0]).chxGolpes.IsChecked == false &&
                        ((Piano)grdProductos.Children[0]).chxExtravio.IsChecked == false &&
                        ((Piano)grdProductos.Children[0]).chxIncendio.IsChecked == false) || (
                        ((Piano)grdProductos.Children[0]).rbtn12.IsChecked == false &&
                        ((Piano)grdProductos.Children[0]).rbtn24.IsChecked == false &&
                        ((Piano)grdProductos.Children[0]).rbtn36.IsChecked == false)
                        )
                    {
                        MessageBox.Show("Es necesario que se llenen todos los datos obligatorios.");
                    }

                    else
                    {
                        MessageBox.Show("Se guardo correctamente.");
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdProductos.Children.Clear();
                    }
                    break;

                case 1:
                    if (string.IsNullOrEmpty(((GuitarraElectrica)(grdProductos.Children[0])).txtMarca.Text) ||
                        string.IsNullOrEmpty(((GuitarraElectrica)grdProductos.Children[0]).txtModelo.Text) ||
                        string.IsNullOrEmpty(((GuitarraElectrica)grdProductos.Children[0]).txtColor.Text) ||
                        string.IsNullOrEmpty(((GuitarraElectrica)grdProductos.Children[0]).txtPrecio.Text) ||
                        string.IsNullOrEmpty(((GuitarraElectrica)grdProductos.Children[0]).txtEnvio.Text) ||
                        ((GuitarraElectrica)grdProductos.Children[0]).cbEstado.SelectedIndex == 0 || (
                        ((GuitarraElectrica)grdProductos.Children[0]).chxRobo.IsChecked == false &&
                        ((GuitarraElectrica)grdProductos.Children[0]).chxGolpes.IsChecked == false &&
                        ((GuitarraElectrica)grdProductos.Children[0]).chxExtravio.IsChecked == false &&
                        ((GuitarraElectrica)grdProductos.Children[0]).chxIncendio.IsChecked == false) || (
                        ((GuitarraElectrica)grdProductos.Children[0]).rbtn12.IsChecked == false &&
                        ((GuitarraElectrica)grdProductos.Children[0]).rbtn24.IsChecked == false &&
                        ((GuitarraElectrica)grdProductos.Children[0]).rbtn36.IsChecked == false)
                        )
                    {
                        MessageBox.Show("Es necesario que se llenen todos los datos obligatorios.");
                    }

                    else
                    {
                        MessageBox.Show("Se guardo correctamente.");
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdProductos.Children.Clear();
                    }
                    break;

                case 2:
                    if (string.IsNullOrEmpty(((Bateria)(grdProductos.Children[0])).txtMarca.Text) ||
                        string.IsNullOrEmpty(((Bateria)grdProductos.Children[0]).txtModelo.Text) ||
                        string.IsNullOrEmpty(((Bateria)grdProductos.Children[0]).txtColor.Text) ||
                        string.IsNullOrEmpty(((Bateria)grdProductos.Children[0]).txtPrecio.Text) ||
                        string.IsNullOrEmpty(((Bateria)grdProductos.Children[0]).txtEnvio.Text) ||
                        ((Bateria)grdProductos.Children[0]).cbEstado.SelectedIndex == 0 || (
                        ((Bateria)grdProductos.Children[0]).chxRobo.IsChecked == false &&
                        ((Bateria)grdProductos.Children[0]).chxGolpes.IsChecked == false &&
                        ((Bateria)grdProductos.Children[0]).chxExtravio.IsChecked == false &&
                        ((Bateria)grdProductos.Children[0]).chxIncendio.IsChecked == false) || (
                        ((Bateria)grdProductos.Children[0]).rbtn12.IsChecked == false &&
                        ((Bateria)grdProductos.Children[0]).rbtn24.IsChecked == false &&
                        ((Bateria)grdProductos.Children[0]).rbtn36.IsChecked == false)
                        )
                    {
                        MessageBox.Show("Es necesario que se llenen todos los datos obligatorios.");
                    }

                    else
                    {
                        MessageBox.Show("Se guardo correctamente.");
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdProductos.Children.Clear();
                    }
                    break;

                case 3:
                    if (string.IsNullOrEmpty(((Bajo)(grdProductos.Children[0])).txtMarca.Text) ||
                        string.IsNullOrEmpty(((Bajo)grdProductos.Children[0]).txtModelo.Text) ||
                        string.IsNullOrEmpty(((Bajo)grdProductos.Children[0]).txtColor.Text) ||
                        string.IsNullOrEmpty(((Bajo)grdProductos.Children[0]).txtPrecio.Text) ||
                        string.IsNullOrEmpty(((Bajo)grdProductos.Children[0]).txtEnvio.Text) ||
                        ((Bajo)grdProductos.Children[0]).cbEstado.SelectedIndex == 0 || (
                        ((Bajo)grdProductos.Children[0]).chxRobo.IsChecked == false &&
                        ((Bajo)grdProductos.Children[0]).chxGolpes.IsChecked == false &&
                        ((Bajo)grdProductos.Children[0]).chxExtravio.IsChecked == false &&
                        ((Bajo)grdProductos.Children[0]).chxIncendio.IsChecked == false) || (
                        ((Bajo)grdProductos.Children[0]).rbtn12.IsChecked == false &&
                        ((Bajo)grdProductos.Children[0]).rbtn24.IsChecked == false &&
                        ((Bajo)grdProductos.Children[0]).rbtn36.IsChecked == false)
                        )
                    {
                        MessageBox.Show("Es necesario que se llenen todos los datos obligatorios.");
                    }

                    else
                    {
                        MessageBox.Show("Se guardo correctamente.");
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdProductos.Children.Clear();
                    }
                    break;

                case 4:
                    if (string.IsNullOrEmpty(((Maracas)(grdProductos.Children[0])).txtMarca.Text) ||
                        string.IsNullOrEmpty(((Maracas)grdProductos.Children[0]).txtModelo.Text) ||
                        string.IsNullOrEmpty(((Maracas)grdProductos.Children[0]).txtColor.Text) ||
                        string.IsNullOrEmpty(((Maracas)grdProductos.Children[0]).txtPrecio.Text) ||
                        string.IsNullOrEmpty(((Maracas)grdProductos.Children[0]).txtEnvio.Text) ||
                        ((Maracas)grdProductos.Children[0]).cbEstado.SelectedIndex == 0 || (
                        ((Maracas)grdProductos.Children[0]).chxRobo.IsChecked == false &&
                        ((Maracas)grdProductos.Children[0]).chxGolpes.IsChecked == false &&
                        ((Maracas)grdProductos.Children[0]).chxExtravio.IsChecked == false &&
                        ((Maracas)grdProductos.Children[0]).chxIncendio.IsChecked == false) || (
                        ((Maracas)grdProductos.Children[0]).rbtn12.IsChecked == false &&
                        ((Maracas)grdProductos.Children[0]).rbtn24.IsChecked == false &&
                        ((Maracas)grdProductos.Children[0]).rbtn36.IsChecked == false)
                        )
                    {
                        MessageBox.Show("Es necesario que se llenen todos los datos obligatorios.");
                    }

                    else
                    {
                        MessageBox.Show("Se guardo correctamente.");
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdProductos.Children.Clear();
                    }
                    break;

                case 5:
                    if (string.IsNullOrEmpty(((Violin)(grdProductos.Children[0])).txtMarca.Text) ||
                       string.IsNullOrEmpty(((Violin)grdProductos.Children[0]).txtModelo.Text) ||
                       string.IsNullOrEmpty(((Violin)grdProductos.Children[0]).txtColor.Text) ||
                       string.IsNullOrEmpty(((Violin)grdProductos.Children[0]).txtPrecio.Text) ||
                       string.IsNullOrEmpty(((Violin)grdProductos.Children[0]).txtEnvio.Text) ||
                       ((Violin)grdProductos.Children[0]).cbEstado.SelectedIndex == 0 || (
                       ((Violin)grdProductos.Children[0]).chxRobo.IsChecked == false &&
                       ((Violin)grdProductos.Children[0]).chxGolpes.IsChecked == false &&
                       ((Violin)grdProductos.Children[0]).chxExtravio.IsChecked == false &&
                       ((Violin)grdProductos.Children[0]).chxIncendio.IsChecked == false) || (
                       ((Violin)grdProductos.Children[0]).rbtn12.IsChecked == false &&
                       ((Violin)grdProductos.Children[0]).rbtn24.IsChecked == false &&
                       ((Violin)grdProductos.Children[0]).rbtn36.IsChecked == false)
                       )
                    {
                        MessageBox.Show("Es necesario que se llenen todos los datos obligatorios.");
                    }

                    else
                    {
                        MessageBox.Show("Se guardo correctamente.");
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        grdProductos.Children.Clear();
                    }
                    break;

                default:
                    break;
            }
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            grdProductos.Children.Clear();
        }

        
    }
}
