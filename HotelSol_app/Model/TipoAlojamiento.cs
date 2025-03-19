using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class TipoAlojamiento { 
        public int TipoAlojamientoId { get; set; }
        public string NombreAlojamiento { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }     
}
