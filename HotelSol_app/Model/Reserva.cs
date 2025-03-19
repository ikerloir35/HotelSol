using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    [Index(nameof(ClienteId), nameof(Estado))]
    public class Reserva { 
        public int ReservaId { get; set; }
        public string? NombreServicio { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }

        public int ClienteId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public Cliente Cliente { get; set; } = new Cliente();

        public int TipoAlojamientoId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public TipoAlojamiento TipoAlojamiento { get; set; } = new TipoAlojamiento();

        public int? ServicioId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public List<Servicio>? Servicios { get; set; } = new();

        public int? TemporadaId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public Temporada? Temporada { get; set; } = new();

        public int? HabitacionId { get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public Habitacion? Habitacion { get; set; } = new();

        public int numPers {  get; set; }

        public DateTime FechaReserva { get; set; }
        public DateTime FechaEntrada { get; set; } 
        public DateTime FechaSalida { get; set; }

        public int Estado { get; set; }
    }     
}
