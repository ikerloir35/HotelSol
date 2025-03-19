using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    [Index(nameof(idOdoo))]
    [Index(nameof(name))]
    public class Producto
    {
        public int productoId { get; set; }
        public int idOdoo { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public double list_price { get; set; }
        public double qty_available { get; set; }
    }
}
