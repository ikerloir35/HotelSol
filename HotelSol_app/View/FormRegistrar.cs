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
using HotelSol.Controller.db;
using HotelSol.Model;

namespace HotelSol
{
    public partial class FormRegistrar : Form
    {

        HotelContext? db = new HotelContext();
        Clientedb? clientedb;
        Cliente? cliente;

        int idClientInt;

        public FormRegistrar()
        {
            InitializeComponent();
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            clientedb = new Clientedb(db);
        }


        private void inicializar()
        {
            idClientInt = 0;
            idClienteTxt.Text = "";
            numTarjetaTxt.Text = "";
            tipoCliTxt.Text = "";
            MsgTxt.Text = "";
            nomTxt.Text = "";
            paisTxt.Text = "";
            localidadTxt.Text = "";
            cpTxt.Text = "";
            calleTxt.Text = "";
            ap1Txt.Text = "";
            ap2Txt.Text = "";
            tipoCliTxt.Text = "";
            numTarjetaTxt.Text = "";
            MsgTxt.Visible = false;
            nomTxt.Enabled = false;
            paisTxt.Enabled = false;
            localidadTxt.Enabled = false;
            cpTxt.Enabled = false;
            calleTxt.Enabled = false;
            ap1Txt.Enabled = false;
            ap2Txt.Enabled = false;
            tipoCliTxt.Enabled = false;
            numTarjetaTxt.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            inicializar();
            try
            {
                cliente = clientedb.GetByDocumentId(DocIdTxt.Text);
                if (cliente != null)
                {
                    idClientInt = cliente.ClienteId;
                    idClienteTxt.Text = cliente.ClienteId.ToString();
                    nomTxt.Text = cliente.Nombre;
                    paisTxt.Text = cliente.Direccion.pais;
                    localidadTxt.Text = cliente.Direccion.Localidad;
                    cpTxt.Text = cliente.Direccion.CP;
                    calleTxt.Text = cliente.Direccion.Calle1;
                    ap1Txt.Text = cliente.Apellido1;
                    ap2Txt.Text = cliente.Apellido2;
                    numTarjetaTxt.Text = cliente.numTarjeta;
                    tipoCliTxt.Text = cliente.TipoCliente;
                }
                nomTxt.Enabled = true;
                paisTxt.Enabled = true;
                localidadTxt.Enabled = true;
                cpTxt.Enabled = true;
                calleTxt.Enabled = true;
                ap1Txt.Enabled = true;
                ap2Txt.Enabled = true;
                tipoCliTxt.Enabled = true;
                numTarjetaTxt.Enabled = true;
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
                setCliente();
                if (clientedb != null && cliente != null) {
                    clientedb.Graba(cliente);
                }
            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message; MsgTxt.Visible = true;
            }
        }

        private void setCliente()
        {
            if (cliente == null)
            {
                cliente = new Cliente();
            }
            cliente.ClienteId = idClientInt;  
            cliente.DocumentId = DocIdTxt.Text;
            cliente.Nombre = nomTxt.Text;
            cliente.Direccion.pais = paisTxt.Text;
            cliente.Direccion.Localidad = localidadTxt.Text;
            cliente.Direccion.CP = cpTxt.Text;
            cliente.Direccion.Calle1 = calleTxt.Text;
            cliente.Apellido1 = ap1Txt.Text;
            cliente.Apellido2 = ap2Txt.Text;
            cliente.TipoCliente = tipoCliTxt.Text; 
            cliente.numTarjeta = numTarjetaTxt.Text;
        }
    }
}
