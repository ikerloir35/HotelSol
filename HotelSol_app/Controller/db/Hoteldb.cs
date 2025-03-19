using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelSol.Controller.db
{
    public class Hoteldb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean hotelConfigurado = false;

        public Hoteldb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Hoteldb( HotelContext db )
        {
            this.db = db;
        }

        /*
         * Graba el registro del Hotel
         */
        public Boolean Graba( Hotel hotel )
        {
            try
            {
                if (hotelConfigurado)
                {
                    this.Update(hotel);
                }
                else
                {
                    db.Add(hotel);
                    db.SaveChanges();
                }
                db.Dispose();
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
        public Boolean Remove( Hotel hotel )
        {
            this.error = false;
            try
            {
                db.Remove(hotel);
                db.SaveChanges();
                db.Dispose();
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
        public Hotel? Get( int id)
        {
            Hotel? hotel=null;
            Direcciondb dirdb = new Direcciondb();
            try 
            {
                hotel = db.Hotel.Find(id);
                hotel.Direccion = dirdb.Get(hotel.DireccionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return hotel;
        }

        /**
         * Get First Hotel, hacemos que solo pueda haber uno
         * */
        public Hotel? GetFirst() {
            Hotel? hot = db.Hotel.Include(x => x.Direccion).FirstOrDefault();
            hotelConfigurado = (hot != null);
            return hot;
        }

        /*
         * Actualitza hotel
         */
        public Boolean Update( Hotel hotel )
        {
            this.error = false;
            try
            {
                var hot = db.Hotel.Find(hotel.HotelId);
                if ( hot != null )
                {
                    hot.CIF = hotel.CIF;
                    hot.Descripcion = hotel.Descripcion;
                    hot.DireccionId = hotel.DireccionId;
                    hot.Direccion = hotel.Direccion;
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
