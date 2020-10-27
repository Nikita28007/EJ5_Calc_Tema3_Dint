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

namespace EJ1DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num;
        public MainWindow()
        {
            num = numGenerado();
            InitializeComponent();
        }

        private int numGenerado()
        {
            
            Random numAleatorio = new Random();
            return numAleatorio.Next(0, 101);
            
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(textoTextBox.Text) == num)
            {
                mostrarTextBloc.Text = "has acertado!";
            }
            else if ((int.Parse(textoTextBox.Text) <= num))  
            {
                mostrarTextBloc.Text = "has quedado corto";
            }
            else if ((int.Parse(textoTextBox.Text) >= num))
            {
                mostrarTextBloc.Text = "has sobrepasado";
            }
            else
            {
                mostrarTextBloc.Text = "no es un numero";
            } 
        }


        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {

            textoTextBox.Text = "";
            numGenerado();
        }
    }
}
