using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace TipoAlojamientoSol.Controller.db
{
    public class TipoAlojamientodb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean resConfigurado = false;

        public TipoAlojamientodb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public TipoAlojamientodb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del TipoAlojamiento
         */
        public Boolean Graba( TipoAlojamiento res )
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
        /**
         * Get habitación por num habitación
         * */
        public TipoAlojamiento? GetByNombreAlojamiento(String a)
        {
            TipoAlojamiento? alo = db.TipoAlojamiento
                                      .SingleOrDefault(b => b.NombreAlojamiento == a.Trim());
            resConfigurado = (alo != null);
            return alo;
        }

        public List<TipoAlojamiento> GetAllTiposAlojamientos()
        {
            return db.TipoAlojamiento.Select(x => x).ToList();
        }

        /*
         * eliminar
         */
        public Boolean Remove( TipoAlojamiento res )
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
        public TipoAlojamiento? Get( int id)
        {
            TipoAlojamiento? res=null;
            try
            {
                res = db.TipoAlojamiento.Find(id);
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
        public Boolean Update( TipoAlojamiento res )
        {
            this.error = false;
            try
            {
                var r = db.TipoAlojamiento.Find(res.TipoAlojamientoId);
                if (  r != null )
                {
                    r.NombreAlojamiento = res.NombreAlojamiento;
                    r.Descripcion = res.Descripcion;
                    r.Precio = res.Precio;
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
