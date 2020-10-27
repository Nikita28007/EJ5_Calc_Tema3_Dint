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

namespace EJ5DINT
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

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            verTextoLabel.Content = textoTextBox.Text;
            
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            verTextoLabel.FontWeight = FontWeights.Bold ;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            verTextoLabel.FontStyle = FontStyles.Italic;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton boton = sender as RadioButton;
            if (boton.Tag.Equals("1"))
            {
                verTextoLabel.Foreground = Brushes.Blue;
            }
            else if (boton.Tag.Equals("2"))
            {
                verTextoLabel.Foreground = Brushes.Green;
            }
            else if (boton.Tag.Equals("3"))
            {
                verTextoLabel.Foreground = Brushes.Red;
            }
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            verTextoLabel.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            verTextoLabel.FontStyle = FontStyles.Normal;
        }

        
    }
}
