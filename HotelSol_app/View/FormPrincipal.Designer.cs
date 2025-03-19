namespace HotelSol
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panelContenedor = new Panel();
            panelformularios = new Panel();
            MsgTxt = new Label();
            btnLogin = new Button();
            passwordTxt = new TextBox();
            passwordLabel = new Label();
            usuarioTxt = new TextBox();
            usuarioLabel = new Label();
            panelMenu = new Panel();
            btnVenta = new Button();
            btnDatosERP = new Button();
            btnInicio = new Button();
            btnConfig = new Button();
            btnSalir = new Button();
            btnConsulta = new Button();
            btnTarifas = new Button();
            btnPersonal = new Button();
            btnClientes = new Button();
            panelTitulo = new Panel();
            userLabel = new Label();
            label1 = new Label();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            pictureBox1 = new PictureBox();
            Titol = new Label();
            panelContenedor.SuspendLayout();
            panelformularios.SuspendLayout();
            panelMenu.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(241, 249, 227);
            panelContenedor.Controls.Add(panelformularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1400, 800);
            panelContenedor.TabIndex = 0;
            // 
            // panelformularios
            // 
            panelformularios.BackgroundImageLayout = ImageLayout.Zoom;
            panelformularios.Controls.Add(MsgTxt);
            panelformularios.Controls.Add(btnLogin);
            panelformularios.Controls.Add(passwordTxt);
            panelformularios.Controls.Add(passwordLabel);
            panelformularios.Controls.Add(usuarioTxt);
            panelformularios.Controls.Add(usuarioLabel);
            panelformularios.Dock = DockStyle.Fill;
            panelformularios.Location = new Point(182, 86);
            panelformularios.Name = "panelformularios";
            panelformularios.Size = new Size(1218, 714);
            panelformularios.TabIndex = 2;
            // 
            // MsgTxt
            // 
            MsgTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MsgTxt.AutoSize = true;
            MsgTxt.Font = new Font("Cascadia Code", 12F);
            MsgTxt.ForeColor = Color.Red;
            MsgTxt.Location = new Point(17, 673);
            MsgTxt.Margin = new Padding(4, 0, 4, 0);
            MsgTxt.Name = "MsgTxt";
            MsgTxt.Size = new Size(64, 21);
            MsgTxt.TabIndex = 87;
            MsgTxt.Text = "MsgTxt";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(244, 81, 30);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 12F);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(338, 307);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 40);
            btnLogin.TabIndex = 86;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Cascadia Code", 12F);
            passwordTxt.Location = new Point(249, 245);
            passwordTxt.Margin = new Padding(4, 3, 4, 3);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(200, 26);
            passwordTxt.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Cascadia Code", 12F);
            passwordLabel.Location = new Point(249, 221);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(82, 21);
            passwordLabel.TabIndex = 85;
            passwordLabel.Text = "Password";
            // 
            // usuarioTxt
            // 
            usuarioTxt.Font = new Font("Cascadia Code", 12F);
            usuarioTxt.Location = new Point(251, 168);
            usuarioTxt.Margin = new Padding(4, 3, 4, 3);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(198, 26);
            usuarioTxt.TabIndex = 1;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new Font("Cascadia Code", 12F);
            usuarioLabel.Location = new Point(249, 144);
            usuarioLabel.Margin = new Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(73, 21);
            usuarioLabel.TabIndex = 84;
            usuarioLabel.Text = "Usuario";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(218, 228, 88);
            panelMenu.Controls.Add(btnVenta);
            panelMenu.Controls.Add(btnDatosERP);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnConsulta);
            panelMenu.Controls.Add(btnTarifas);
            panelMenu.Controls.Add(btnPersonal);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 86);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(182, 714);
            panelMenu.TabIndex = 1;
            // 
            // btnVenta
            // 
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnVenta.ForeColor = Color.FromArgb(90, 39, 39);
            btnVenta.Location = new Point(3, 349);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(176, 34);
            btnVenta.TabIndex = 8;
            btnVenta.Text = "Venta Productos";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnDatosERP
            // 
            btnDatosERP.FlatAppearance.BorderSize = 0;
            btnDatosERP.FlatStyle = FlatStyle.Flat;
            btnDatosERP.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnDatosERP.ForeColor = Color.FromArgb(90, 39, 39);
            btnDatosERP.Location = new Point(3, 299);
            btnDatosERP.Name = "btnDatosERP";
            btnDatosERP.Size = new Size(176, 34);
            btnDatosERP.TabIndex = 7;
            btnDatosERP.Text = "Datos ERP";
            btnDatosERP.UseVisualStyleBackColor = true;
            btnDatosERP.Click += btnDatosERP_Click;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnInicio.ForeColor = Color.FromArgb(90, 39, 39);
            btnInicio.Location = new Point(3, 599);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(176, 34);
            btnInicio.TabIndex = 6;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnConfig.ForeColor = Color.FromArgb(90, 39, 39);
            btnConfig.Location = new Point(3, 249);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(176, 34);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "Configuración";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnSalir.ForeColor = Color.FromArgb(90, 39, 39);
            btnSalir.Location = new Point(3, 649);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(176, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnConsulta.ForeColor = Color.FromArgb(90, 39, 39);
            btnConsulta.Location = new Point(3, 199);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(176, 34);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "Lista Facturas";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnTarifas
            // 
            btnTarifas.FlatAppearance.BorderSize = 0;
            btnTarifas.FlatStyle = FlatStyle.Flat;
            btnTarifas.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnTarifas.ForeColor = Color.FromArgb(90, 39, 39);
            btnTarifas.Location = new Point(3, 148);
            btnTarifas.Name = "btnTarifas";
            btnTarifas.Size = new Size(176, 34);
            btnTarifas.TabIndex = 2;
            btnTarifas.Text = "Tarifas";
            btnTarifas.UseVisualStyleBackColor = true;
            btnTarifas.Click += btnTarifas_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.FlatAppearance.BorderSize = 0;
            btnPersonal.FlatStyle = FlatStyle.Flat;
            btnPersonal.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnPersonal.ForeColor = Color.FromArgb(90, 39, 39);
            btnPersonal.Location = new Point(3, 99);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(176, 34);
            btnPersonal.TabIndex = 1;
            btnPersonal.Text = "Personal";
            btnPersonal.UseVisualStyleBackColor = true;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Arial Rounded MT Bold", 14.25F);
            btnClientes.ForeColor = Color.FromArgb(90, 39, 39);
            btnClientes.Location = new Point(3, 49);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(176, 34);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnCliente_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(245, 248, 210);
            panelTitulo.Controls.Add(userLabel);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Controls.Add(btnMinimizar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Controls.Add(btnRestaurar);
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(pictureBox1);
            panelTitulo.Controls.Add(Titol);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1400, 86);
            panelTitulo.TabIndex = 0;
            panelTitulo.MouseMove += panelTitulo_MouseMove;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.FromArgb(90, 39, 39);
            userLabel.Location = new Point(1052, 42);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(90, 17);
            userLabel.TabIndex = 7;
            userLabel.Text = "No logeado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(90, 39, 39);
            label1.Location = new Point(1052, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1222, 25);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(33, 34);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 5;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1302, 25);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(33, 34);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 4;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1263, 25);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(33, 34);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1261, 25);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(35, 34);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_solete;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Titol
            // 
            Titol.AutoSize = true;
            Titol.FlatStyle = FlatStyle.Flat;
            Titol.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titol.ForeColor = Color.FromArgb(90, 39, 39);
            Titol.Location = new Point(103, 6);
            Titol.Name = "Titol";
            Titol.Size = new Size(313, 75);
            Titol.TabIndex = 0;
            Titol.Text = "Hotel Sol";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 400);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            panelContenedor.ResumeLayout(false);
            panelformularios.ResumeLayout(false);
            panelformularios.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelTitulo;
        private Panel panelMenu;
        private Panel panelformularios;
        private Label Titol;
        private PictureBox pictureBox1;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private PictureBox btnMinimizar;
        private Button btnClientes;
        private Button btnTarifas;
        private Button btnPersonal;
        private Button btnConsulta;
        private Button btnSalir;
        private Button btnConfig;
        private Button btnInicio;
        private Label userLabel;
        private Label label1;
        private TextBox passwordTxt;
        private Label passwordLabel;
        private TextBox usuarioTxt;
        private Label usuarioLabel;
        private Button btnLogin;
        private Label MsgTxt;
        private Button btnDatosERP;
        private Button btnVenta;
    }
}