using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSol.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace HotelSol.Controller.db
{
    public class Empleadodb
    {
        HotelContext db ;
        string desc_error="";
        Boolean error=false;
        Boolean conectada;
        Boolean nuevoEmpleado = false;
        String key = "770A8A65DA156D24EE2A093277530142";

        public Empleadodb() { 
             this.db = new HotelContext();
             conectada = true;
        }

        public Empleadodb( HotelContext db )
        {
            this.db = db;
        }

        /*
         * Graba el registro del Empleado
         */
        public Boolean Graba(Empleado empleado)
        {
            try
            {
                if (!nuevoEmpleado)
                {
                    this.Update(empleado);
                }
                else
                {
                    db.Add(empleado);
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
        public Boolean Remove( Empleado empleado )
        {
            this.error = false;
            try
            {
                db.Remove(empleado);
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
        public Empleado? Get( int id)
        {
            Empleado? empleado=null;
            try
            {
                empleado = db.Empleado.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.error=true;
            }
             
            return empleado;
        }

        /**
         * Get Empleado por documento DNI o lo que sea que tenga
         * */
        public Empleado? GetByDocumentId(String docId) {
            Empleado? emp = db.Empleado.Include(x => x.Direccion).SingleOrDefault(b => b.DocumentId == docId );
            nuevoEmpleado = (emp == null);
            return emp;
        }

        /**
         * Get Empleado  por ususario
         * */
        public Empleado? GetByUser(String usuario)
        {
            Empleado? emp = db.Empleado.Include(x => x.Direccion).SingleOrDefault(b => b.Usuario == usuario);
            nuevoEmpleado = (emp == null);
            return emp;
        }


        public string EncryptPassword(string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public string DecryptPassword(string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    

    /*
     * Actualitza 
     */
    public Boolean Update( Empleado empleado )
        {
            this.error = false;
            try
            {
                var emp = db.Empleado.Find(empleado.EmpleadoId);
                if ( emp != null )
                {
                    emp.Nombre = empleado.Nombre;
                    emp.Apellido1 = empleado.Apellido1;
                    emp.Apellido2 = empleado.Apellido2;
                    emp.Telefono = empleado.Telefono;
                    emp.Mail = empleado.Mail;
                    emp.Puesto = empleado.Puesto;
                    emp.DocumentId = empleado.DocumentId;
                    emp.Observaciones = empleado.Observaciones;
                    emp.Direccion = empleado.Direccion;
                    emp.DepartamentoId = empleado.DepartamentoId;
                    emp.Departamento = empleado.Departamento;
                    emp.Usuario = empleado.Usuario;
                    emp.Password = empleado.Password;
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
