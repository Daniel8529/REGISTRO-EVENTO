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
using System.Text.RegularExpressions;



namespace Registro_venta_boleta.UI.Registro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registro_evento_boleta : Page
    {
        public List<string> Pais=new List<string>();
        public List<string> Provincia=new List<string>();
         public List<string> Ciudad=new List<string>();
         public List<string> Tipo=new List<string>();
        public string m ;

        public Registro_evento_boleta()
        {
            //  Pais.Add("Estados Unidos"); 
            //  Pais.Add("Republic Dominica");
            //  Pais.Add("Colombia");
            //  Ciudad.Add("Pimentel");
              
            this.InitializeComponent();

            // ComboBoxPais.ItemsSource=Pais;
            // ComboBoxPais.IsEditable = true;

            // ComboBoxProvincia.ItemsSource=Provincia;
            // ComboBoxProvincia.IsEnabled=false;
            // ComboBoxProvincia.IsEditable = true;

           
          
            ComboBoxCiudad.IsEditable = true;
            Ciudad.Add("Santo Domingo Este ");
            Ciudad.Add("Santo Domingo Norte");
            Ciudad.Add("Santo Domingo Oeste ");
            Ciudad.Add("San Felipe de Puerto Plata");
            Ciudad.Add("Higüey");
            Ciudad.Add("San Francisco de Macorís");
            Ciudad.Add("Los Alcarrizos");
            Ciudad.Add("La Vega");
            Ciudad.Add("La Romana");
            Ciudad.Add("Moca");
            Ciudad.Add("Villa Altagracia");
            Ciudad.Add("San Juan de La Maguana");
            Ciudad.Add("Haina");
            Ciudad.Add("Bonao");
            Ciudad.Add("Cotuí");
            Ciudad.Add("Baní");
            ComboBoxCiudad.ItemsSource=Ciudad;
            Tipo.Add("Musica");
            Tipo.Add("Artes");
            Tipo.Add("Juegos");
            ComboBoxTipo.ItemsSource=Tipo;

           
        }

        public Registro_evento_boleta(int id)
        {
              this.InitializeComponent();
              GeTid(id);
        }

      
        //  private void  COmboBoxPais(object sender,  SelectionChangedEventArgs e)
        // {    
            
        //       ComboBoxProvincia.IsEnabled=true;
            
        //       if(ComboBoxPais.SelectedItem.ToString()=="Estados Unidos"){

        //             Provincia.Clear();
        //             ComboBoxProvincia.ItemsSource = null;
        //             Provincia.Add("Alabama");
        //             Provincia.Add("Alabama");
        //             Provincia.Add("California");
        //             ComboBoxProvincia.ItemsSource=Provincia;
                  
                 
           
        //     }else
        //     if(ComboBoxPais.SelectedItem.ToString()=="Republic Dominica"){

        //             Provincia.Clear();
        //             ComboBoxProvincia.ItemsSource = null;
        //             Provincia.Add("Duarte");
        //             Provincia.Add("El Seibo");
        //             Provincia.Add("Elías Piña");
        //             ComboBoxProvincia.ItemsSource=Provincia;
                    

        //      }
           
             
        // }
        // private void  COmboBoxProvincia(object sender,  SelectionChangedEventArgs e)
        // {    
            
        //       ComboBoxCiudad.IsEnabled=true;
            
        //    if(ComboBoxProvincia.SelectedItem!=null){
        //      if(ComboBoxProvincia.SelectedItem.ToString()=="Duarte"){

        //             Ciudad.Clear();
        //             ComboBoxCiudad.ItemsSource = null;
        //             Ciudad.Add("San Francisco de Macorís");
        //             Ciudad.Add("Pimentel");
        //             ComboBoxCiudad.ItemsSource=Ciudad;
                  
                 
           
        //     }else
        //     if(ComboBoxProvincia.SelectedItem.ToString()=="El Seibo"){

        //             Ciudad.Clear();
        //             ComboBoxCiudad.ItemsSource = null;
        //             Ciudad.Add("Pedro Sánchez ");
        //             Ciudad.Add("El cedro");
        //             ComboBoxCiudad.ItemsSource=Ciudad;
                  
                 
           
        //     }
        //    }

           
             
        // }
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
                    var datos = System.Text.Json.JsonSerializer.Deserialize<Eventos>(cadena);
                
                     
                     List<Eventos> guarda=new List<Eventos>();
                     
                    //  guarda.Add(emloyeess);
                    //   TablaTexto.ItemsSource = null;
                    //  TablaTexto.ItemsSource =guarda;
                     
                   
                
                }
            }
        }



        public void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            Nuevo();

        }


        public void Guardar_Click(object sender, RoutedEventArgs e)
        {
            
            if(validar()){
                Post();
               Nuevo();
           
            }
       
        }

        public void Cargarimagen_Click(object sender, RoutedEventArgs e)
        {
       
        }

        public void Eliminar_Click(object sender, RoutedEventArgs e)
        {

        }


        public void Nuevo()
        { 
             TexBoxNombre.Text="";
             ComboBoxTipo.ItemsSource=null;
             ComboBoxTipo.ItemsSource=Tipo;
             TextboxImage.Text="";
             ComboBoxCiudad.ItemsSource=null;
             ComboBoxCiudad.ItemsSource=Ciudad;
             TexBoxLugar.Text="";
             TexBoxCantidad.Text="";
             

        }

         public async Task Post()
        {
            var url ="http://127.0.0.1:8000/apiApp/v1/Eventos/";
            JsonSerializerOptions options = new JsonSerializerOptions() {PropertyNameCaseInsensitive=true};
            using(var httpClient = new HttpClient())
            {
            
                var Content= new StringContent(JsonConvert.SerializeObject(new Eventos{Nombre=TexBoxNombre.Text, Fecha=DatePickerFecha.SelectedDate.ToString(),Tipo=ComboBoxTipo.SelectedItem.ToString(),Image=TextboxImage.Text  ,Ciudad=ComboBoxCiudad.SelectedItem.ToString(),Lugar=TexBoxLugar.Text,Cantidad=int.Parse(TexBoxCantidad.Text) }),Encoding.UTF8,"application/Json");
            
                var reponse=await httpClient.PostAsync(url,Content);
                if(!reponse.IsSuccessStatusCode){
                  
                   MessageBox.Show("Hubo un problema"," Error", MessageBoxButton.OK, MessageBoxImage.Information);
                }else{
                    MessageBox.Show("Se guardo corretamente"," Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        public  bool validar()
        {
            string mensaje="";
            bool m =true;

            if(string.IsNullOrEmpty(TexBoxNombre.Text)   && ComboBoxCiudad.SelectedValue==null     && string.IsNullOrEmpty(TexBoxLugar.Text)&&
              string.IsNullOrEmpty(TexBoxCantidad.Text)&&  ComboBoxTipo.SelectedValue==null )
            {
                  m=false;
                  MessageBox.Show("Por favor llenar todo los campos", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                   TexBoxNombre.Focus();

            }else{
                   if(string.IsNullOrEmpty(TexBoxCantidad.Text))
                    {
                        
                            
                            mensaje+=" La cantidad esta vacia";
                            m=false;
                          

                        
                
                    }else
                    {
                        if(!Regex.IsMatch(TexBoxCantidad.Text, @"^[0-9]+$"))
                        {

                            mensaje+=" La cantidad solo permite numero";
                            m=false;
                          
                            
                        }else{
                            if(Convert.ToInt32(TexBoxCantidad.Text)==0)
                            {
                                
                                mensaje+=" La cantidad esta vacia";
                                m=false;
                               

                            }
                        }
                        
                    }

                    if(string.IsNullOrEmpty(TexBoxLugar.Text))
                    {
                        
                            mensaje+=" El lugar esta vacio";
                           m=false;
                          

                        
                        
                        
                  
                    }
                     
                   
                    if(ComboBoxCiudad.SelectedValue==null)
                    {
                        
                        
                        mensaje+="La ciuda esta vacia";
                        m=false;
                      
                    
                    }

                    if(string.IsNullOrEmpty(TexBoxNombre.Text))
                    {   
                        mensaje+=" El nombre esta vacio";         
                        m=false;
                        TexBoxNombre.Focus();
                        
                    }

                    if(m==false){
                    MessageBox.Show(mensaje, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

            }

            return m;
        }


    }
}