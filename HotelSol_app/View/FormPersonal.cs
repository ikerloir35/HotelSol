using HotelSol.Model;
using HotelSol.Controller.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartamentoSol.Controller.db;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelSol
{
    public partial class FormPersonal : Form
    {
        HotelContext db = new HotelContext();
        Empleado empleado;
        Empleadodb empleadodb;
        Departamento dept;
        Departamentodb deptdb;
        String docId;
        int empleadoId;
        public FormPersonal()
        {
            InitializeComponent();
            empleadodb = new Empleadodb(db);
            deptdb = new Departamentodb(db);
            inicializar();
        }

        private void inicializar()
        {
            DocIdTxt.Text = "";
            usuarioTxt.Enabled = false;
            passwordTxt.Enabled = false;
            nomTxt.Enabled = false;
            ap1Txt.Enabled = false;
            ap2Txt.Enabled = false;
            telefonoTxt.Enabled = false;
            emailTxt.Enabled = false;
            paisTxt.Enabled = false;
            comboPuesto.Enabled = false;
            calleTxt.Enabled = false;
            cpTxt.Enabled = false;
            localidadTxt.Enabled = false;
            obsText.Enabled = false;
            comboDept.Enabled = false;
            usuarioTxt.Text = "";
            passwordTxt.Text = "";
            nomTxt.Text = "";
            ap1Txt.Text = "";
            ap2Txt.Text = "";
            telefonoTxt.Text = "";
            emailTxt.Text = "";
            paisTxt.Text = "";
            comboPuesto.Text = "";
            calleTxt.Text = "";
            cpTxt.Text = "";
            localidadTxt.Text = "";
            obsText.Text = "";
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            comboDept.Items.Clear();

            List<Departamento> deptList = deptdb.GetAll();
            foreach (var d in deptList)
            {
                comboDept.Items.Add(d.Descripcion);
            }
        }

        private void enableFields()
        {
            usuarioTxt.Enabled = true;
            passwordTxt.Enabled = true;
            nomTxt.Enabled = true;
            ap1Txt.Enabled = true;
            ap2Txt.Enabled = true;
            telefonoTxt.Enabled = true;
            emailTxt.Enabled = true;
            paisTxt.Enabled = true;
            comboPuesto.Enabled = true;
            calleTxt.Enabled = true;
            cpTxt.Enabled = true;
            localidadTxt.Enabled = true;
            obsText.Enabled = true;
            comboDept.Enabled = true;
        }

        private void datosForm()
        {
            usuarioTxt.Text = empleado.Usuario;
            passwordTxt.Text = empleadodb.DecryptPassword(empleado.Password);
            nomTxt.Text = empleado.Nombre;
            ap1Txt.Text = empleado.Apellido1;
            ap2Txt.Text = empleado.Apellido2;
            telefonoTxt.Text = empleado.Telefono;
            emailTxt.Text = empleado.Mail;
            paisTxt.Text = empleado.Direccion.pais;
            comboPuesto.Text = empleado.Puesto;
            calleTxt.Text = empleado.Direccion.Calle1;
            cpTxt.Text = empleado.Direccion.CP;
            localidadTxt.Text = empleado.Direccion.Localidad;
            obsText.Text = empleado.Observaciones;
            comboDept.Text = empleado.Departamento.Descripcion;
            MsgTxt.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                docId = DocIdTxt.Text;
                inicializar();
                DocIdTxt.Text = docId;
                empleado = empleadodb.GetByDocumentId(docId);
                if (empleado == null)
                {
                    empleado = new Empleado();
                }
                else
                {
                    datosForm();
                }
                enableFields();
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
                empleado.DocumentId = DocIdTxt.Text;
                empleado.Usuario = usuarioTxt.Text;
                empleado.Password = empleadodb.EncryptPassword(passwordTxt.Text);
                empleado.Nombre = nomTxt.Text;
                empleado.Apellido1 = ap1Txt.Text;
                empleado.Apellido2 = ap2Txt.Text;
                empleado.Telefono = telefonoTxt.Text;
                empleado.Mail = emailTxt.Text;
                empleado.Direccion.pais = paisTxt.Text;
                empleado.Puesto = comboPuesto.Text;
                empleado.Direccion.Calle1 = calleTxt.Text;
                empleado.Direccion.CP = cpTxt.Text;
                empleado.Direccion.Localidad = localidadTxt.Text;
                empleado.Observaciones = obsText.Text;
                empleado.Departamento.Descripcion = comboDept.Text.ToUpper();

                empleadodb.Graba(empleado);

            }
            catch (Exception ex)
            {
                MsgTxt.Text = ex.Message;
                MsgTxt.Visible = true;
            }
        }
    }
}
