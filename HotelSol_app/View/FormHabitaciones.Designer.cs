namespace HotelSol
{
    partial class FormHabitaciones
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
            label13 = new Label();
            numPersTxt = new TextBox();
            label12 = new Label();
            tipoHabTxt = new TextBox();
            label11 = new Label();
            numHabTxt = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            obsTxt = new TextBox();
            btnBuscar = new Button();
            MsgTxt = new Label();
            btnGrabar = new Button();
            precioTxt = new TextBox();
            estadoTxt = new ComboBox();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F);
            label13.Location = new Point(41, 222);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(64, 21);
            label13.TabIndex = 49;
            label13.Text = "Precio";
            // 
            // numPersTxt
            // 
            numPersTxt.Enabled = false;
            numPersTxt.Font = new Font("Cascadia Code", 12F);
            numPersTxt.Location = new Point(221, 167);
            numPersTxt.Margin = new Padding(4, 3, 4, 3);
            numPersTxt.Name = "numPersTxt";
            numPersTxt.Size = new Size(198, 26);
            numPersTxt.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 12F);
            label12.Location = new Point(41, 170);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(127, 21);
            label12.TabIndex = 47;
            label12.Text = "Num. Personas";
            // 
            // tipoHabTxt
            // 
            tipoHabTxt.Enabled = false;
            tipoHabTxt.Font = new Font("Cascadia Code", 12F);
            tipoHabTxt.Location = new Point(221, 121);
            tipoHabTxt.Margin = new Padding(4, 3, 4, 3);
            tipoHabTxt.Name = "tipoHabTxt";
            tipoHabTxt.Size = new Size(198, 26);
            tipoHabTxt.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code", 12F);
            label11.Location = new Point(41, 121);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(145, 21);
            label11.TabIndex = 45;
            label11.Text = "Tipo Habitación";
            // 
            // numHabTxt
            // 
            numHabTxt.Font = new Font("Cascadia Code", 12F);
            numHabTxt.Location = new Point(221, 75);
            numHabTxt.Margin = new Padding(4, 3, 4, 3);
            numHabTxt.Name = "numHabTxt";
            numHabTxt.Size = new Size(198, 26);
            numHabTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(41, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 52;
            label2.Text = "Número Habitación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(41, 277);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 56;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(41, 333);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 57;
            label5.Text = "Descripcion";
            // 
            // obsTxt
            // 
            obsTxt.Enabled = false;
            obsTxt.Font = new Font("Cascadia Code", 12F);
            obsTxt.Location = new Point(221, 333);
            obsTxt.Margin = new Padding(4, 3, 4, 3);
            obsTxt.Name = "obsTxt";
            obsTxt.Size = new Size(864, 26);
            obsTxt.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 81, 30);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.Location = new Point(449, 75);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 29);
            btnBuscar.TabIndex = 59;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // MsgTxt
            // 
            MsgTxt.AutoSize = true;
            MsgTxt.Font = new Font("Cascadia Code", 12F);
            MsgTxt.ForeColor = Color.Red;
            MsgTxt.Location = new Point(41, 546);
            MsgTxt.Margin = new Padding(4, 0, 4, 0);
            MsgTxt.Name = "MsgTxt";
            MsgTxt.Size = new Size(64, 21);
            MsgTxt.TabIndex = 60;
            MsgTxt.Text = "MsgTxt";
            MsgTxt.Visible = false;
            // 
            // btnGrabar
            // 
            btnGrabar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGrabar.BackColor = Color.FromArgb(244, 81, 30);
            btnGrabar.FlatAppearance.BorderColor = Color.White;
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnGrabar.ForeColor = Color.WhiteSmoke;
            btnGrabar.Location = new Point(910, 473);
            btnGrabar.Margin = new Padding(4, 3, 4, 3);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(175, 73);
            btnGrabar.TabIndex = 61;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // precioTxt
            // 
            precioTxt.Enabled = false;
            precioTxt.Font = new Font("Cascadia Code", 12F);
            precioTxt.Location = new Point(221, 222);
            precioTxt.Margin = new Padding(4, 3, 4, 3);
            precioTxt.Name = "precioTxt";
            precioTxt.Size = new Size(198, 26);
            precioTxt.TabIndex = 4;
            // 
            // estadoTxt
            // 
            estadoTxt.Font = new Font("Cascadia Code", 12F);
            estadoTxt.FormattingEnabled = true;
            estadoTxt.Items.AddRange(new object[] { "LIBRE", "MANTENIMIENTO", "OCUPADO" });
            estadoTxt.Location = new Point(221, 277);
            estadoTxt.Name = "estadoTxt";
            estadoTxt.Size = new Size(198, 29);
            estadoTxt.TabIndex = 62;
            estadoTxt.Text = "LIBRE";
            // 
            // FormHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 579);
            Controls.Add(estadoTxt);
            Controls.Add(btnGrabar);
            Controls.Add(MsgTxt);
            Controls.Add(btnBuscar);
            Controls.Add(obsTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(precioTxt);
            Controls.Add(label2);
            Controls.Add(numHabTxt);
            Controls.Add(label13);
            Controls.Add(numPersTxt);
            Controls.Add(label12);
            Controls.Add(tipoHabTxt);
            Controls.Add(label11);
            Name = "FormHabitaciones";
            Text = "Form1";
            Load += FormHabitaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private TextBox numPersTxt;
        private Label label12;
        private TextBox tipoHabTxt;
        private Label label11;
        private TextBox numHabTxt;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox obsTxt;
        private Button btnBuscar;
        private Label MsgTxt;
        private Button btnGrabar;
        private TextBox precioTxt;
        private ComboBox estadoTxt;
    }
}