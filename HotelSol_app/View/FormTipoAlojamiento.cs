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
using TipoAlojamientoSol.Controller.db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSol
{
    public partial class FormTipoAlojamiento : Form
    {
        TipoAlojamientodb tadb = new TipoAlojamientodb();
        TipoAlojamiento ta;
        public FormTipoAlojamiento()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            alojaIdTxt.Text = "";
            tipoAlojaTxt.Text = "";
            precioTxt.Text = "";
            obsTxt.Text = "";
            MsgTxt.Text = "";
            alojaIdTxt.Enabled = false;
            MsgTxt.Visible = false;
            tipoAlojaTxt.Enabled = true;
            precioTxt.Enabled = false;
            obsTxt.Enabled = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var nomAloja = tipoAlojaTxt.Text.ToUpper();
            ta = tadb.GetByNombreAlojamiento(nomAloja);

            if (ta != null)
            {
                alojaIdTxt.Text = ta.TipoAlojamientoId.ToString();
                precioTxt.Text = ta.Precio.ToString();
                obsTxt.Text = ta.Descripcion;
            }
            else
            {
                inicializar();
                tipoAlojaTxt.Text = nomAloja;
            }
            precioTxt.Enabled = true;
            obsTxt.Enabled = true;
        }

        private void setAlojamiento()
        {
            if (ta == null)
            {
                ta = new TipoAlojamiento();
            }
            ta.NombreAlojamiento= tipoAlojaTxt.Text.ToUpper();
            ta.Descripcion = obsTxt.Text;
            ta.Precio = Double.Parse(precioTxt.Text);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
             try
            {
                setAlojamiento();
                if (tadb != null && ta != null)
                {
                    tadb.Graba(ta);
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
