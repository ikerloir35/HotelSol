using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelSol.Controller.db
{
    public class Serviciosdb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean resConfigurado = false;

        public Serviciosdb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Serviciosdb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del Servicio
         */
        public Boolean Graba( Servicio res )
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
        public Boolean Remove( Servicio res )
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
        public Servicio? Get( int id)
        {
            Servicio? res=null;
            try
            {
                res = db.Servicio.Find(id);
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
        public Boolean Update( Servicio res )
        {
            this.error = false;
            try
            {
                var r = db.Servicio.Find(res.ServicioId);
                if (  r != null )
                {

                    r.NombreServicio = res.NombreServicio;
                    r.Descripcion = res.Descripcion;
                    r.Precio = res.Precio;
                    r.ClienteId = res.ClienteId;
                    r.Cliente = res.Cliente;
                    r.ServicioId = res.ServicioId;
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
