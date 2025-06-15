namespace pruebaTP1
{
    partial class frmlogin
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
            lbluser = new Label();
            txtusuario = new TextBox();
            txtpass = new TextBox();
            lblpass = new Label();
            btnenter = new Button();
            lnkrecu = new LinkLabel();
            chbTerm = new CheckBox();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(130, 66);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(47, 15);
            lbluser.TabIndex = 0;
            lbluser.Text = "Usuario";
            // 
            // txtusuario
            // 
            txtusuario.BorderStyle = BorderStyle.FixedSingle;
            txtusuario.Location = new Point(131, 84);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "Ususario";
            txtusuario.Size = new Size(122, 23);
            txtusuario.TabIndex = 1;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(130, 137);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.PlaceholderText = "Contraseña";
            txtpass.Size = new Size(122, 23);
            txtpass.TabIndex = 3;
            txtpass.Tag = "";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(130, 119);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(67, 15);
            lblpass.TabIndex = 2;
            lblpass.Text = "Contraseña";
            // 
            // btnenter
            // 
            btnenter.Enabled = false;
            btnenter.Location = new Point(147, 199);
            btnenter.Name = "btnenter";
            btnenter.Size = new Size(75, 33);
            btnenter.TabIndex = 4;
            btnenter.Text = "Entrar";
            btnenter.UseVisualStyleBackColor = true;
            // 
            // lnkrecu
            // 
            lnkrecu.AutoSize = true;
            lnkrecu.Location = new Point(50, 266);
            lnkrecu.Name = "lnkrecu";
            lnkrecu.Size = new Size(121, 15);
            lnkrecu.TabIndex = 5;
            lnkrecu.TabStop = true;
            lnkrecu.Text = "Recuperar contraseña";
            lnkrecu.LinkClicked += lnkrecu_LinkClicked;
            // 
            // chbTerm
            // 
            chbTerm.AutoSize = true;
            chbTerm.Location = new Point(95, 166);
            chbTerm.Name = "chbTerm";
            chbTerm.Size = new Size(196, 19);
            chbTerm.TabIndex = 6;
            chbTerm.Text = "Acepto Terminos y Condiciones ";
            chbTerm.UseVisualStyleBackColor = true;
            chbTerm.CheckedChanged += chbTerm_CheckedChanged;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 310);
            Controls.Add(chbTerm);
            Controls.Add(lnkrecu);
            Controls.Add(btnenter);
            Controls.Add(txtpass);
            Controls.Add(lblpass);
            Controls.Add(txtusuario);
            Controls.Add(lbluser);
            MaximumSize = new Size(390, 349);
            MinimumSize = new Size(390, 349);
            Name = "frmlogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluser;
        private TextBox txtusuario;
        private TextBox txtpass;
        private Label lblpass;
        private Button btnenter;
        private LinkLabel lnkrecu;
        private CheckBox chbTerm;
    }
}
