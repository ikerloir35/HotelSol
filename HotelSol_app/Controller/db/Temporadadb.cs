using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace TemporadaSol.Controller.db
{
    public class Temporadadb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean resConfigurado = false;

        public Temporadadb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Temporadadb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del Temporada
         */
        public Boolean Graba( Temporada res )
        {
            try
            {
                if (resConfigurado)
                {
                    this.Update(res);
                }
                else
                {
                    db.Add(res);
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
        public Boolean Remove( Temporada res )
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
        public Temporada? Get( int id)
        {
            Temporada? res=null;
            try
            {
                res = db.Temporada.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return res;
        }

        /**
         * Get habitación por nom temporada
         * */
        public Temporada? GetByNombreTemporada(String a)
        {
            Temporada? temp = db.Temporada
                                      .SingleOrDefault(b => b.NombreTemporada == a.Trim());
            resConfigurado = (temp != null);
            return temp;
        }

        /**
         * Torna la temporada vigent a la data actual y deshabilita el tracking
         */
        public Temporada? GetCurrent()
        {
            Temporada? temp = db.Temporada
                                      .OrderByDescending(fi => fi.FechaFin)
                                      .OrderBy(fi => fi.FechaInicio)
                                      .SingleOrDefault(b => b.FechaInicio >= DateTime.Now && b.FechaFin <= DateTime.Now);
            if (temp != null) db.Attach(temp);
            resConfigurado = (temp != null);
            return temp;
        }

        /**
         * Torna la temporada vigent entre dues dates
         */
        public Temporada? GetByInterval(DateTime dI, DateTime dF)
        {
            Temporada? temp = db.Temporada
                                      .OrderByDescending(fi => fi.FechaFin)
                                      .OrderBy(fi => fi.FechaInicio)
                                      .SingleOrDefault(b => b.FechaInicio >= dI && b.FechaFin <= dF);
            if (temp != null) db.Attach(temp);
            resConfigurado = (temp != null);
            return temp;
        }

        /*
         * Actualitza res
         */
        public Boolean Update( Temporada res )
        {
            this.error = false;
            try
            {
                var r = db.Temporada.Find(res.TemporadaId);
                if (  r != null )
                {
                    r.NombreTemporada = res.NombreTemporada;
                    r.Descripcion = res.Descripcion;
                    r.Precio = res.Precio;
                    r.FechaFin = res.FechaFin;
                    r.FechaInicio = res.FechaInicio;
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
