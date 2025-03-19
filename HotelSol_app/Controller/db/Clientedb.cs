using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelSol.Controller.db
{
    public class Clientedb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean nuevoCliente = false;

        public Clientedb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Clientedb( HotelContext db )
        {
            this.db = db;
        }

        /*
         * Graba el registro del Cliente
         */
        public Boolean Graba(Cliente cliente)
        {
            try
            {
              //  Hoteldb hoteldb = new Hoteldb();
             //   cliente.Hotel = hoteldb.Get(cliente.HotelId);
                if (!nuevoCliente)
                {
                    this.Update(cliente);
                }
                else
                {
                    db.Add(cliente);
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
        public Boolean Remove( Cliente cliente )
        {
            this.error = false;
            try
            {
                db.Remove(cliente);
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
        public Cliente? Get( int id)
        {
            Cliente? cliente=null;
            try
            {
                cliente = db.Cliente.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return cliente;
        }

        /**
         * Get Cliente por documento DNI o lo que sea que tenga
         * */
        public Cliente? GetByDocumentId(String docId) {
            Cliente? cli = db.Cliente.Include(x => x.Direccion)
                                      .SingleOrDefault(b => b.DocumentId == docId );
            nuevoCliente = (cli == null);
           // db.Attach(cli.Direccion);
            return cli;
        }

        /*
         * Actualitza hotel
         */
        public Boolean Update( Cliente cliente )
        {
            this.error = false;
            try
            {
                var cli = db.Cliente.Find(cliente.ClienteId);
                if ( cli != null )
                {
                    cli.Apellido1 = cliente.Apellido1;
                    cli.Apellido2 = cliente.Apellido2;
                    cli.DocumentId = cliente.DocumentId;
                    cli.Observaciones = cliente.Observaciones;
                    cli.Nacionalidad = cliente.Nacionalidad;
                    cli.Telefono = cliente.Telefono;
                    cli.Nombre = cliente.Nombre;
                    cli.Mail = cliente.Mail;
                    cli.DireccionId = cliente.DireccionId;
                    cli.Direccion = cliente.Direccion;
                    cli.TipoCliente = cliente.TipoCliente;
                    cli.numTarjeta = cliente.numTarjeta;
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

        public List<Cliente> ToList()
        {
            return db.Cliente.Include(d => d.Direccion).ToList();
        } 

    }
}
