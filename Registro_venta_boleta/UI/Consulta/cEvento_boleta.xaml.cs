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
using System.Windows.Threading;
using System.Text.Json;
using System.Net.Http.Json;
using Newtonsoft.Json;
using  System.Net.Http;
using Registro_venta_boleta.Entidades;
using Registro_venta_boleta.UI.Registro;
using System.Text.RegularExpressions;
namespace Registro_venta_boleta.UI.Consulta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class cEvento_boleta : Page
    {
        public cEvento_boleta()
        {
            this.InitializeComponent();
            GeT();
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hubo un problema"," Exito", MessageBoxButton.OK, MessageBoxImage.Information);
          GeTid();
        }
         public async Task GeT()
        {
            var url ="http://127.0.0.1:8000/apiApp/v1/Eventos/";
            JsonSerializerOptions options = new JsonSerializerOptions() {PropertyNameCaseInsensitive=true};
            using(var httpClient = new HttpClient())
            {

                 var reponse=await httpClient.GetAsync(url);
                if(reponse.IsSuccessStatusCode){
                    var content=await reponse.Content.ReadAsByteArrayAsync();
                    var datos = System.Text.Json.JsonSerializer.Deserialize<List<Eventos>>(content,options);
                     TablaTexto.ItemsSource = null;
                     TablaTexto.ItemsSource = datos;
                    
                }else{

                  
                     MessageBox.Show("Hubo un problema"," Exito", MessageBoxButton.OK, MessageBoxImage.Information);
               }

            }
        }
        public async Task GeTid()
        {
            var url ="http://127.0.0.1:8000/apiApp/v1/Eventos/"+IdTextBox.Text+"/";
            JsonSerializerOptions options = new JsonSerializerOptions() {PropertyNameCaseInsensitive=true};
            using(var httpClient = new HttpClient())
            {

             
                    var reponse=await httpClient.GetAsync(url);
                    if(reponse.IsSuccessStatusCode){
                    var content=await reponse.Content.ReadAsByteArrayAsync();
                    string cadena = Encoding.UTF8.GetString(content);
                    var emloyeess = System.Text.Json.JsonSerializer.Deserialize<Eventos>(cadena);
                     List<Eventos> guarda=new List<Eventos>();
                     guarda.Add(emloyeess);
                      TablaTexto.ItemsSource = null;
                     TablaTexto.ItemsSource =guarda;
                     
                   
                
                }
            }
        }
        

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            
           
        }
         private void Ver_Click(object sender, RoutedEventArgs e)
        {
            Eventos boletas = (Eventos)TablaTexto.SelectedItem;  
           Registro_evento_boleta rarticulos =new Registro_evento_boleta(Convert.ToInt32(boletas.id));
          

           NavigationService.Navigate(rarticulos);
              
        
        }
        private void Ververeliminar_Click(object sender, RoutedEventArgs e)
        {
          
              Geteliminar();
        
        }
        public async Task Geteliminar()
        {
            
         Eventos boletas = (Eventos)TablaTexto.SelectedItem;  
            var url ="http://127.0.0.1:8000/apiApp/v1/Eventos/"+boletas.id+"/";
            JsonSerializerOptions options = new JsonSerializerOptions() {PropertyNameCaseInsensitive=true};
            using(var httpClient = new HttpClient())
            {

             
              
                
                var reponse=await httpClient.DeleteAsync(url);
                 if(reponse.IsSuccessStatusCode){
                    Console.WriteLine("Fue un exito");

                }else{
                    Console.WriteLine("Hubo un problema");
                }
            }
            GeT();
        }
        private void TablaTexto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             

        }
    }
}