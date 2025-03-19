namespace HotelSol
{
    partial class FormConsulta
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
            MsgTxt = new Label();
            btnConsulta = new Button();
            fecSalidaTxt = new TextBox();
            label6 = new Label();
            fecEntradaTxt = new TextBox();
            label5 = new Label();
            fecReserva = new TextBox();
            label4 = new Label();
            clientNameTxt = new TextBox();
            label2 = new Label();
            tipoCliTxt = new TextBox();
            label3 = new Label();
            DocIdTxt = new TextBox();
            label1 = new Label();
            tipoHabTxt = new Label();
            habAsigTxt = new Label();
            labelTaloj = new Label();
            labelHabAsignada = new Label();
            label12 = new Label();
            labelTipoHab = new Label();
            tAlojTxt = new Label();
            numPersTxt = new Label();
            EstadoTxt = new Label();
            label8 = new Label();
            totalTxt = new Label();
            factNumTxt = new Label();
            labelFact = new Label();
            labelTotal = new Label();
            SuspendLayout();
            // 
            // MsgTxt
            // 
            MsgTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MsgTxt.AutoSize = true;
            MsgTxt.Font = new Font("Cascadia Code", 12F);
            MsgTxt.ForeColor = Color.Red;
            MsgTxt.Location = new Point(35, 546);
            MsgTxt.Margin = new Padding(4, 0, 4, 0);
            MsgTxt.Name = "MsgTxt";
            MsgTxt.Size = new Size(64, 21);
            MsgTxt.TabIndex = 90;
            MsgTxt.Text = "MsgTxt";
            // 
            // btnConsulta
            // 
            btnConsulta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConsulta.BackColor = Color.FromArgb(244, 81, 30);
            btnConsulta.FlatAppearance.BorderColor = Color.White;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Arial Rounded MT Bold", 12F);
            btnConsulta.ForeColor = Color.WhiteSmoke;
            btnConsulta.Location = new Point(960, 450);
            btnConsulta.Margin = new Padding(4, 3, 4, 3);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(175, 72);
            btnConsulta.TabIndex = 89;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // fecSalidaTxt
            // 
            fecSalidaTxt.Enabled = false;
            fecSalidaTxt.Font = new Font("Cascadia Code", 12F);
            fecSalidaTxt.Location = new Point(522, 149);
            fecSalidaTxt.Margin = new Padding(4, 3, 4, 3);
            fecSalidaTxt.Name = "fecSalidaTxt";
            fecSalidaTxt.Size = new Size(198, 26);
            fecSalidaTxt.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(522, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 80;
            label6.Text = "Fecha Salida";
            // 
            // fecEntradaTxt
            // 
            fecEntradaTxt.Enabled = false;
            fecEntradaTxt.Font = new Font("Cascadia Code", 12F);
            fecEntradaTxt.Location = new Point(262, 149);
            fecEntradaTxt.Margin = new Padding(4, 3, 4, 3);
            fecEntradaTxt.Name = "fecEntradaTxt";
            fecEntradaTxt.Size = new Size(198, 26);
            fecEntradaTxt.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(262, 125);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 78;
            label5.Text = "Fecha Entrada";
            // 
            // fecReserva
            // 
            fecReserva.Enabled = false;
            fecReserva.Font = new Font("Cascadia Code", 12F);
            fecReserva.Location = new Point(30, 149);
            fecReserva.Margin = new Padding(4, 3, 4, 3);
            fecReserva.Name = "fecReserva";
            fecReserva.Size = new Size(198, 26);
            fecReserva.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(30, 125);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 76;
            label4.Text = "Fecha Reserva";
            // 
            // clientNameTxt
            // 
            clientNameTxt.Enabled = false;
            clientNameTxt.Font = new Font("Cascadia Code", 12F);
            clientNameTxt.Location = new Point(262, 67);
            clientNameTxt.Margin = new Padding(4, 3, 4, 3);
            clientNameTxt.Name = "clientNameTxt";
            clientNameTxt.Size = new Size(586, 26);
            clientNameTxt.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(262, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 75;
            label2.Text = "Cliente";
            // 
            // tipoCliTxt
            // 
            tipoCliTxt.Enabled = false;
            tipoCliTxt.Font = new Font("Cascadia Code", 12F);
            tipoCliTxt.Location = new Point(905, 67);
            tipoCliTxt.Margin = new Padding(4, 3, 4, 3);
            tipoCliTxt.Name = "tipoCliTxt";
            tipoCliTxt.Size = new Size(198, 26);
            tipoCliTxt.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(905, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 74;
            label3.Text = "Tipo Cliente";
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
            label1.TabIndex = 73;
            label1.Text = "DNI - Pasaporte";
            // 
            // tipoHabTxt
            // 
            tipoHabTxt.AutoSize = true;
            tipoHabTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tipoHabTxt.ForeColor = Color.OrangeRed;
            tipoHabTxt.Location = new Point(215, 374);
            tipoHabTxt.Name = "tipoHabTxt";
            tipoHabTxt.Size = new Size(100, 21);
            tipoHabTxt.TabIndex = 98;
            tipoHabTxt.Text = "tipoHabTxt";
            // 
            // habAsigTxt
            // 
            habAsigTxt.AutoSize = true;
            habAsigTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            habAsigTxt.ForeColor = Color.OrangeRed;
            habAsigTxt.Location = new Point(215, 320);
            habAsigTxt.Name = "habAsigTxt";
            habAsigTxt.Size = new Size(73, 21);
            habAsigTxt.TabIndex = 97;
            habAsigTxt.Text = "HabAsig";
            // 
            // labelTaloj
            // 
            labelTaloj.AutoSize = true;
            labelTaloj.Font = new Font("Cascadia Code", 12F);
            labelTaloj.Location = new Point(35, 268);
            labelTaloj.Margin = new Padding(4, 0, 4, 0);
            labelTaloj.Name = "labelTaloj";
            labelTaloj.Size = new Size(154, 21);
            labelTaloj.TabIndex = 95;
            labelTaloj.Text = "Tipo Alojamiento";
            // 
            // labelHabAsignada
            // 
            labelHabAsignada.AutoSize = true;
            labelHabAsignada.Font = new Font("Cascadia Code", 12F);
            labelHabAsignada.Location = new Point(35, 320);
            labelHabAsignada.Margin = new Padding(4, 0, 4, 0);
            labelHabAsignada.Name = "labelHabAsignada";
            labelHabAsignada.Size = new Size(181, 21);
            labelHabAsignada.TabIndex = 94;
            labelHabAsignada.Text = "Habitación Asignada";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code", 12F);
            label12.Location = new Point(35, 217);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(127, 21);
            label12.TabIndex = 92;
            label12.Text = "Num. Personas";
            // 
            // labelTipoHab
            // 
            labelTipoHab.AutoSize = true;
            labelTipoHab.Font = new Font("Cascadia Code", 12F);
            labelTipoHab.Location = new Point(35, 374);
            labelTipoHab.Margin = new Padding(4, 0, 4, 0);
            labelTipoHab.Name = "labelTipoHab";
            labelTipoHab.Size = new Size(172, 21);
            labelTipoHab.TabIndex = 91;
            labelTipoHab.Text = "Tipo de Habitación";
            // 
            // tAlojTxt
            // 
            tAlojTxt.AutoSize = true;
            tAlojTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tAlojTxt.ForeColor = Color.OrangeRed;
            tAlojTxt.Location = new Point(215, 268);
            tAlojTxt.Name = "tAlojTxt";
            tAlojTxt.Size = new Size(82, 21);
            tAlojTxt.TabIndex = 99;
            tAlojTxt.Text = "tAlojTxt";
            // 
            // numPersTxt
            // 
            numPersTxt.AutoSize = true;
            numPersTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numPersTxt.ForeColor = Color.OrangeRed;
            numPersTxt.Location = new Point(215, 217);
            numPersTxt.Name = "numPersTxt";
            numPersTxt.Size = new Size(100, 21);
            numPersTxt.TabIndex = 100;
            numPersTxt.Text = "numPersTxt";
            // 
            // EstadoTxt
            // 
            EstadoTxt.AutoSize = true;
            EstadoTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EstadoTxt.ForeColor = Color.OrangeRed;
            EstadoTxt.Location = new Point(905, 154);
            EstadoTxt.Name = "EstadoTxt";
            EstadoTxt.Size = new Size(91, 21);
            EstadoTxt.TabIndex = 102;
            EstadoTxt.Text = "EstadoTxt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F);
            label8.Location = new Point(905, 125);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(199, 21);
            label8.TabIndex = 101;
            label8.Text = "Estado Última Reserva";
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalTxt.ForeColor = Color.OrangeRed;
            totalTxt.Location = new Point(702, 268);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(82, 21);
            totalTxt.TabIndex = 106;
            totalTxt.Text = "totalTxt";
            // 
            // factNumTxt
            // 
            factNumTxt.AutoSize = true;
            factNumTxt.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            factNumTxt.ForeColor = Color.OrangeRed;
            factNumTxt.Location = new Point(702, 217);
            factNumTxt.Name = "factNumTxt";
            factNumTxt.Size = new Size(100, 21);
            factNumTxt.TabIndex = 105;
            factNumTxt.Text = "factNumTxt";
            // 
            // labelFact
            // 
            labelFact.AutoSize = true;
            labelFact.Font = new Font("Cascadia Code", 12F);
            labelFact.Location = new Point(522, 217);
            labelFact.Margin = new Padding(4, 0, 4, 0);
            labelFact.Name = "labelFact";
            labelFact.Size = new Size(118, 21);
            labelFact.TabIndex = 104;
            labelFact.Text = "Factura Núm.";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Cascadia Code", 12F);
            labelTotal.Location = new Point(522, 268);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(55, 21);
            labelTotal.TabIndex = 103;
            labelTotal.Text = "Total";
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 576);
            Controls.Add(totalTxt);
            Controls.Add(factNumTxt);
            Controls.Add(labelFact);
            Controls.Add(labelTotal);
            Controls.Add(EstadoTxt);
            Controls.Add(label8);
            Controls.Add(numPersTxt);
            Controls.Add(tAlojTxt);
            Controls.Add(tipoHabTxt);
            Controls.Add(habAsigTxt);
            Controls.Add(labelTaloj);
            Controls.Add(labelHabAsignada);
            Controls.Add(label12);
            Controls.Add(labelTipoHab);
            Controls.Add(MsgTxt);
            Controls.Add(btnConsulta);
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
            Name = "FormConsulta";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MsgTxt;
        private Button btnConsulta;
        private TextBox fecSalidaTxt;
        private Label label6;
        private TextBox fecEntradaTxt;
        private Label label5;
        private TextBox fecReserva;
        private Label label4;
        private TextBox clientNameTxt;
        private Label label2;
        private TextBox tipoCliTxt;
        private Label label3;
        private TextBox DocIdTxt;
        private Label label1;
        private Label tipoHabTxt;
        private Label habAsigTxt;
        private Label labelTaloj;
        private Label labelHabAsignada;
        private Label label12;
        private Label labelTipoHab;
        private Label tAlojTxt;
        private Label numPersTxt;
        private Label EstadoTxt;
        private Label label8;
        private Label totalTxt;
        private Label factNumTxt;
        private Label labelFact;
        private Label labelTotal;
    }
}