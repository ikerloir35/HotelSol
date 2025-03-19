using HotelSol.Controller.lib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace HotelSol.View
{
    public partial class FormDatosERP : Form
    {
        HotelContext db = new HotelContext();
        String folder = @"C:\temp\";
        public FormDatosERP()
        {
            InitializeComponent();
        }

        private void ObtenerClientesYGuardarXML<T>(DbSet<T> dbSet, string nombreArchivo, params string[] incluirPropiedades) where T : class
        {
            try
            {
                // Consulta LinQ para incluir propiedades relacionadas si se proporcionan
                IQueryable<T> query = dbSet;
                foreach (var propiedad in incluirPropiedades)
                {
                    query = query.Include(propiedad);
                }

                var datos = query.ToList();

                // Crear un documento XML y agregar los datos como elementos
                var doc = new XDocument(
                    new XElement("Clientes",
                        from entity in datos
                        select new XElement("Cliente",
                            from property in typeof(T).GetProperties()
                            where property.GetMethod.IsPublic && property.PropertyType.Namespace != "System.Collections.Generic" && property.Name != "Direccion"
                            select new XElement(property.Name, property.GetValue(entity)),
                            // Agregar la información de la dirección si existe
                            (entity as dynamic).Direccion != null ?
                                new XElement("Direccion",
                                    new XElement("DireccionId", (entity as dynamic).Direccion.DireccionId),
                                    new XElement("Calle1", (entity as dynamic).Direccion.Calle1),
                                    new XElement("Calle2", (entity as dynamic).Direccion.Calle2),
                                    new XElement("CP", (entity as dynamic).Direccion.CP),
                                    new XElement("Localidad", (entity as dynamic).Direccion.Localidad),
                                    new XElement("Pais", (entity as dynamic).Direccion.pais)
                                ) :
                                null
                        )
                    )
                );

                // Guardar el documento XML en un archivo
                string rutaArchivoXML = nombreArchivo;
                doc.Save(rutaArchivoXML);
                MessageBox.Show("Los datos se han guardado correctamente en el archivo XML.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener y guardar los datos: " + ex.Message);
            }
        }


        //Metodo para exportar resto datos


        private void ObtenerDatosYGuardarXML<T>(DbSet<T> dbSet, string nombreArchivo) where T : class
        {
            try
            {
                var datos = dbSet.ToList();

                // Crear un documento XML y agregar los datos como elementos
                var doc = new XDocument(
                    new XElement(typeof(T).Name + "s",
                        from entity in datos
                        select new XElement(typeof(T).Name,
                            from property in typeof(T).GetProperties()
                            where property.GetMethod.IsPublic
                            select new XElement(property.Name, property.GetValue(entity))
                        )
                    )
                );

                // Guardar el documento XML en un archivo
                string rutaArchivoXML = nombreArchivo;
                doc.Save(rutaArchivoXML);
                MessageBox.Show("Los datos se han guardado correctamente en el archivo XML.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener y guardar los datos: " + ex.Message);
            }
        }


        //Llamar al metodo cuando se pulse el boton InfoClientes pasando dbset Clientes
        private void btnInfoClientesXML_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosClientes.xml";
            ObtenerClientesYGuardarXML(db.Cliente, rutaArchivoXML, "Direccion");
        }

        private void btnInfoFacturas_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosFacturas.xml";
            ObtenerDatosYGuardarXML(db.Factura, rutaArchivoXML);
        }

        private void btnInfoReservas_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosReservas.xml";
            ObtenerDatosYGuardarXML(db.Reserva, rutaArchivoXML);
        }

        private void btnInfoHabitaciones_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosHabitaciones.xml";
            ObtenerDatosYGuardarXML(db.Habitacion, rutaArchivoXML);
        }

        private void btnInfoTemporadas_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosTemporadas.xml";
            ObtenerDatosYGuardarXML(db.Temporada, rutaArchivoXML);
        }

        private void btnInfoTAlojamiento_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosTipoAlojamiento.xml";
            ObtenerDatosYGuardarXML(db.TipoAlojamiento, rutaArchivoXML);
        }

        private void btnInfoEmpleados_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosEmpleados.xml";
            ObtenerDatosYGuardarXML(db.Empleado, rutaArchivoXML);
        }

        private void btnInfoDepartamentos_Click(object sender, EventArgs e)
        {
            btnInfoClientesXML.BackColor = Color.FromArgb(244, 81, 30);
            btnInfoClientesXML.ForeColor = Color.WhiteSmoke;
            string rutaArchivoXML = folder + "datosDepartamentos.xml";
            ObtenerDatosYGuardarXML(db.Departamento, rutaArchivoXML);
        }

        private void btnEnvioClientes_Click(object sender, EventArgs e)
        {
            try
            {
                PyUtils py = new PyUtils();
                py.EjecutarScriptPythonClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el script de Python: " + ex.Message);
            }
        }
 
    }
}
