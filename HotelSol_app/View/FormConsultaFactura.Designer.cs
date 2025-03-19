namespace HotelSol
{
    partial class FormConsultaFactura
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataFacturas = new DataGridView();
            FacturaId = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            FechaFactura = new DataGridViewTextBoxColumn();
            idReserva = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataFacturas).BeginInit();
            SuspendLayout();
            // 
            // dataFacturas
            // 
            dataFacturas.BackgroundColor = Color.FromArgb(245, 248, 210);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 248, 210);
            dataGridViewCellStyle1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(90, 39, 39);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 81, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFacturas.Columns.AddRange(new DataGridViewColumn[] { FacturaId, Concepto, FechaFactura, idReserva, DNI, Total });
            dataFacturas.Location = new Point(41, 102);
            dataFacturas.Name = "dataFacturas";
            dataFacturas.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(251, 249, 227);
            dataFacturas.RowTemplate.DefaultCellStyle.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataFacturas.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(90, 39, 39);
            dataFacturas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 81, 30);
            dataFacturas.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataFacturas.Size = new Size(1113, 581);
            dataFacturas.TabIndex = 0;
            // 
            // FacturaId
            // 
            FacturaId.HeaderText = "Número";
            FacturaId.Name = "FacturaId";
            FacturaId.ReadOnly = true;
            FacturaId.Width = 150;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Concepto";
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            Concepto.Width = 320;
            // 
            // FechaFactura
            // 
            FechaFactura.HeaderText = "FechaFactura";
            FechaFactura.Name = "FechaFactura";
            FechaFactura.ReadOnly = true;
            FechaFactura.Width = 150;
            // 
            // idReserva
            // 
            idReserva.HeaderText = "Id Reserva";
            idReserva.Name = "idReserva";
            idReserva.Width = 150;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // FormConsultaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 711);
            Controls.Add(dataFacturas);
            Name = "FormConsultaFactura";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataFacturas;
        private DataGridViewTextBoxColumn FacturaId;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn FechaFactura;
        private DataGridViewTextBoxColumn idReserva;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Total;
    }
}