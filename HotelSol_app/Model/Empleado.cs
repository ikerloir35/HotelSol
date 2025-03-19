using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HotelSol.Model
{
    [Index(nameof(Usuario), IsUnique = true)]
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string? Telefono { get; set; }
        public string? Mail { get; set; }
        public string? Puesto { get; set; }
        public string DocumentId { get; set; }
        public string? Observaciones { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int DireccionId {  get; set; }
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Direccion Direccion { get; set;} = new Direccion();
        public int DepartamentoId { get; set; }
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Departamento Departamento { get; set; } = new Departamento();
    }
}
