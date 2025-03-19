using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? DocumentId { get; set; }
        public string? Telefono { get; set; }
        public string? Mail { get; set; }
        public string? Nacionalidad { get; set; }
        public string? Observaciones { get; set; }
        public string? TipoCliente { get; set; }
        public string? numTarjeta { get; set; }
        public int DireccionId {  get; set; }
        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        public Direccion Direccion { get; set;} = new Direccion();
    }
}
