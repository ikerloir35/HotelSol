namespace HotelSol
{
    partial class FormHotelCfg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotelCfg));
            grabar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            HotelIdTxt = new TextBox();
            descTxt = new TextBox();
            cifTxt = new TextBox();
            cargarFichero = new Button();
            calleTxt = new TextBox();
            errorLabel = new Label();
            label5 = new Label();
            cpTxt = new TextBox();
            label6 = new Label();
            localidadTxt = new TextBox();
            paisTxt = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // grabar
            // 
            grabar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grabar.BackColor = Color.FromArgb(244, 81, 30);
            grabar.Font = new Font("Arial Rounded MT Bold", 12F);
            grabar.ForeColor = Color.WhiteSmoke;
            grabar.Location = new Point(918, 464);
            grabar.Margin = new Padding(4, 3, 4, 3);
            grabar.Name = "grabar";
            grabar.Size = new Size(175, 72);
            grabar.TabIndex = 0;
            grabar.Text = "Grabar";
            grabar.UseVisualStyleBackColor = false;
            grabar.Click += grabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F);
            label1.Location = new Point(85, 133);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 1;
            label1.Text = "Hotel ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.Location = new Point(85, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.Location = new Point(87, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 3;
            label3.Text = "CIF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.Location = new Point(87, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 4;
            label4.Text = "Calle";
            // 
            // HotelIdTxt
            // 
            HotelIdTxt.Enabled = false;
            HotelIdTxt.Font = new Font("Cascadia Code", 12F);
            HotelIdTxt.Location = new Point(215, 124);
            HotelIdTxt.Margin = new Padding(4, 3, 4, 3);
            HotelIdTxt.Name = "HotelIdTxt";
            HotelIdTxt.Size = new Size(198, 26);
            HotelIdTxt.TabIndex = 5;
            // 
            // descTxt
            // 
            descTxt.Font = new Font("Cascadia Code", 12F);
            descTxt.Location = new Point(215, 170);
            descTxt.Margin = new Padding(4, 3, 4, 3);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(198, 26);
            descTxt.TabIndex = 6;
            // 
            // cifTxt
            // 
            cifTxt.Font = new Font("Cascadia Code", 12F);
            cifTxt.Location = new Point(215, 217);
            cifTxt.Margin = new Padding(4, 3, 4, 3);
            cifTxt.Name = "cifTxt";
            cifTxt.Size = new Size(198, 26);
            cifTxt.TabIndex = 7;
            // 
            // cargarFichero
            // 
            cargarFichero.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cargarFichero.BackColor = Color.FromArgb(244, 81, 30);
            cargarFichero.Font = new Font("Arial Rounded MT Bold", 12F);
            cargarFichero.ForeColor = Color.WhiteSmoke;
            cargarFichero.Location = new Point(684, 464);
            cargarFichero.Margin = new Padding(4, 3, 4, 3);
            cargarFichero.Name = "cargarFichero";
            cargarFichero.Size = new Size(175, 72);
            cargarFichero.TabIndex = 9;
            cargarFichero.Text = "Mostrar XML";
            cargarFichero.UseVisualStyleBackColor = false;
            cargarFichero.Click += cargarFichero_Click;
            // 
            // calleTxt
            // 
            calleTxt.Font = new Font("Cascadia Code", 12F);
            calleTxt.Location = new Point(215, 264);
            calleTxt.Margin = new Padding(4, 3, 4, 3);
            calleTxt.Name = "calleTxt";
            calleTxt.Size = new Size(198, 26);
            calleTxt.TabIndex = 10;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(53, 464);
            errorLabel.Margin = new Padding(4, 0, 4, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 19);
            errorLabel.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.Location = new Point(429, 267);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 12;
            label5.Text = "CP";
            // 
            // cpTxt
            // 
            cpTxt.Font = new Font("Cascadia Code", 12F);
            cpTxt.Location = new Point(467, 264);
            cpTxt.Margin = new Padding(4, 3, 4, 3);
            cpTxt.Name = "cpTxt";
            cpTxt.Size = new Size(54, 26);
            cpTxt.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.Location = new Point(541, 267);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 14;
            label6.Text = "Localidad";
            // 
            // localidadTxt
            // 
            localidadTxt.Font = new Font("Cascadia Code", 12F);
            localidadTxt.Location = new Point(631, 264);
            localidadTxt.Margin = new Padding(4, 3, 4, 3);
            localidadTxt.Name = "localidadTxt";
            localidadTxt.Size = new Size(198, 26);
            localidadTxt.TabIndex = 15;
            // 
            // paisTxt
            // 
            paisTxt.Font = new Font("Cascadia Code", 12F);
            paisTxt.Location = new Point(894, 264);
            paisTxt.Margin = new Padding(4, 3, 4, 3);
            paisTxt.Name = "paisTxt";
            paisTxt.Size = new Size(198, 26);
            paisTxt.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.Location = new Point(846, 267);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 16;
            label7.Text = "País";
            // 
            // FormHotelCfg
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1140, 570);
            Controls.Add(paisTxt);
            Controls.Add(label7);
            Controls.Add(localidadTxt);
            Controls.Add(label6);
            Controls.Add(cpTxt);
            Controls.Add(label5);
            Controls.Add(errorLabel);
            Controls.Add(calleTxt);
            Controls.Add(cargarFichero);
            Controls.Add(cifTxt);
            Controls.Add(descTxt);
            Controls.Add(HotelIdTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grabar);
            Font = new Font("Candara", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormHotelCfg";
            Text = "Configuración Hotel";
            Load += FormHotelCfg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button grabar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox HotelIdTxt;
        private TextBox descTxt;
        private TextBox cifTxt;
        private Button cargarFichero;
        private TextBox calleTxt;
        private Label errorLabel;
        private Label label5;
        private TextBox paisTxt;
        private Label label7;
        private TextBox localidadTxt;
        private Label label6;
        private TextBox cpTxt;
    }
}
