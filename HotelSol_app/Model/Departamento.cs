using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    public class Departamento { 
        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public string? Servicios { get; set; }
        public string? Responsable { get; set; }
    }     
}
