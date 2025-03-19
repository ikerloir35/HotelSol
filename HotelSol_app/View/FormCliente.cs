using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSol.Controller.lib;

namespace HotelSol
{
    public partial class FormCliente : Form
    {

        FormsActions forms = new FormsActions();

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            msgLabel.Text = "";

        }

        private void setBtn_Default()
        {
            btnCheckIn.BackColor = Color.FromArgb(218, 228, 88);
            btnCheckIn.ForeColor = Color.FromArgb(90, 39, 39);

            btnCheckOut.BackColor = Color.FromArgb(218, 228, 88);
            btnCheckOut.ForeColor = Color.FromArgb(90, 39, 39);

            btnRegistro.BackColor = Color.FromArgb(218, 228, 88);
            btnRegistro.ForeColor = Color.FromArgb(90, 39, 39);

            btnReserva.BackColor = Color.FromArgb(218, 228, 88);
            btnReserva.ForeColor = Color.FromArgb(90, 39, 39);

            btnConsultar.BackColor = Color.FromArgb(218, 228, 88);
            btnConsultar.ForeColor = Color.FromArgb(90, 39, 39);

        }

        /*
 * Cierra los formularios que no son el indicado
 */
        private void CerrarOtrosFormularios(String s)
        {
            if (s != "CheckIn")
            {
                forms.CerrarFormulario<FormCheckIn>(panelCliente);
            }

            if (s != "CheckOut")
            {
                forms.CerrarFormulario<FormCheckOut>(panelCliente);
            }

            if (s != "Registrar")
            {
                forms.CerrarFormulario<FormRegistrar>(panelCliente);
            }

            if (s != "Reserva")
            {
                forms.CerrarFormulario<FormReserva>(panelCliente);
            }
            if (s != "Consultar")
            {
                forms.CerrarFormulario<FormConsulta>(panelCliente);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Consultar");
            btnConsultar.BackColor = Color.FromArgb(244, 81, 30);
            btnConsultar.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormConsulta>(panelCliente);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("CheckIn");
            btnCheckIn.BackColor = Color.FromArgb(244, 81, 30);
            btnCheckIn.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormCheckIn>(panelCliente);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("CheckOut");
            btnCheckOut.BackColor = Color.FromArgb(244, 81, 30);
            btnCheckOut.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormCheckOut>(panelCliente);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Registrar");
            btnRegistro.BackColor = Color.FromArgb(244, 81, 30);
            btnRegistro.ForeColor = Color.WhiteSmoke; 
            forms.AbrirFormulario<FormRegistrar>(panelCliente);
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Reserva");
            btnReserva.BackColor = Color.FromArgb(244, 81, 30);
            btnReserva.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormReserva>(panelCliente);
        }
    }
}
