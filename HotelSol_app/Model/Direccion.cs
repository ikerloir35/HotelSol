using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Direccion { 
        public int DireccionId { get; set; }
        public string Calle1 { get; set; }
        public string? Calle2 { get; set; }
        public string CP { get; set; }
        public string Localidad { get; set; }
        public String pais {  get; set; }
    }     
}
