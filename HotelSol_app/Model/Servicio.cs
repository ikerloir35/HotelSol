using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Servicio { 
        public int ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int ClienteId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public Cliente Cliente { get; set; } = new Cliente();
    }     
}
