namespace HotelSol
{
    partial class FormReserva
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
            DocIdTxt = new TextBox();
            label1 = new Label();
            tipoCliTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            clientNameTxt = new TextBox();
            label4 = new Label();
            fecReserva = new TextBox();
            fecEntradaTxt = new TextBox();
            label5 = new Label();
            fecSalidaTxt = new TextBox();
            label6 = new Label();
            label14 = new Label();
            numPersTxt = new TextBox();
            label12 = new Label();
            btnSave = new Button();
            MsgTxt = new Label();
            btnBuscar = new Button();
            label7 = new Label();
            comboTAloja = new ComboBox();
            numTarjetaTxt = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // DocIdTxt
            // 
            DocIdTxt.Font = new Font("Cascadia Code", 12F);
            DocIdTxt.Location = new Point(30, 67);
            DocIdTxt.Margin = new Padding(4, 3, 4, 3);
            DocIdTxt.Name = "DocIdTxt";
            DocIdTxt.Size = new Size(198, 26);
            DocIdTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F);
            label1.Location = new Point(30, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 50;
            label1.Text = "DNI - Pasaporte";
            // 
            // tipoCliTxt
            // 
            tipoCliTxt.Enabled = false;
            tipoCliTxt.Font = new Font("Cascadia Code", 12F);
            tipoCliTxt.Location = new Point(984, 67);
            tipoCliTxt.Margin = new Padding(4, 3, 4, 3);
            tipoCliTxt.Name = "tipoCliTxt";
            tipoCliTxt.Size = new Size(198, 26);
            tipoCliTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(984, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 52;
            label3.Text = "Tipo Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(374, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 53;
            label2.Text = "Cliente";
            // 
            // clientNameTxt
            // 
            clientNameTxt.Enabled = false;
            clientNameTxt.Font = new Font("Cascadia Code", 12F);
            clientNameTxt.Location = new Point(374, 67);
            clientNameTxt.Margin = new Padding(4, 3, 4, 3);
            clientNameTxt.Name = "clientNameTxt";
            clientNameTxt.Size = new Size(586, 26);
            clientNameTxt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(30, 125);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 54;
            label4.Text = "Fecha Reserva";
            // 
            // fecReserva
            // 
            fecReserva.Enabled = false;
            fecReserva.Font = new Font("Cascadia Code", 12F);
            fecReserva.Location = new Point(30, 149);
            fecReserva.Margin = new Padding(4, 3, 4, 3);
            fecReserva.Name = "fecReserva";
            fecReserva.Size = new Size(198, 26);
            fecReserva.TabIndex = 4;
            // 
            // fecEntradaTxt
            // 
            fecEntradaTxt.Enabled = false;
            fecEntradaTxt.Font = new Font("Cascadia Code", 12F);
            fecEntradaTxt.Location = new Point(261, 149);
            fecEntradaTxt.Margin = new Padding(4, 3, 4, 3);
            fecEntradaTxt.Name = "fecEntradaTxt";
            fecEntradaTxt.Size = new Size(198, 26);
            fecEntradaTxt.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(261, 125);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 56;
            label5.Text = "Fecha Entrada";
            // 
            // fecSalidaTxt
            // 
            fecSalidaTxt.Enabled = false;
            fecSalidaTxt.Font = new Font("Cascadia Code", 12F);
            fecSalidaTxt.Location = new Point(484, 149);
            fecSalidaTxt.Margin = new Padding(4, 3, 4, 3);
            fecSalidaTxt.Name = "fecSalidaTxt";
            fecSalidaTxt.Size = new Size(198, 26);
            fecSalidaTxt.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(484, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 58;
            label6.Text = "Fecha Salida";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cascadia Code", 12F);
            label14.Location = new Point(33, 318);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(181, 21);
            label14.TabIndex = 65;
            label14.Text = "Tipo de Alojamiento";
            // 
            // numPersTxt
            // 
            numPersTxt.Enabled = false;
            numPersTxt.Font = new Font("Cascadia Code", 12F);
            numPersTxt.Location = new Point(261, 261);
            numPersTxt.Margin = new Padding(4, 3, 4, 3);
            numPersTxt.Name = "numPersTxt";
            numPersTxt.Size = new Size(198, 26);
            numPersTxt.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 12F);
            label12.Location = new Point(33, 266);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(127, 21);
            label12.TabIndex = 61;
            label12.Text = "Num. Personas";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(244, 81, 30);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Rounded MT Bold", 12F);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(984, 447);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(175, 72);
            btnSave.TabIndex = 68;
            btnSave.Text = "Grabar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // MsgTxt
            // 
            MsgTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MsgTxt.AutoSize = true;
            MsgTxt.Font = new Font("Cascadia Code", 12F);
            MsgTxt.ForeColor = Color.Red;
            MsgTxt.Location = new Point(30, 546);
            MsgTxt.Margin = new Padding(4, 0, 4, 0);
            MsgTxt.Name = "MsgTxt";
            MsgTxt.Size = new Size(64, 21);
            MsgTxt.TabIndex = 68;
            MsgTxt.Text = "MsgTxt";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 81, 30);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.Location = new Point(236, 65);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.Location = new Point(714, 152);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 69;
            label7.Text = "DD/MM/AAAA";
            // 
            // comboTAloja
            // 
            comboTAloja.Font = new Font("Cascadia Code", 12F);
            comboTAloja.FormattingEnabled = true;
            comboTAloja.Location = new Point(261, 315);
            comboTAloja.Name = "comboTAloja";
            comboTAloja.Size = new Size(198, 29);
            comboTAloja.TabIndex = 70;
            // 
            // numTarjetaTxt
            // 
            numTarjetaTxt.Enabled = false;
            numTarjetaTxt.Font = new Font("Cascadia Code", 12F);
            numTarjetaTxt.Location = new Point(261, 217);
            numTarjetaTxt.Margin = new Padding(4, 3, 4, 3);
            numTarjetaTxt.Name = "numTarjetaTxt";
            numTarjetaTxt.Size = new Size(413, 26);
            numTarjetaTxt.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F);
            label10.Location = new Point(33, 217);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(136, 21);
            label10.TabIndex = 72;
            label10.Text = "Número Tarjeta";
            // 
            // FormReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 576);
            Controls.Add(numTarjetaTxt);
            Controls.Add(label10);
            Controls.Add(comboTAloja);
            Controls.Add(label7);
            Controls.Add(btnBuscar);
            Controls.Add(MsgTxt);
            Controls.Add(btnSave);
            Controls.Add(label14);
            Controls.Add(numPersTxt);
            Controls.Add(label12);
            Controls.Add(fecSalidaTxt);
            Controls.Add(label6);
            Controls.Add(fecEntradaTxt);
            Controls.Add(label5);
            Controls.Add(fecReserva);
            Controls.Add(label4);
            Controls.Add(clientNameTxt);
            Controls.Add(label2);
            Controls.Add(tipoCliTxt);
            Controls.Add(label3);
            Controls.Add(DocIdTxt);
            Controls.Add(label1);
            Name = "FormReserva";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DocIdTxt;
        private Label label1;
        private TextBox tipoCliTxt;
        private Label label3;
        private Label label2;
        private TextBox clientNameTxt;
        private Label label4;
        private TextBox fecReserva;
        private TextBox fecEntradaTxt;
        private Label label5;
        private TextBox fecSalidaTxt;
        private Label label6;
        private Label label14;
        private TextBox numPersTxt;
        private Label label12;
        private Button btnSave;
        private Label MsgTxt;
        private Button btnBuscar;
        private Label label7;
        private ComboBox comboTAloja;
        private TextBox numTarjetaTxt;
        private Label label10;
    }
}