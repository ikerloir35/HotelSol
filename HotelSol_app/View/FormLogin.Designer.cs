namespace HotelSol
{
    partial class FormLogin
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
            passwordTxt = new TextBox();
            label13 = new Label();
            usuarioTxt = new TextBox();
            label14 = new Label();
            SuspendLayout();
            // 
            // passwordTxt
            // 
            passwordTxt.Enabled = false;
            passwordTxt.Font = new Font("Cascadia Code", 12F);
            passwordTxt.Location = new Point(97, 191);
            passwordTxt.Margin = new Padding(4, 3, 4, 3);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(200, 26);
            passwordTxt.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code", 12F);
            label13.Location = new Point(97, 167);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(82, 21);
            label13.TabIndex = 81;
            label13.Text = "Password";
            // 
            // usuarioTxt
            // 
            usuarioTxt.Enabled = false;
            usuarioTxt.Font = new Font("Cascadia Code", 12F);
            usuarioTxt.Location = new Point(99, 114);
            usuarioTxt.Margin = new Padding(4, 3, 4, 3);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(198, 26);
            usuarioTxt.TabIndex = 78;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cascadia Code", 12F);
            label14.Location = new Point(97, 90);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(73, 21);
            label14.TabIndex = 80;
            label14.Text = "Usuario";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 285);
            Controls.Add(passwordTxt);
            Controls.Add(label13);
            Controls.Add(usuarioTxt);
            Controls.Add(label14);
            Name = "FormLogin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTxt;
        private Label label13;
        private TextBox usuarioTxt;
        private Label label14;
    }
}