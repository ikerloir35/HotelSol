namespace HotelSol
{
    partial class FormPurchaseOrder
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
            label1 = new Label();
            listPartNumber = new ListBox();
            textError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 1;
            label1.Text = "Part Numbers";
            // 
            // listPartNumber
            // 
            listPartNumber.FormattingEnabled = true;
            listPartNumber.ItemHeight = 17;
            listPartNumber.Location = new Point(54, 66);
            listPartNumber.Name = "listPartNumber";
            listPartNumber.Size = new Size(484, 174);
            listPartNumber.TabIndex = 2;
            // 
            // textError
            // 
            textError.AutoSize = true;
            textError.ForeColor = Color.Red;
            textError.Location = new Point(45, 299);
            textError.Name = "textError";
            textError.Size = new Size(0, 17);
            textError.TabIndex = 3;
            textError.Click += label2_Click;
            // 
            // FormPurchaseOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(842, 325);
            Controls.Add(textError);
            Controls.Add(listPartNumber);
            Controls.Add(label1);
            Name = "FormPurchaseOrder";
            Text = "PartNumber";
            Load += PurchaseOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listPartNumber;
        private Label textError;
    }
}