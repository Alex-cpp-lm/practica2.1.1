using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2._1._1
{
    internal class Inventario
    {
        public int Id { get; set; }  
        public string NombreCorto { get; set; }
        public string Descripcion { get; set; } 
        public string Serie { get; set; } 
        public string Color { get; set; } 
        public string FechaAdquisicion { get; set; }  
        public string TipoAdquisicion { get; set; }  
        public string Observaciones { get; set; }  
        public int AreaId { get; set; }  

    }
}
