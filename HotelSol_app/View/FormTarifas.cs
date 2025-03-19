using HotelSol.Controller.lib;
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
    public partial class FormTarifas : Form
    {
        FormsActions forms = new FormsActions();
        public FormTarifas()
        {
            InitializeComponent();
        }

        private void setBtn_Default()
        {
            btnHabitacion.BackColor = Color.FromArgb(218, 228, 88);
            btnHabitacion.ForeColor = Color.FromArgb(90, 39, 39);
            btnTipoAlojamiento.BackColor = Color.FromArgb(218, 228, 88);
            btnTipoAlojamiento.ForeColor = Color.FromArgb(90, 39, 39);
            btnTemporada.BackColor = Color.FromArgb(218, 228, 88);
            btnTemporada.ForeColor = Color.FromArgb(90, 39, 39);

        }

        /*
 * Cierra los formularios que no son el indicado
 */
        private void CerrarOtrosFormularios(String s)
        {
            if (s != "Habitaciones")
            {
                forms.CerrarFormulario<FormHabitaciones>(panelTarifa);
            }
            if (s != "Alojamiento")
            {
                forms.CerrarFormulario<FormTipoAlojamiento>(panelTarifa);
            }

            if (s != "Temporada")
            {
                forms.CerrarFormulario<FormTemporada>(panelTarifa);
            }

        }



        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Habitaciones");
            btnHabitacion.BackColor = Color.FromArgb(244, 81, 30);
            btnHabitacion.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormHabitaciones>(panelTarifa);
        }

        private void btnTipoAlojamiento_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Alojamiento");
            btnTipoAlojamiento.BackColor = Color.FromArgb(244, 81, 30);
            btnTipoAlojamiento.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormTipoAlojamiento>(panelTarifa);
        }

        private void btnTemporada_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Temporada");
            btnTemporada.BackColor = Color.FromArgb(244, 81, 30);
            btnTemporada.ForeColor = Color.WhiteSmoke;
            forms.AbrirFormulario<FormTemporada>(panelTarifa);
        }
    }
}
