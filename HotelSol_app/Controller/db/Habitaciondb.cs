using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace HabitacionSol.Controller.db
{
    public class Habitaciondb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean habConfigurado = false;

        public Habitaciondb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Habitaciondb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del Habitacion
         */
        public Boolean Graba( Habitacion hab )
        {
            try
            {
                if (habConfigurado)
                {
                    this.Update(hab);
                }
                else
                {
                    db.Add(hab);
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

        /*
         * eliminar
         */
        public Boolean Remove( Habitacion hab )
        {
            this.error = false;
            try
            {
                db.Remove(hab);
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
        public Habitacion? Get( int id)
        {
            Habitacion? hab=null;
            try
            {
                hab = db.Habitacion.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
            habConfigurado = (hab != null);
            return hab;
        }
        /**
         * Get habitación por num habitación
         * */
        public Habitacion? GetByNumHabitacion(int nh)
        {
            Habitacion? hab = db.Habitacion
                                      .SingleOrDefault(b => b.numHab == nh);
            habConfigurado = (hab != null);
            return hab;
        }

        /**
         * Get primera habitación libre que pueda albergar el num personas
         * */
        public Habitacion? GetFirstFree(int numPers)
        {
            Habitacion? hab = db.Habitacion
                                      .FirstOrDefault(b => b.NumeroOcupantes >= numPers && (b.Estado == "LIBRE" || b.Estado.Trim() == ""));
            habConfigurado = (hab != null);
            if (hab != null) db.Attach(hab);
            return hab;
        }


        /*
         * Actualitza hab
         */
        public Boolean Update( Habitacion hab )
        {
            this.error = false;
            try
            {
                var h = db.Habitacion.Find(hab.HabitacionId);
                if ( h != null )
                {
                    h.tipoHabitacion = hab.tipoHabitacion;
                    h.Descripcion = hab.Descripcion;
                    h.Estado = hab.Estado;
                    h.Precio = hab.Precio;
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
