using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace EventoSol.Controller.db
{
    public class Eventodb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean evntConfigurado = false;

        public Eventodb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Eventodb( HotelContext db )
        {
            this.db = db;
        }

        /*
         * Graba el registro del Evento
         */
        public Boolean Graba( Evento evnt )
        {
            try
            {
                if (evntConfigurado)
                {
                    this.Update(evnt);
                }
                else
                {
                    db.Add(evnt);
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
        public Boolean Remove( Evento evnt )
        {
            this.error = false;
            try
            {
                db.Remove(evnt);
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
        public Evento? Get( int id)
        {
            Evento? evnt=null;
            try
            {
                evnt = db.Evento.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return evnt;
        }

 

        /*
         * Actualitza evnt
         */
        public Boolean Update( Evento evnt )
        {
            this.error = false;
            try
            {
                var e = db.Evento.Find(evnt.EventoId);
                if ( e != null )
                {
                    e.Descripcion = evnt.Descripcion;
                    e.NombreEvento = evnt.NombreEvento;
                    e.Descripcion = evnt.Descripcion;
                    e.ClienteId = evnt.ClienteId;
                    e.Cliente = evnt.Cliente;
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
