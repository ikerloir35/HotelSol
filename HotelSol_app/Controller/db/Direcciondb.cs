using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelSol.Controller.db
{
    public class Direcciondb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;


        public Direcciondb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Direcciondb( HotelContext db )
        {
            this.db = db;
        }

        /*
         * Añade un registro de Dirección
         */
        public Boolean Add( Direccion  direc)
        {
            try
            {
                db.Add(direc);
                db.SaveChanges();
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
        public Boolean Remove( Direccion direc )
        {
            this.error = false;
            try
            {
                db.Remove(direc);
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
        public Direccion? Get( int id)
        {
            Direccion? direc=null;
            try
            {
                direc = db.Direccion.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return direc;
        }


        /*
         * Actualitza direccion
         */
        public Boolean Update( Direccion direccion)
        {
            this.error = false;
            try
            {
                var direc = db.Direccion.Find(direccion.DireccionId);
                if ( direc != null )
                {
                    direc.Calle1 = direccion.Calle1;
                    direc.Calle2 = direccion.Calle2;
                    direc.CP    = direccion.CP;
                    direc.Localidad = direccion.Localidad;
                    direc.pais = direccion.pais;
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
