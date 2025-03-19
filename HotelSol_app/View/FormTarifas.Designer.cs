namespace HotelSol
{
    partial class FormTarifas
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
            panelTarifa = new Panel();
            panel1 = new Panel();
            btnTemporada = new Button();
            btnHabitacion = new Button();
            btnTipoAlojamiento = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTarifa
            // 
            panelTarifa.BorderStyle = BorderStyle.FixedSingle;
            panelTarifa.Location = new Point(-3, 78);
            panelTarifa.Name = "panelTarifa";
            panelTarifa.Size = new Size(1215, 630);
            panelTarifa.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnTemporada);
            panel1.Controls.Add(btnHabitacion);
            panel1.Controls.Add(btnTipoAlojamiento);
            panel1.Location = new Point(-3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 70);
            panel1.TabIndex = 13;
            // 
            // btnTemporada
            // 
            btnTemporada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTemporada.BackColor = Color.FromArgb(218, 228, 88);
            btnTemporada.FlatStyle = FlatStyle.Flat;
            btnTemporada.Font = new Font("Arial Rounded MT Bold", 12F);
            btnTemporada.ForeColor = Color.FromArgb(90, 39, 39);
            btnTemporada.Location = new Point(393, 11);
            btnTemporada.Margin = new Padding(4, 3, 4, 3);
            btnTemporada.Name = "btnTemporada";
            btnTemporada.Size = new Size(170, 50);
            btnTemporada.TabIndex = 3;
            btnTemporada.Text = "Temporada";
            btnTemporada.UseVisualStyleBackColor = false;
            btnTemporada.Click += btnTemporada_Click;
            // 
            // btnHabitacion
            // 
            btnHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHabitacion.BackColor = Color.FromArgb(218, 228, 88);
            btnHabitacion.FlatStyle = FlatStyle.Flat;
            btnHabitacion.Font = new Font("Arial Rounded MT Bold", 12F);
            btnHabitacion.ForeColor = Color.FromArgb(90, 39, 39);
            btnHabitacion.Location = new Point(13, 11);
            btnHabitacion.Margin = new Padding(4, 3, 4, 3);
            btnHabitacion.Name = "btnHabitacion";
            btnHabitacion.Size = new Size(170, 50);
            btnHabitacion.TabIndex = 1;
            btnHabitacion.Text = "Habitaciones";
            btnHabitacion.UseVisualStyleBackColor = false;
            btnHabitacion.Click += btnHabitacion_Click;
            // 
            // btnTipoAlojamiento
            // 
            btnTipoAlojamiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTipoAlojamiento.BackColor = Color.FromArgb(218, 228, 88);
            btnTipoAlojamiento.FlatStyle = FlatStyle.Flat;
            btnTipoAlojamiento.Font = new Font("Arial Rounded MT Bold", 12F);
            btnTipoAlojamiento.ForeColor = Color.FromArgb(90, 39, 39);
            btnTipoAlojamiento.Location = new Point(203, 11);
            btnTipoAlojamiento.Margin = new Padding(4, 3, 4, 3);
            btnTipoAlojamiento.Name = "btnTipoAlojamiento";
            btnTipoAlojamiento.Size = new Size(170, 50);
            btnTipoAlojamiento.TabIndex = 2;
            btnTipoAlojamiento.Text = "Tipo Alojamiento";
            btnTipoAlojamiento.UseVisualStyleBackColor = false;
            btnTipoAlojamiento.Click += btnTipoAlojamiento_Click;
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 711);
            Controls.Add(panelTarifa);
            Controls.Add(panel1);
            Name = "FormTarifas";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTarifa;
        private Panel panel1;
        private Button btnTemporada;
        private Button btnHabitacion;
        private Button btnTipoAlojamiento;
    }
}