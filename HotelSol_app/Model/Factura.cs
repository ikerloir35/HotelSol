using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Factura { 
        public int FacturaId { get; set; }
        public string NombreTemporada { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Concepto { get; set; }
        public double Total { get; set; }

        public int? ReservaId { get; set; }
        public Reserva? Reserva { get; set; } = new();
    }     
}
