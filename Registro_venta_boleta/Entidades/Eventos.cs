using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registro_venta_boleta.Entidades
{
    public class Eventos
    {
        public int id {set; get;}
        public string? Nombre {set; get;}

        public string? Tipo {set; get;}
        public string? Image {set; get;}
        public string? Fecha {set; get;}
        public string? Ciudad {set; get;}
        public string? Lugar {set; get;}
        public int? Cantidad {set; get;}
        
    }
}