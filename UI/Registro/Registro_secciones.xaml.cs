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
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Net.Http.Json;
using Newtonsoft.Json;
using  System.Net.Http;
using Registro_venta_boleta.Entidades;
namespace Registro_venta_boleta.UI.Registro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registro_secciones : Page
    {

           public List<string> Tipo=new List<string>();
           public Eventos eventos = new Eventos();
        
        public Registro_secciones()
        {
            Tipo.Add("VIP");
            Tipo.Add("Popular");
            this.InitializeComponent();
             ComboBoxTipo.ItemsSource=Tipo;
            GeT();
        }
        
        private void ComboBoxEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ComboxBoxTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        public async Task GeTid(int id)
        {
            var url ="http://127.0.0.1:8000/apiApp/v1/Eventos/"+id+"/";
            JsonSerializerOptions options = new JsonSerializerOptions() {PropertyNameCaseInsensitive=true};
            using(var httpClient = new HttpClient())
            {

             
                    var reponse=await httpClient.GetAsync(url);
                    if(reponse.IsSuccessStatusCode){
                    var content=await reponse.Content.ReadAsByteArrayAsync();
                    string cadena = Encoding.UTF8.GetString(content);
                    //var datos = System.Text.Json.JsonSerializer.Deserialize<Eventos>(cadena);
                
                     
                    
                     
                    //  guarda.Add(emloyeess);
                    //   TablaTexto.ItemsSource = null;
                    //  TablaTexto.ItemsSource =guarda;
                     
                   
                
                }
            }
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

                 
                            ComboBoxEvento.ItemsSource=datos;
                             ComboBoxEvento.SelectedValuePath = "id";
                            ComboBoxEvento.DisplayMemberPath = "Nombre";
                        
                       
                    
                    
                }else{

                  
                     MessageBox.Show("Hubo un problema"," Exito", MessageBoxButton.OK, MessageBoxImage.Information);
               }

            }
        }
         private void Cargar()
        {
           
           
        }


     
        
        
         public void Nuevo_Click(object sender, RoutedEventArgs e)
        {

            
           
        }
           private void TablaDetalle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
              
                           

        }
      
        public string pp;

        public void Guardar_Click(object sender, RoutedEventArgs e)
        {
           
            Post();
        }
        public async Task Post()
        {
            int m=0;
            foreach(var item in eventos.seccionesdetalle)
            {
                Console.WriteLine("hola  ",item.Tipo);
               
               for(int i=0; i<item.Cantidad; i++){

                    var url ="http://127.0.0.1:8000/apiApp/v1/Secciones/";
                    JsonSerializerOptions options = new JsonSerializerOptions() {PropertyNameCaseInsensitive=true};
                    using(var httpClient = new HttpClient())
                    {
                    
                        var Content= new StringContent(JsonConvert.SerializeObject(new SeccionesAuxiliar{IdEvento=item.IdEvento,Tipo=item.Tipo,Is_active= false,Secciones=i.ToString()+"R"}),Encoding.UTF8,"application/Json");
                    
                        var reponse=await httpClient.PostAsync(url,Content);
                        if(!reponse.IsSuccessStatusCode){
                        
                        MessageBox.Show("Hubo un problema"," Error", MessageBoxButton.OK, MessageBoxImage.Information);
                        }else{
                            m=1;
                        }
                            
                    }
               }

            }
            if(m==1){
            MessageBox.Show("Se guardo corretamente"," Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }         
        }

         public void Agregar_Click(object sender, RoutedEventArgs e)
        {
            
             
              
              eventos.seccionesdetalle.Add(new Secciones((int)ComboBoxEvento.SelectedValue,(string)ComboBoxTipo.SelectedValue,int.Parse(TexBoxcantidad.Text),"5R"));                    
            TablaDetalle.ItemsSource=null;
            TablaDetalle.ItemsSource=eventos.seccionesdetalle;

           
    

        }

        public void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            
            //  VerDatos.Visibility = Visibility.Hidden;
           
        }
        
        private void Ver_Click(object sender, RoutedEventArgs e)
        {

    
            if(TablaDetalle.Items.Count >= 1 && TablaDetalle.SelectedIndex <= TablaDetalle.Items.Count)
            {
                        
                eventos.seccionesdetalle.RemoveAt(TablaDetalle.SelectedIndex);
                 TablaDetalle.ItemsSource=null;
                TablaDetalle.ItemsSource= eventos.seccionesdetalle;
                
            }
            
        
        }

        // public  bool validar()
        // {
        //     string mensaje="";
        //     bool m =true;

        //     if(string.IsNullOrEmpty(TexBoxNombrecliente.Text) && string.IsNullOrEmpty(TexBoxDireccion.Text) &&
        //       (string.IsNullOrEmpty(TexBoxTelefono.Text)|| Convert.ToInt64(TexBoxTelefono.Text)==0))
        //     {
        //           m=false;
        //           MessageBox.Show("Por favor llenar todo los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //            TexBoxNombrecliente.Focus();

        //     }else{
                   
        //            if((string.IsNullOrEmpty(TexBoxTelefono.Text)|| Convert.ToInt64(TexBoxTelefono.Text)==0))
        //             {
                       
        //                 mensaje+=" El telefono esta vacio";
        //                 m=false;
        //                 TexBoxTelefono.Focus();
                
        //             }else
        //             {
        //                 if(!Regex.IsMatch( TexBoxTelefono.Text, @"^[0-9]+$"))
        //                 {

        //                     mensaje+=" La existencia solo permite numero";
        //                     m=false;
        //                      TexBoxTelefono.Focus();
                            
        //                 }
                        
        //             }
                    
        //             if(string.IsNullOrEmpty(TexBoxDireccion.Text))
        //             {
                        
                        
        //                 mensaje+=" La descripcion esta vacia";
        //                 m=false;
        //                 TexBoxDireccion.Focus();
                    
        //             }

        //             if(string.IsNullOrEmpty(TexBoxNombrecliente.Text))
        //             {   
        //                 mensaje+=" El nombre esta vacio";         
        //                 m=false;
        //                 TexBoxNombrecliente.Focus();
                        
        //             }

        //             if(m==false){
        //             MessageBox.Show(mensaje, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //             }

        //     }

        //     return m;
        // }

         public void Nuevo()
        {
        }
      

    }
    
}