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

namespace Ej2DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operador ;
        int operando1 ;
        int operando2 ;
        int result;
        public MainWindow()
        {
            InitializeComponent();
           

        }

      

        private void resultadoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            result = int.Parse(resultadoTextBox.Text);
            
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            int num;
            operador = operadorTextBox.Text;
            operando1 = Convert.ToInt32(operando1TextBox.Text);
            operando2 = Convert.ToInt32(operando2TextBox.Text);
            bool operando1bool;
            bool operando2bool;
            try
            {
                if (operador == "/")
                {
                    result = operando1 / operando2;
                }

                if (operador == "*")
                {
                    result = operando1 * operando2;
                }

                if (operador == "-")
                {
                    result = operando1 - operando2;
                }

                if (operador == "+")
                {
                    result = operando1 + operando2;
                }

                

            }
            catch
            {
                operando1bool = int.TryParse(operando1TextBox.Text, out num);
                operando2bool = int.TryParse(operando2TextBox.Text, out num);
                if (!operando1bool && !operando2bool)
                {
                    MessageBox.Show("no son numeros");
                }
            }
              
                
        }
        
        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Convert.ToInt32( operadorTextBox.Text = " ");
            Convert.ToInt32( operando1TextBox.Text = " ");
            Convert.ToInt32(operando2TextBox.Text = " ");
            Convert.ToInt32(resultadoTextBox.Text = " ");

            

        }
    }
}
