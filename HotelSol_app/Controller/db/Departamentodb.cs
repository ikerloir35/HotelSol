using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;

namespace DepartamentoSol.Controller.db
{
    public class Departamentodb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean deptConfigurado = false;

        public Departamentodb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Departamentodb( HotelContext db )
        {
            this.db = db;
        }

        /*
         * Graba el registro del Departamento
         */
        public Boolean Graba( Departamento dept )
        {
            try
            {
                if (deptConfigurado)
                {
                    this.Update(dept);
                }
                else
                {
                    db.Add(dept);
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
        public Boolean Remove( Departamento dept )
        {
            this.error = false;
            try
            {
                db.Remove(dept);
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
        public Departamento? Get( int id)
        {
            Departamento? dept=null;
            try
            {
                dept = db.Departamento.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return dept;
        }

        public List<Departamento> GetAll()
        {
            return db.Departamento.Select(x => x).OrderBy(x => x.Descripcion).ToList();
        }

 

        /*
         * Actualitza dept
         */
        public Boolean Update( Departamento dept )
        {
            this.error = false;
            try
            {
                var d = db.Departamento.Find(dept.DepartamentoId);
                if ( d != null )
                {
                    d.Descripcion = dept.Descripcion;
                    d.Servicios = dept.Servicios;
                    d.Responsable = dept.Responsable;
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
