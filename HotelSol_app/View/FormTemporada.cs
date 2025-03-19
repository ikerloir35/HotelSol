using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemporadaSol.Controller.db;
using HotelSol.Model;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSol
{
    public partial class FormTemporada : Form
    {
        Temporadadb tempdb = new Temporadadb();
        Temporada temp;


        public FormTemporada()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            tempIdTxt.Text = "";
            nomTempTxt.Text = "";
            fecFinTxt.Text = "";
            fecIniTxt.Text = "";
            precioTxt.Text = "";
            obsTxt.Text = "";
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            tempIdTxt.Enabled = false;
            nomTempTxt.Enabled = true;
            fecIniTxt.Enabled = false;
            fecFinTxt.Enabled = false;
            precioTxt.Enabled = false;
            obsTxt.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var nomTemp = nomTempTxt.Text.ToUpper();
            temp = tempdb.GetByNombreTemporada(nomTemp);
            inicializar();
            nomTempTxt.Text = nomTemp;
            if (temp != null)
            {
                tempIdTxt.Text = temp.TemporadaId.ToString();
                fecFinTxt.Text = temp.FechaFin.ToString("dd/MM/yyyy");
                fecIniTxt.Text = temp.FechaInicio.ToString("dd/MM/yyyy");
                precioTxt.Text = temp.Precio.ToString();
                obsTxt.Text = temp.Descripcion;
                MsgTxt.Text = "";
            }
            fecIniTxt.Enabled = true;
            fecFinTxt.Enabled = true;
            precioTxt.Enabled = true;
            obsTxt.Enabled = true;
        }

        private void setTemporada()
        {
            if (temp == null)
            {
                temp = new Temporada();
            }
            DateTime dtI = Convert.ToDateTime(fecIniTxt.Text, CultureInfo.CurrentCulture);
            DateTime dtF = Convert.ToDateTime(fecFinTxt.Text, CultureInfo.CurrentCulture);
            temp.FechaFin = dtF;
            temp.FechaInicio = dtI;
            temp.NombreTemporada = nomTempTxt.Text.ToUpper();
            temp.Precio = Double.Parse(precioTxt.Text);
            temp.Descripcion = obsTxt.Text;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                setTemporada();
                if (tempdb != null && temp != null)
                {
                    tempdb.Graba(temp);
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
