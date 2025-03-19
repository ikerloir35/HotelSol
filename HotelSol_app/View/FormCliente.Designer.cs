namespace HotelSol
{
    partial class FormCliente
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
            btnCheckIn = new Button();
            panel1 = new Panel();
            btnConsultar = new Button();
            btnRegistro = new Button();
            btnReserva = new Button();
            btnCheckOut = new Button();
            panelCliente = new Panel();
            msgLabel = new Label();
            panel1.SuspendLayout();
            panelCliente.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCheckIn.BackColor = Color.FromArgb(218, 228, 88);
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCheckIn.ForeColor = Color.FromArgb(90, 39, 39);
            btnCheckIn.Location = new Point(13, 11);
            btnCheckIn.Margin = new Padding(4, 3, 4, 3);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(170, 50);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(btnReserva);
            panel1.Controls.Add(btnCheckOut);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 70);
            panel1.TabIndex = 11;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(218, 228, 88);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnConsultar.ForeColor = Color.FromArgb(90, 39, 39);
            btnConsultar.Location = new Point(773, 11);
            btnConsultar.Margin = new Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(170, 50);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar Reserva";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistro.BackColor = Color.FromArgb(218, 228, 88);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Arial Rounded MT Bold", 12F);
            btnRegistro.ForeColor = Color.FromArgb(90, 39, 39);
            btnRegistro.Location = new Point(393, 11);
            btnRegistro.Margin = new Padding(4, 3, 4, 3);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(170, 50);
            btnRegistro.TabIndex = 3;
            btnRegistro.Text = "Registro Cliente";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnReserva
            // 
            btnReserva.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReserva.BackColor = Color.FromArgb(218, 228, 88);
            btnReserva.FlatStyle = FlatStyle.Flat;
            btnReserva.Font = new Font("Arial Rounded MT Bold", 12F);
            btnReserva.ForeColor = Color.FromArgb(90, 39, 39);
            btnReserva.Location = new Point(583, 11);
            btnReserva.Margin = new Padding(4, 3, 4, 3);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(170, 50);
            btnReserva.TabIndex = 4;
            btnReserva.Text = "Realizar Reserva";
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCheckOut.BackColor = Color.FromArgb(218, 228, 88);
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCheckOut.ForeColor = Color.FromArgb(90, 39, 39);
            btnCheckOut.Location = new Point(203, 11);
            btnCheckOut.Margin = new Padding(4, 3, 4, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(170, 50);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panelCliente
            // 
            panelCliente.BorderStyle = BorderStyle.FixedSingle;
            panelCliente.Controls.Add(msgLabel);
            panelCliente.Location = new Point(0, 75);
            panelCliente.Name = "panelCliente";
            panelCliente.Size = new Size(1215, 630);
            panelCliente.TabIndex = 12;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgLabel.Location = new Point(13, 594);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(82, 21);
            msgLabel.TabIndex = 0;
            msgLabel.Text = "msgLabel";
            msgLabel.Visible = false;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 711);
            Controls.Add(panelCliente);
            Controls.Add(panel1);
            Name = "FormCliente";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panelCliente.ResumeLayout(false);
            panelCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckIn;
        private Panel panel1;
        private Button btnCheckOut;
        private Button btnConsultar;
        private Button btnReserva;
        private Button btnRegistro;
        private Panel panelCliente;
        private Label msgLabel;
    }
}