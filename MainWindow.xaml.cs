using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

using System.Media;
using System.Threading;
using Registro_venta_boleta.UI.Registro;
using Registro_venta_boleta.UI.Consulta;

namespace Registro_venta_boleta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // InitializeComponent();
        }
          private void Button_Click(object sender, RoutedEventArgs e)
        {   

          
         
           Main.Content=new Registro_evento_boleta();


        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content=new Registro_secciones();
            

        }
        

        private void Button2_Click(object sender, RoutedEventArgs e)
        { 

             Main.Content=new cEvento_boleta();
            

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

          

        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {

          

        }
    }
}
