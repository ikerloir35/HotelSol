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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSol
{
    public partial class FormConsulta : Form
    {
        HotelContext db = new HotelContext();
        Reservadb reservadb;
        Reserva? reserva;
        Facturadb facturadb;
        Factura? factura;
        int idClient;
        String formatDate;
        public FormConsulta()
        {
            InitializeComponent();
            reservadb = new Reservadb(db);
            facturadb = new Facturadb(db);
            inicializar();
            formatDate = "dd/MM/yyyy";
        }

        private void inicializar()
        {
            clientNameTxt.Text = "";
            tipoCliTxt.Text = "";
            numPersTxt.Text = "";
            tipoHabTxt.Text = "";
            habAsigTxt.Text = "";
            fecReserva.Text = "";
            fecSalidaTxt.Text = "";
            fecEntradaTxt.Text = "";
            EstadoTxt.Text = "";
            tAlojTxt.Text = "";
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            numPersTxt.Enabled = true;
            reserva = null;
            labelFact.Visible = false;
            labelTotal.Visible = false;
            factNumTxt.Visible = false;
            totalTxt.Visible = false;
            habAsigTxt.Visible  = false;
            labelHabAsignada.Visible = false;
            labelTipoHab.Visible = false;
            tipoHabTxt.Visible  = false;
            labelTaloj.Visible = false;
        }

        private void setForm()
        {
            clientNameTxt.Text = reserva.Cliente.Apellido1 + " " + (reserva.Cliente.Apellido2 != null ? reserva.Cliente.Apellido2 : "") + ", " + reserva.Cliente.Nombre;
            tipoCliTxt.Text = reserva.Cliente.TipoCliente;
            fecReserva.Text = reserva.FechaReserva.ToString(formatDate);
            fecSalidaTxt.Text = reserva.FechaSalida.ToString(formatDate);
            fecEntradaTxt.Text = reserva.FechaEntrada.ToString(formatDate);
            numPersTxt.Text = reserva.numPers.ToString();
            if (reserva.Estado == 0)
            {
                EstadoTxt.Text = "PENDIENTE";
            }
            if (reserva.Estado == 1 || reserva.Estado == 2)
            {
                EstadoTxt.Text = "EN CURSO";
                habAsigTxt.Visible = true;
                labelHabAsignada.Visible = true;
                labelTipoHab.Visible = true;
                tipoHabTxt.Visible = true;
                labelTaloj.Visible = true;
                if (reserva.Habitacion != null)
                {
                    habAsigTxt.Text = reserva.Habitacion.numHab.ToString();
                    tipoHabTxt.Text = reserva.Habitacion.tipoHabitacion.ToString();
                }
                if (reserva.TipoAlojamiento != null)
                {
                    tAlojTxt.Text = reserva.TipoAlojamiento.NombreAlojamiento;
                }

            } 
            
            if (reserva.Estado == 2)
            {
                EstadoTxt.Text = "FINALIZADA";
                labelFact.Visible = true;
                labelTotal.Visible = true;
                factNumTxt.Visible = true;
                totalTxt.Visible = true;
                factura = facturadb.GetFacturasReserva(reserva.ReservaId).First();
                factNumTxt.Text = factura.FacturaId.ToString();
                totalTxt.Text = factura.Total.ToString();
            }


        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                inicializar();
                reserva = reservadb.GetLastByCliente(DocIdTxt.Text);
                if (reserva != null)
                {
                    setForm();
                }
                else
                {
                    MsgTxt.Text = "NO HAY RESERVAS PARA ESTE CLIENTE";
                    MsgTxt.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
            }
        }

    }
}
