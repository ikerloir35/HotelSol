using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelSol.Controller.db
{
    public class Facturadb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean factConfigurado = false;

        public Facturadb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Facturadb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del Factura
         */
        public Boolean Graba( Factura fact )
        {
            try
            {
                if (factConfigurado)
                {
                    this.Update(fact);
                }
                else
                {
                    db.Attach(fact.Reserva.Cliente.Direccion);
                    db.Attach(fact.Reserva.Cliente);
                    db.Attach(fact.Reserva);
                    if (fact.Reserva.Temporada != null) db.Attach(fact.Reserva.Temporada);      
                    db.Attach(fact.Reserva.Habitacion);
                    db.Attach(fact.Reserva.TipoAlojamiento);
                    db.Add(fact);
                    db.SaveChanges();
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
         * recupera la lista de facturas de una reserva
         */

        public List<Factura> GetFacturasReserva(int ReservaId)
        {
            return db.Factura.Select(x => x).Where(x => x.ReservaId == ReservaId).ToList();
        }

        /**
         * recupera la lista de facturas
         */

        public List<Factura> GetAll()
        {
            return db.Factura.Select(x => x).Include(r => r.Reserva).Include(c=> c.Reserva.Cliente).ToList();
        }

        /*
         * eliminar
         */
        public Boolean Remove( Factura fact )
        {
            this.error = false;
            try
            {
                db.Remove(fact);
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
        public Factura? Get( int id)
        {
            Factura? fact=null;
            try
            {
                fact = db.Factura.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return fact;
        }

 

        /*
         * Actualitza fact
         */
        public Boolean Update( Factura fact )
        {
            this.error = false;
            try
            {
                var f = db.Factura.Find(fact.FacturaId);
                if ( f != null )
                {
                    f.NombreTemporada = fact.NombreTemporada;
                    f.FechaFactura = fact.FechaFactura;
                    f.Concepto = fact.Concepto;
                    f.Total= fact.Total;
                    f.ReservaId = fact.ReservaId;
                    f.Reserva = fact.Reserva;
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
