using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Evento { 
        public int EventoId { get; set; }
        public string NombreEvento { get; set; }
        public string Descripcion { get; set; }
        public int ClienteId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public Cliente Cliente { get; set; } = new Cliente();
    }     
}
