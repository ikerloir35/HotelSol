namespace HotelSol
{
    partial class FormTipoAlojamiento
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
            btnGrabar = new Button();
            MsgTxt = new Label();
            btnBuscar = new Button();
            obsTxt = new TextBox();
            label5 = new Label();
            precioTxt = new TextBox();
            label2 = new Label();
            alojaIdTxt = new TextBox();
            label13 = new Label();
            tipoAlojaTxt = new TextBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGrabar.BackColor = Color.FromArgb(244, 81, 30);
            btnGrabar.FlatAppearance.BorderColor = Color.White;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnGrabar.ForeColor = Color.WhiteSmoke;
            btnGrabar.Location = new Point(910, 459);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(175, 73);
            btnGrabar.TabIndex = 76;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // MsgTxt
            // 
            MsgTxt.AutoSize = true;
            MsgTxt.Font = new Font("Cascadia Code", 12F);
            MsgTxt.ForeColor = Color.Red;
            MsgTxt.Location = new Point(41, 536);
            MsgTxt.Margin = new Padding(4, 0, 4, 0);
            MsgTxt.Name = "MsgTxt";
            MsgTxt.Size = new Size(64, 21);
            MsgTxt.TabIndex = 75;
            MsgTxt.Text = "MsgTxt";
            MsgTxt.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 81, 30);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.Location = new Point(449, 109);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 29);
            btnBuscar.TabIndex = 74;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // obsTxt
            // 
            obsTxt.Enabled = false;
            obsTxt.Font = new Font("Cascadia Code", 12F);
            obsTxt.Location = new Point(221, 223);
            obsTxt.Margin = new Padding(4, 3, 4, 3);
            obsTxt.Name = "obsTxt";
            obsTxt.Size = new Size(864, 26);
            obsTxt.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(41, 223);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 73;
            label5.Text = "Descripcion";
            // 
            // precioTxt
            // 
            precioTxt.Enabled = false;
            precioTxt.Font = new Font("Cascadia Code", 12F);
            precioTxt.Location = new Point(221, 167);
            precioTxt.Margin = new Padding(4, 3, 4, 3);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(198, 26);
            precioTxt.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(41, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 71;
            label2.Text = "Alojamiento ID";
            // 
            // alojaIdTxt
            // 
            alojaIdTxt.Font = new Font("Cascadia Code", 12F);
            alojaIdTxt.Location = new Point(221, 65);
            alojaIdTxt.Margin = new Padding(4, 3, 4, 3);
            alojaIdTxt.Name = "alojaIdTxt";
            alojaIdTxt.Size = new Size(198, 26);
            alojaIdTxt.TabIndex = 62;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F);
            label13.Location = new Point(41, 167);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(64, 21);
            label13.TabIndex = 70;
            label13.Text = "Precio";
            // 
            // tipoAlojaTxt
            // 
            tipoAlojaTxt.Enabled = false;
            tipoAlojaTxt.Font = new Font("Cascadia Code", 12F);
            tipoAlojaTxt.Location = new Point(221, 111);
            tipoAlojaTxt.Margin = new Padding(4, 3, 4, 3);
            tipoAlojaTxt.Name = "tipoAlojaTxt";
            tipoAlojaTxt.Size = new Size(198, 26);
            tipoAlojaTxt.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 12F);
            label11.Location = new Point(41, 111);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(154, 21);
            label11.TabIndex = 68;
            label11.Text = "Tipo Alojamiento";
            // 
            // FormTipoAlojamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 576);
            Controls.Add(btnGrabar);
            Controls.Add(MsgTxt);
            Controls.Add(btnBuscar);
            Controls.Add(obsTxt);
            Controls.Add(label5);
            Controls.Add(precioTxt);
            Controls.Add(label2);
            Controls.Add(alojaIdTxt);
            Controls.Add(label13);
            Controls.Add(tipoAlojaTxt);
            Controls.Add(label11);
            Name = "FormTipoAlojamiento";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGrabar;
        private Label MsgTxt;
        private Button btnBuscar;
        private TextBox obsTxt;
        private Label label5;
        private TextBox precioTxt;
        private Label label2;
        private TextBox alojaIdTxt;
        private Label label13;
        private TextBox tipoAlojaTxt;
        private Label label11;
    }
}