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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemporadaSol.Controller.db;
using TipoAlojamientoSol.Controller.db;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelSol
{
    public partial class FormReserva : Form
    {
        HotelContext db = new HotelContext();
        Clientedb? clientedb;
        Cliente? cliente;
        Reservadb Reservadb;
        Reserva? reserva;
        TipoAlojamientodb tadb;
        TipoAlojamiento ta;
        Temporadadb Temporadadb;
        Temporada Temporada;
        int idCliente;

        public FormReserva()
        {
            InitializeComponent();
            clientedb = new Clientedb(db);
            Reservadb = new Reservadb(db);
            tadb = new TipoAlojamientodb(db);
            Temporadadb = new Temporadadb(db);
            inicializar();
        }

        private void inicializar()
        {
            numPersTxt.Text = "";
            clientNameTxt.Text = "";
            comboTAloja.Text = "";
            tipoCliTxt.Text = "";
            MsgTxt.Text = "";
            numTarjetaTxt.Text = "";
            numPersTxt.Text = "";
            fecReserva.Text = DateTime.Now.ToString("dd/MM/yyyy");
            fecEntradaTxt.Text = "";
            fecSalidaTxt.Text = "";

            comboTAloja.Items.Clear();

            List<TipoAlojamiento> taList = tadb.GetAllTiposAlojamientos();
            foreach (var ta in taList)
            {
                comboTAloja.Items.Add(ta.NombreAlojamiento);
            }

            MsgTxt.Visible = false;
            numPersTxt.Enabled = false;
            fecReserva.Enabled = false;
            fecEntradaTxt.Enabled = false;
            fecSalidaTxt.Enabled = false;
            comboTAloja.Enabled = false;
            numTarjetaTxt.Enabled = false;
        }

        private void datosReserva()
        {
            reserva.Cliente = cliente;
            reserva.ClienteId = cliente.ClienteId;
            ta = tadb.GetByNombreAlojamiento(comboTAloja.Text);
            if (ta != null)
            {
                reserva.TipoAlojamientoId = ta.TipoAlojamientoId;
                reserva.TipoAlojamiento = ta;
            }

            reserva.Estado = 0;
            reserva.numPers = Int32.Parse(numPersTxt.Text);
            DateTime dtR = Convert.ToDateTime(fecReserva.Text, CultureInfo.CurrentCulture);
            DateTime dtI = Convert.ToDateTime(fecSalidaTxt.Text, CultureInfo.CurrentCulture);
            DateTime dtF = Convert.ToDateTime(fecSalidaTxt.Text, CultureInfo.CurrentCulture);
            reserva.FechaReserva = dtR;
            reserva.FechaEntrada = dtI;
            reserva.FechaSalida = dtF;
            reserva.Habitacion = null;
            reserva.HabitacionId = null;

            //Si no tiene temporada asignada se intenta buscar una
            if (reserva.Temporada == null)
            {
                Temporada = Temporadadb.GetByInterval(dtI, dtF);
                if (Temporada != null)
                {
                    reserva.TemporadaId = Temporada.TemporadaId;
                    reserva.Temporada = Temporada;
                }
            }


        }

        private void setReserva()
        {
            fecReserva.Text = reserva.FechaReserva.ToString("dd/MM/yyyy");
            fecEntradaTxt.Text = reserva.FechaEntrada.ToString("dd/MM/yyyy");
            fecSalidaTxt.Text = reserva.FechaSalida.ToString("dd/MM/yyyy");
            numPersTxt.Text = reserva.numPers.ToString();
            comboTAloja.Text = reserva.TipoAlojamiento.NombreAlojamiento;
        }

        private void buscaReserva()
        {
            //Buscamos la reserva pendiente, si no existe crea una nueva
            if (reserva == null)
            {
                reserva = Reservadb.GetByReservaPendienteCliente(cliente.ClienteId);
                if (reserva != null)
                {
                    setReserva();
                }
                else
                {
                    reserva = new Reserva();
                    reserva.Temporada = null;
                    reserva.TemporadaId = null;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            inicializar();
            try
            {
                cliente = clientedb.GetByDocumentId(DocIdTxt.Text);

                if (cliente == null)
                {
                    MsgTxt.Text = "No existe el cliente, por favor registrélo";
                    MsgTxt.Visible = true;
                }
                else
                {
                    idCliente = cliente.ClienteId;
                    clientNameTxt.Text = cliente.Apellido1 + " " + (cliente.Apellido2 != null ? cliente.Apellido2 : "") + ", " + cliente.Nombre;
                    tipoCliTxt.Text = cliente.TipoCliente;
                    numTarjetaTxt.Text = cliente.numTarjeta;
                    numPersTxt.Enabled = true;
                    fecReserva.Enabled = true;
                    fecEntradaTxt.Enabled = true;
                    fecSalidaTxt.Enabled = true;
                    comboTAloja.Enabled = true;
                    numTarjetaTxt.Enabled = true;

                    buscaReserva();
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                datosReserva();
                if (Reservadb.Graba(reserva))
                {
                    MsgTxt.Text = "RESERVA CREADA";
                }
                else
                {
                    MsgTxt.Text = "ERROR AL CREAR RESERVA";
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
            }
            MsgTxt.Visible = true;
        }
    }
}
