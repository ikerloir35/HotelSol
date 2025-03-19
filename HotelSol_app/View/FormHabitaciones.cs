using HabitacionSol.Controller.db;
using HotelSol.Controller.db;
using HotelSol.Model;
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
    public partial class FormHabitaciones : Form
    {
        Habitaciondb habdb = new Habitaciondb();
        Habitacion? hab;
        int habId;

        public FormHabitaciones()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            numPersTxt.Text = "";
            tipoHabTxt.Text = "";
            precioTxt.Text = "";
            estadoTxt.Text = "";
            obsTxt.Text = "";
            MsgTxt.Text = "";

            numPersTxt.Enabled = false;
            tipoHabTxt.Enabled = false;
            tipoHabTxt.Enabled = false;
            precioTxt.Enabled = false;
            estadoTxt.Enabled = false;
            obsTxt.Enabled = false;
            MsgTxt.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(numHabTxt.Text);
                Habitacion? hab = habdb.GetByNumHabitacion(id);
                if (hab != null)
                {
                    habId = hab.HabitacionId;
                    numPersTxt.Text = hab.NumeroOcupantes.ToString();
                    tipoHabTxt.Text = hab.tipoHabitacion;
                    numHabTxt.Text = hab.numHab.ToString();
                    tipoHabTxt.Text = hab.tipoHabitacion;
                    precioTxt.Text = hab.Precio.ToString();
                    estadoTxt.Text = hab.Estado;
                    obsTxt.Text = hab.Descripcion;
                    MsgTxt.Text = "";
                }
                else inicializar() ;
                numPersTxt.Enabled = true;
                tipoHabTxt.Enabled = true;
                tipoHabTxt.Enabled = true;
                precioTxt.Enabled = true;
                estadoTxt.Enabled = true;
                obsTxt.Enabled = true;
                MsgTxt.Enabled = false;
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
            }

        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void setHabitacion()
        {
            if (hab == null)
            {
                hab = new Habitacion();
            }
            hab.HabitacionId = habId;
            hab.NumeroOcupantes = Int32.Parse(numPersTxt.Text);
            hab.tipoHabitacion = tipoHabTxt.Text;
            hab.numHab = Int32.Parse(numHabTxt.Text);
            hab.tipoHabitacion = tipoHabTxt.Text;
            hab.Precio = Double.Parse(precioTxt.Text);
            hab.Estado = estadoTxt.Text;
            hab.Descripcion = obsTxt.Text;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                setHabitacion();
                if (habdb != null && hab != null)
                {
                    habdb.Graba(hab);
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
