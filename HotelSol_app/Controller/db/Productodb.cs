using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;
using HotelSol.Controller.files;

namespace HotelSol.Controller.db
{
    public class Productodb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean prodConfigurado = false;

        public Productodb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Productodb( HotelContext db )
        {
            this.db = db;
            conectada = true;
        }

        /*
         * Graba el registro del Producto
         */
        public Boolean Graba( Producto prod )
        {
            try
            {
                if (prodConfigurado)
                {
                    this.Update(prod);
                }
                else
                {
                    db.Add(prod);
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
        public Boolean Remove( Producto prod )
        {
            this.error = false;
            try
            {
                db.Remove(prod);
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
        public Producto? Get( int id)
        {
            Producto? prod=null;
            try
            {
                prod = db.Producto.Find(id);
                prodConfigurado = prod != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return prod;
        }

        /**
        * find by name
        */
        public Producto? FindByName(String n)
        {
            Producto? prod = null;
            try
            {   
                prod = db.Producto.FirstOrDefault(p => p.name.ToUpper().Contains(n.ToUpper()));
                prodConfigurado = prod != null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error = true;
            }

            return prod;
        }

        /**
         * Find by Odoo id
         */

        public Producto? FindByOdooId(int id)
        {   
            Producto? prod = null;
            try
            {
                prod = db.Producto.FirstOrDefault(p => p.idOdoo == id);
                prodConfigurado = prod != null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error = true;
            }

            return prod;
        }

        /**
        * list of products
        */
        public List<Producto>? toList()
        {
              return db.Producto.ToList();
        }


        /*
         * Actualitza prod
         */
        public Boolean Update( Producto prod )
        {
            this.error = false;
            try
            {
                var p = db.Producto.Find(prod.productoId);
                if (  p != null )
                {
                    p.list_price = prod.list_price;
                    p.description = prod.description;
                    p.name = prod.name;
                    p.qty_available = prod.qty_available;
                    p.idOdoo = prod.idOdoo;
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


        public int LoadProductFile()
        {
            int num = 0;

            List<Producto> prod = new ProductParser().GetProductList();

            if (prod != null )
            {
                foreach (var item in prod )
                {
                    try
                    {
                        Producto p = this.FindByOdooId(item.idOdoo);
                        if ( p == null)
                        {
                            p = new Producto();
                        }
                        p.list_price = item.list_price;
                        p.description = (item.description == null) ? item.name : item.description;
                        p.qty_available = item.qty_available;
                        p.idOdoo = item.idOdoo;
                        p.name = item.name;
                        this.Graba(p);
                        num ++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        num = -1;
                    }
                }
            }

            return num;
        }
    }
}
