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

namespace Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Nbase, Nexponente;
       int resultado;
        public MainWindow()
        {
            InitializeComponent();
        }

          private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
           Nbase = int.Parse(txtBase.Text);

           Nexponente = int.Parse(txtExponente.Text);

           int resultado=1;

          for(int i=0; i<Nexponente; i++)
          {

              resultado=resultado*Nbase;

          }

             Resultado.Items.Add(resultado);


        }

        private void ButtonClick_Limpiar(object sender, RoutedEventArgs e)
        {
            this.txtBase.Text = string.Empty;

            this.txtExponente.Text = string.Empty;
            

            this.Resultado.Items.Clear();


        }

    }
}
