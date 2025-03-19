namespace HotelSol
{
    partial class FormTemporada
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
            tempIdTxt = new TextBox();
            label13 = new Label();
            nomTempTxt = new TextBox();
            label11 = new Label();
            fecIniTxt = new TextBox();
            label1 = new Label();
            fecFinTxt = new TextBox();
            label3 = new Label();
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
            btnGrabar.Location = new Point(910, 457);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(175, 73);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // MsgTxt
            // 
            MsgTxt.AutoSize = true;
            MsgTxt.Font = new Font("Cascadia Code", 12F);
            MsgTxt.ForeColor = Color.Red;
            MsgTxt.Location = new Point(41, 534);
            MsgTxt.Margin = new Padding(4, 0, 4, 0);
            MsgTxt.Name = "MsgTxt";
            MsgTxt.Size = new Size(64, 21);
            MsgTxt.TabIndex = 86;
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
            btnBuscar.Location = new Point(449, 108);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 29);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // obsTxt
            // 
            obsTxt.Enabled = false;
            obsTxt.Font = new Font("Cascadia Code", 12F);
            obsTxt.Location = new Point(221, 283);
            obsTxt.Margin = new Padding(4, 3, 4, 3);
            obsTxt.Name = "obsTxt";
            obsTxt.Size = new Size(864, 26);
            obsTxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(41, 283);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 84;
            label5.Text = "Descripcion";
            // 
            // precioTxt
            // 
            precioTxt.Enabled = false;
            precioTxt.Font = new Font("Cascadia Code", 12F);
            precioTxt.Location = new Point(221, 227);
            precioTxt.Margin = new Padding(4, 3, 4, 3);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(198, 26);
            precioTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(41, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 83;
            label2.Text = "Temporada ID";
            // 
            // tempIdTxt
            // 
            tempIdTxt.Enabled = false;
            tempIdTxt.Font = new Font("Cascadia Code", 12F);
            tempIdTxt.Location = new Point(221, 63);
            tempIdTxt.Margin = new Padding(4, 3, 4, 3);
            tempIdTxt.Name = "tempIdTxt";
            tempIdTxt.Size = new Size(198, 26);
            tempIdTxt.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F);
            label13.Location = new Point(41, 227);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(64, 21);
            label13.TabIndex = 82;
            label13.Text = "Precio";
            // 
            // nomTempTxt
            // 
            nomTempTxt.Font = new Font("Cascadia Code", 12F);
            nomTempTxt.Location = new Point(221, 109);
            nomTempTxt.Margin = new Padding(4, 3, 4, 3);
            nomTempTxt.Name = "nomTempTxt";
            nomTempTxt.Size = new Size(198, 26);
            nomTempTxt.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 12F);
            label11.Location = new Point(41, 109);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(154, 21);
            label11.TabIndex = 81;
            label11.Text = "Nombre Temporada";
            // 
            // fecIniTxt
            // 
            fecIniTxt.Enabled = false;
            fecIniTxt.Font = new Font("Cascadia Code", 12F);
            fecIniTxt.Location = new Point(221, 168);
            fecIniTxt.Margin = new Padding(4, 3, 4, 3);
            fecIniTxt.Name = "fecIniTxt";
            fecIniTxt.Size = new Size(198, 26);
            fecIniTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F);
            label1.Location = new Point(41, 168);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 89;
            label1.Text = "Intervalo Fechas";
            // 
            // fecFinTxt
            // 
            fecFinTxt.Enabled = false;
            fecFinTxt.Font = new Font("Cascadia Code", 12F);
            fecFinTxt.Location = new Point(449, 168);
            fecFinTxt.Margin = new Padding(4, 3, 4, 3);
            fecFinTxt.Name = "fecFinTxt";
            fecFinTxt.Size = new Size(198, 26);
            fecFinTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(670, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 90;
            label3.Text = "DD/MM/AAAA";
            // 
            // FormTemporada
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 576);
            Controls.Add(label3);
            Controls.Add(fecFinTxt);
            Controls.Add(fecIniTxt);
            Controls.Add(label1);
            Controls.Add(btnGrabar);
            Controls.Add(MsgTxt);
            Controls.Add(btnBuscar);
            Controls.Add(obsTxt);
            Controls.Add(label5);
            Controls.Add(precioTxt);
            Controls.Add(label2);
            Controls.Add(tempIdTxt);
            Controls.Add(label13);
            Controls.Add(nomTempTxt);
            Controls.Add(label11);
            Name = "FormTemporada";
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
        private TextBox tempIdTxt;
        private Label label13;
        private TextBox nomTempTxt;
        private Label label11;
        private TextBox fecIniTxt;
        private Label label1;
        private TextBox fecFinTxt;
        private Label label3;
    }
}