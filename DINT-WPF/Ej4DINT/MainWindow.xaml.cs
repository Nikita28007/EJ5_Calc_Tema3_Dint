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

namespace Ej4DINT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            caracteresTextBlock.Text = 0 + "/140";
            
        }

        private void textoUserTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          caracteresTextBlock.Text = Convert.ToString(textoUserTextBox.Text.Length) +"/140";
        }
    }
}
