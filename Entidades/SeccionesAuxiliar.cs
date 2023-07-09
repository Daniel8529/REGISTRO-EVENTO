using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registro_venta_boleta.Entidades
{
    public class SeccionesAuxiliar
    {
        [Key]
          public int IdSecciones{set; get;}
      public int IdEvento{set; get;}
        public  string? Tipo {set; get;}
          public bool Is_active{set; get;}=false;
          public  string? Secciones {set; get;}
          
        
    }
}