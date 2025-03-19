using HotelSol.Controller.db;
using HotelSol.Model;
using HotelSol.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSol
{
    public partial class FormPrincipal : Form
    {

        int lx, ly;
        int sw, sh;
        Boolean logeado = false;
        HotelContext db = new HotelContext();
        Empleado empleado;
        Empleadodb empleadodb;

        public FormPrincipal()
        {
            InitializeComponent();
            sw = this.Size.Width; sh = this.Size.Height;
            empleadodb = new Empleadodb(db);
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            if (!logeado) { desactiva(); }
        }


        public Boolean login()
        {
            MsgTxt.Text = "";
            MsgTxt.Visible = false;
            try
            {
                logeado = ((usuarioTxt.Text == "admin") && (passwordTxt.Text == "admin"));
                if (!logeado)
                {
                    empleado = empleadodb.GetByUser(usuarioTxt.Text);
                    if (empleado != null)
                    {
                        logeado = (passwordTxt.Text == empleadodb.DecryptPassword(empleado.Password));
                    }

                }
            }
            catch (Exception ex)
            {
                logeado = false;
            }

            if (!logeado)
            {
                MsgTxt.Text = "NO SE HA PODIDO AUTENTICAR AL USUARIO, VUELVA A INTENTARLO";
                MsgTxt.Visible = true;
            }

            return logeado;
        }


        public void activa()
        {
            userLabel.Text = usuarioTxt.Text;
            passwordTxt.Text = "";
            passwordTxt.Enabled = false;
            passwordTxt.Visible = false;
            usuarioLabel.Visible = false;
            btnLogin.Visible = false;


            passwordLabel.Visible = false;
            usuarioTxt.Visible = false;
            usuarioTxt.Enabled = false;

            btnClientes.Enabled = true;
            btnConfig.Enabled = true;
            btnConsulta.Enabled = true;
            btnInicio.Enabled = true;
            btnPersonal.Enabled = true;
            btnTarifas.Enabled = true;
            btnDatosERP.Enabled = true;
            btnVenta.Enabled = true;
            logeado = true;
        }

        public void desactiva()
        {
            passwordTxt.PasswordChar = '•';
            btnClientes.Enabled = false;
            btnConfig.Enabled = false;
            btnConsulta.Enabled = false;
            btnInicio.Enabled = false;
            btnPersonal.Enabled = false;
            btnTarifas.Enabled = false;
            btnDatosERP.Enabled = false;
            btnVenta.Enabled=false;
        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(90, 39, 39));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X; ly = this.Location.Y;
            sw = this.Size.Width; sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            if (lx > 0)
            {
                this.Location = new Point(lx, ly);
            }
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.BackColor = Color.FromArgb(241, 249, 227);
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        //METODO CERRAR FORMULARIO
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void CerrarFormulario<MiForm>() where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia existe
            if (formulario != null)
                formulario.Close();

        }

        /*
         * Cierra los formularios que no son el indicado
         */
        private void CerrarOtrosFormularios(String s)
        {
            if (s != "Cliente")
            {
                CerrarFormulario<FormCliente>();
            }

            if (s != "Personal")
            {
                CerrarFormulario<FormPersonal>();
            }

            if (s != "Tarifas")
            {
                CerrarFormulario<FormTarifas>();
            }

            if (s != "Consultas")
            {
                CerrarFormulario<FormConsultaFactura>();
            }

            if (s != "Config")
            {
                CerrarFormulario<FormHotelCfg>();
            }

            if (s != "DatosERP")
            {
                CerrarFormulario<FormDatosERP>();
            }

            if (s != "Venta")
            {
                CerrarFormulario<FormVenta>();
            }
        }


        private void setBtn_Default()
        {
            btnClientes.BackColor = Color.FromArgb(218, 228, 88);
            btnClientes.ForeColor = Color.FromArgb(90, 39, 39);

            btnPersonal.BackColor = Color.FromArgb(218, 228, 88);
            btnPersonal.ForeColor = Color.FromArgb(90, 39, 39);

            btnTarifas.BackColor = Color.FromArgb(218, 228, 88);
            btnTarifas.ForeColor = Color.FromArgb(90, 39, 39);

            btnConsulta.BackColor = Color.FromArgb(218, 228, 88);
            btnConsulta.ForeColor = Color.FromArgb(90, 39, 39);

            btnConfig.BackColor = Color.FromArgb(218, 228, 88);
            btnConfig.ForeColor = Color.FromArgb(90, 39, 39);

            btnDatosERP.BackColor = Color.FromArgb(218, 228, 88);
            btnDatosERP.ForeColor = Color.FromArgb(90, 39, 39);

            btnVenta.BackColor = Color.FromArgb(218, 228, 88);
            btnVenta.ForeColor = Color.FromArgb(90, 39, 39);


        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Cliente"); //Cierra los otros formularios
            btnClientes.BackColor = Color.FromArgb(244, 81, 30);
            btnClientes.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormCliente>();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Personal"); //Cierra los otros formularios
            btnPersonal.BackColor = Color.FromArgb(244, 81, 30);
            btnPersonal.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormPersonal>();
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Tarifas"); //Cierra los otros formularios
            btnTarifas.BackColor = Color.FromArgb(244, 81, 30);
            btnTarifas.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormTarifas>();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Consultas"); //Cierra los otros formularios
            btnConsulta.BackColor = Color.FromArgb(244, 81, 30);
            btnConsulta.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormConsultaFactura>();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Config"); //Cierra los otros formularios
            btnConfig.BackColor = Color.FromArgb(244, 81, 30);
            btnConfig.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormHotelCfg>();
        }

        private void btnDatosERP_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("DatosERP"); //Cierra los otros formularios
            btnDatosERP.BackColor = Color.FromArgb(244, 81, 30);
            btnDatosERP.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormDatosERP>();
        }


        private void btnVenta_Click(object sender, EventArgs e)
        {
            setBtn_Default();
            CerrarOtrosFormularios("Venta"); //Cierra los otros formularios
            btnVenta.BackColor = Color.FromArgb(244, 81, 30);
            btnVenta.ForeColor = Color.WhiteSmoke;
            AbrirFormulario<FormVenta>();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CerrarOtrosFormularios("Inicio"); //Cierra todos los formularios
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!logeado)
            {
                desactiva();
                if (login())
                {
                    activa();
                }
            }
        }

    }
}
