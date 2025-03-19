using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    [Index(nameof(numHab))]
    public class Habitacion {
        public int HabitacionId { get; set; }
        public int numHab { get; set; }
        public string tipoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public int NumeroOcupantes { get; set; }
        public string Estado { get; set; }
        public double Precio { get; set; }
    }     
}
