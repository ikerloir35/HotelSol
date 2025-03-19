using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Hotel { 
        public int HotelId { get; set; }
        public string Descripcion { get; set; }
        public string CIF { get; set; }
        public int DireccionId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Direccion Direccion { get; set; } = new Direccion();
    }     
}
