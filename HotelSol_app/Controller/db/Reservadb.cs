using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace ReservaSol.Controller.db
{
    public class Reservadb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean resConfigurado = false;

        public Reservadb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Reservadb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del Reserva
         */
        public Boolean Graba( Reserva res )
        {
            try
            {
                if (resConfigurado)
                {
                    this.Update(res);
                }
                else
                {

                    db.Attach(res.Cliente);
                    if (res.Habitacion != null) db.Attach(res.Habitacion);
                    if (res.Temporada != null)  db.Attach(res.Temporada);
                    if (res.TipoAlojamiento != null) db.Attach(res.TipoAlojamiento); 

                    db.Add(res);
                    db.SaveChanges();
                    db.ChangeTracker.Clear();      
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                desc_error = ex.Message;
                error = true;
            }
            return !this.error;

        }
        /**
         * Get Reserva por Cliente y Estado
         * */
        private Reserva? GetByClienteEstadoReserva(int ClienteId, int Estado)
        {
            Reserva? res = db.Reserva.Include(x => x.Cliente)
                                      .Include(h => h.Habitacion)
                                      .Include(t => t.TipoAlojamiento)
                                      .Include(tp => tp.Temporada)
                                      .Include(s => s.Servicios)
                                      .SingleOrDefault(b => b.ClienteId == ClienteId && b.Estado == Estado);
            resConfigurado = (res != null);
            return res;
        }

        public Reserva? GetByReservaPendienteCliente(int ClienteId)
        {
            return GetByClienteEstadoReserva(ClienteId, 0);
        }

        public Reserva? GetByReservaEnCursoCliente(int ClienteId)
        {
            return GetByClienteEstadoReserva(ClienteId, 1);
        }

        public Reserva? GetByReservaFinalizadaCliente(int ClienteId)
        {
            return GetByClienteEstadoReserva(ClienteId, 2);
        }


        /**
          * Get Reserva por Cliente
        */
        public Reserva? GetLastByCliente(String DocId)
        {
            Reserva? res = db.Reserva.Include(x => x.Cliente)
                                      .Include(h => h.Habitacion)
                                      .Include(t => t.TipoAlojamiento)
                                      .Include(tp => tp.Temporada)
                                      .Include(s => s.Servicios)
                                      .OrderByDescending(o => o.FechaReserva)
                                      .FirstOrDefault(b => b.Cliente.DocumentId == DocId);
                                      
            resConfigurado = (res != null);
            return res;
        }

        /*
         * eliminar
         */
        public Boolean Remove( Reserva res )
        {
            this.error = false;
            try
            {
                db.Remove(res);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }

            return this.error;
        }

        /**
         * read ID
         */
        public Reserva? Get( int id)
        {
            Reserva? res=null;
            try
            {
                res = db.Reserva.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return res;
        }

 

        /*
         * Actualitza res
         */
        public Boolean Update( Reserva res )
        {
            this.error = false;
            try
            {
                var r = db.Reserva.Find(res.ReservaId);
                if (  r != null )
                {
                    r.Habitacion = res.Habitacion;
                    r.NombreServicio = res.NombreServicio;
                    r.Descripcion = res.Descripcion;
                    r.Precio = res.Precio;
                    r.ClienteId = res.ClienteId;
                    r.Cliente = res.Cliente;
                    r.TipoAlojamientoId = res.TipoAlojamientoId;
                    r.TipoAlojamiento = res.TipoAlojamiento;
                    r.ServicioId = res.ServicioId;
                    r.Servicios = res.Servicios;
                    r.TemporadaId = res.TemporadaId;
                    r.Temporada = res.Temporada;
                    r.HabitacionId = res.HabitacionId;
                    r.Habitacion = res.Habitacion;
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error = true;
            }

            return this.error;
        }

        public string ObtenDescError()
        {
            return desc_error;
        }

        public Boolean Conectado()
        {
            return conectada;
        }

    }
}
