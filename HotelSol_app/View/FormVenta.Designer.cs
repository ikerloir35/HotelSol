namespace HotelSol.View
{
    partial class FormVenta
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
            DataPedido = new DataGridView();
            ProdId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            CantidadTxt = new TextBox();
            btnBuscar = new Button();
            DescLabel = new Label();
            label1 = new Label();
            Label12 = new Label();
            TotalLbl = new Label();
            label2 = new Label();
            PrecioLbl = new Label();
            label4 = new Label();
            btnImportar = new Button();
            btnAdd = new Button();
            btnFinalizar = new Button();
            ProdNameTxt = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataPedido).BeginInit();
            SuspendLayout();
            // 
            // DataPedido
            // 
            DataPedido.BackgroundColor = Color.FromArgb(245, 248, 210);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 248, 210);
            dataGridViewCellStyle1.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(90, 39, 39);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 81, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataPedido.Columns.AddRange(new DataGridViewColumn[] { ProdId, Nombre, Descripcion, Precio, Cantidad, Total });
            DataPedido.Location = new Point(48, 205);
            DataPedido.Name = "DataPedido";
            DataPedido.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(251, 249, 227);
            DataPedido.RowTemplate.DefaultCellStyle.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataPedido.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(90, 39, 39);
            DataPedido.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(244, 81, 30);
            DataPedido.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataPedido.Size = new Size(1149, 465);
            DataPedido.TabIndex = 1;
            // 
            // ProdId
            // 
            ProdId.HeaderText = "Id";
            ProdId.Name = "ProdId";
            ProdId.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 355;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // CantidadTxt
            // 
            CantidadTxt.Enabled = false;
            CantidadTxt.Font = new Font("Cascadia Code", 12F);
            CantidadTxt.Location = new Point(201, 87);
            CantidadTxt.Margin = new Padding(4, 3, 4, 3);
            CantidadTxt.Name = "CantidadTxt";
            CantidadTxt.Size = new Size(198, 26);
            CantidadTxt.TabIndex = 66;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 81, 30);
            btnBuscar.FlatAppearance.BorderColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.Location = new Point(412, 37);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 29);
            btnBuscar.TabIndex = 65;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // DescLabel
            // 
            DescLabel.AutoSize = true;
            DescLabel.Font = new Font("Cascadia Code", 12F);
            DescLabel.Location = new Point(554, 43);
            DescLabel.Margin = new Padding(4, 0, 4, 0);
            DescLabel.Name = "DescLabel";
            DescLabel.Size = new Size(109, 21);
            DescLabel.TabIndex = 64;
            DescLabel.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F);
            label1.Location = new Point(48, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 63;
            label1.Text = "Nombre Producto";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Cascadia Code", 12F);
            Label12.Location = new Point(963, 92);
            Label12.Margin = new Padding(4, 0, 4, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(55, 21);
            Label12.TabIndex = 67;
            Label12.Text = "Total";
            // 
            // TotalLbl
            // 
            TotalLbl.AutoSize = true;
            TotalLbl.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            TotalLbl.Location = new Point(1092, 92);
            TotalLbl.Margin = new Padding(4, 0, 4, 0);
            TotalLbl.Name = "TotalLbl";
            TotalLbl.Size = new Size(55, 21);
            TotalLbl.TabIndex = 68;
            TotalLbl.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(48, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 69;
            label2.Text = "Cantidad";
            // 
            // PrecioLbl
            // 
            PrecioLbl.AutoSize = true;
            PrecioLbl.Font = new Font("Cascadia Code", 12F, FontStyle.Bold);
            PrecioLbl.Location = new Point(683, 92);
            PrecioLbl.Margin = new Padding(4, 0, 4, 0);
            PrecioLbl.Name = "PrecioLbl";
            PrecioLbl.Size = new Size(64, 21);
            PrecioLbl.TabIndex = 71;
            PrecioLbl.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(554, 92);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 70;
            label4.Text = "Precio";
            // 
            // btnImportar
            // 
            btnImportar.BackColor = Color.FromArgb(244, 81, 30);
            btnImportar.FlatAppearance.BorderColor = Color.White;
            btnImportar.FlatStyle = FlatStyle.Flat;
            btnImportar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnImportar.ForeColor = Color.WhiteSmoke;
            btnImportar.Location = new Point(48, 145);
            btnImportar.Margin = new Padding(4, 3, 4, 3);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(167, 29);
            btnImportar.TabIndex = 72;
            btnImportar.Text = "Importar de Nuevo";
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(244, 81, 30);
            btnAdd.FlatAppearance.BorderColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial Rounded MT Bold", 12F);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(946, 145);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 29);
            btnAdd.TabIndex = 73;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(244, 81, 30);
            btnFinalizar.FlatAppearance.BorderColor = Color.White;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnFinalizar.ForeColor = Color.WhiteSmoke;
            btnFinalizar.Location = new Point(1092, 145);
            btnFinalizar.Margin = new Padding(4, 3, 4, 3);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(97, 29);
            btnFinalizar.TabIndex = 74;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // ProdNameTxt
            // 
            ProdNameTxt.Font = new Font("Cascadia Code", 12F);
            ProdNameTxt.FormattingEnabled = true;
            ProdNameTxt.Location = new Point(201, 40);
            ProdNameTxt.Name = "ProdNameTxt";
            ProdNameTxt.Size = new Size(198, 29);
            ProdNameTxt.TabIndex = 75;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 711);
            Controls.Add(ProdNameTxt);
            Controls.Add(btnFinalizar);
            Controls.Add(btnAdd);
            Controls.Add(btnImportar);
            Controls.Add(PrecioLbl);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(TotalLbl);
            Controls.Add(Label12);
            Controls.Add(CantidadTxt);
            Controls.Add(btnBuscar);
            Controls.Add(DescLabel);
            Controls.Add(label1);
            Controls.Add(DataPedido);
            Name = "FormVenta";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataPedido;
        private TextBox CantidadTxt;
        private Button btnBuscar;
        private Label DescLabel;
        private Label label1;
        private Label Label12;
        private Label TotalLbl;
        private Label label2;
        private Label PrecioLbl;
        private Label label4;
        private Button btnImportar;
        private DataGridViewTextBoxColumn ProdId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private Button btnAdd;
        private Button btnFinalizar;
        private ComboBox ProdNameTxt;
    }
}