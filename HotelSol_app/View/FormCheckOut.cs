using HotelSol.Controller.db;
using HabitacionSol.Controller.db;
using HotelSol.Controller.db;
using HotelSol.Model;
using ReservaSol.Controller.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol
{
    public partial class FormCheckOut : Form
    {
        HotelContext db = new HotelContext();
        Clientedb? clientedb;
        Cliente? cliente;
        Habitaciondb? habitaciondb;
        Habitacion? habitacion;
        Reservadb Reservadb;
        Reserva? reserva;
        Facturadb Facturadb;
        Factura? factura;


        public FormCheckOut()
        {
            InitializeComponent();
            inicializar();
            clientedb = new Clientedb(db);
            habitaciondb = new Habitaciondb(db);
            Reservadb = new Reservadb(db);
            Facturadb = new Facturadb(db);
        }
        private void inicializar()
        {
            numPersTxt.Text = "";
            tipoHabTxt.Text = "";
            habAsigTxt.Text = "";
            TipoAlojaTxt.Text = "";
            numPersTxt.Text = "";
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
        }

        /**
         * Busca cliente por documento identidad
         */
        private Boolean buscaCliente()
        {
            Boolean ok = false;
            try
            {
                cliente = clientedb.GetByDocumentId(DocIdTxt.Text);
                if (cliente == null)
                {
                    MsgTxt.Text = "No existe el cliente, por favor registrélo";
                    MsgTxt.Visible = true;
                    ok = false;
                }
                else
                {
                    nomTxt.Text = cliente.Nombre;
                    paisTxt.Text = cliente.Direccion.pais;
                    localidadTxt.Text = cliente.Direccion.Localidad;
                    cpTxt.Text = cliente.Direccion.CP;
                    calleTxt.Text = cliente.Direccion.Calle1;
                    ap1Txt.Text = cliente.Apellido1;
                    ap2Txt.Text = cliente.Apellido2;
                    tipoCliTxt.Text = cliente.TipoCliente;
                    numTarjetaTxt.Text = cliente.numTarjeta;
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
                ok = false;
            }
            return ok;
        }

        /**
         * Busca reserva en curso
         */
        private Boolean buscaReserva()
        {
            try
            {
                reserva = Reservadb.GetByReservaEnCursoCliente(cliente.ClienteId);
                if (reserva == null)
                {
                    MsgTxt.Text = "No existe reserva del cliente, no se puede hacer CheckOut";
                    MsgTxt.Visible = true;
                    btnFacturar.Enabled = false;
                    btnFreeRoom.Enabled = false;
                    return false;
                }
                else
                {
                    //buscamos si ya tiene facturas para volver a facturar
                    btnFacturar.Enabled = (Facturadb.GetFacturasReserva(reserva.ReservaId).Count <= 0);
                    tipoHabTxt.Text = reserva.Habitacion.tipoHabitacion;
                    habAsigTxt.Text = reserva.Habitacion.numHab.ToString();
                    TipoAlojaTxt.Text = reserva.TipoAlojamiento.NombreAlojamiento;
                    numPersTxt.Text = reserva.numPers.ToString();
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                return false;
            }
            return true;
        }
        /**
         * Buscamos cliente y reserva en curso
         */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            inicializar();
            try
            {
                if (buscaCliente())
                {
                    buscaReserva();
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
            }
        }

        /**
         * Libera habitación para otro cliente y cierra la reserva
         */
        private void btnFreeRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (reserva.Habitacion != null)
                {
                    habitacion = habitaciondb.Get(reserva.Habitacion.HabitacionId);
                    habitacion.Estado = "LIBRE";
                    habitaciondb.Graba(habitacion);
                }
                if (reserva != null)
                {
                    reserva.Estado = 2;
                    btnFreeRoom.Enabled = Reservadb.Update(reserva);
                    MsgTxt.Visible = true;
                    MsgTxt.Text = "RESERVA FINALIZADA";
                }
            }
            catch (Exception ex) { MsgTxt.Text = ex.Message; MsgTxt.Visible = true; }


        }

        private Double calculaTotal()
        {
            Double total = 0;
            if (reserva.Servicios != null)
            {
                foreach (var serv in reserva.Servicios) {
                    total += serv.Precio;
                }     
            }

            if (reserva.Temporada != null)
            {
                total += reserva.Temporada.Precio;
            }

            if (reserva.Habitacion != null)
            {
                total += reserva.Habitacion.Precio;
            }

            if (reserva.TipoAlojamiento != null)
            {
                total += reserva.TipoAlojamiento.Precio;
            }

            return total;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            factura = new Factura();
            if (reserva.Temporada.NombreTemporada == null)
            {
                factura.NombreTemporada = "MEDIA";
            }
            else
            {
                factura.NombreTemporada = reserva.Temporada.NombreTemporada;
            }
            factura.FechaFactura = DateTime.Now;
            factura.Concepto = "FACTURA CLIENTE - " + cliente.DocumentId;
            factura.ReservaId = reserva.ReservaId;
            factura.Reserva = reserva;
            if (reserva.Temporada != null)
            {
                factura.Reserva.TemporadaId = null;
                factura.Reserva.Temporada = null;
            }
            factura.Total = calculaTotal();
            if (Facturadb.Graba(factura))
            {
                btnFacturar.Enabled = false;
                MsgTxt.Text = "SE HA GENERADO LA FACTURA " + factura.FacturaId.ToString() + ". TOTAL: " + factura.Total.ToString();
                MsgTxt.Visible = true;
            }
            else
            {
                MsgTxt.Text = "ERROR GENERANDO FACTURA, CONTACTE CON INFORMÁTICA";
                MsgTxt.Visible = true;
            }
        }
    }
}
