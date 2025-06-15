namespace pruebaTP1
{
    partial class Frmlogin
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
            Lbluser = new Label();
            Txtusuario = new TextBox();
            Txtpass = new TextBox();
            Lblpass = new Label();
            Btnenter = new Button();
            Lnkrecu = new LinkLabel();
            SuspendLayout();
            // 
            // Lbluser
            // 
            Lbluser.AutoSize = true;
            Lbluser.Location = new Point(130, 66);
            Lbluser.Name = "Lbluser";
            Lbluser.Size = new Size(47, 15);
            Lbluser.TabIndex = 0;
            Lbluser.Text = "Usuario";
            // 
            // Txtusuario
            // 
            Txtusuario.BorderStyle = BorderStyle.FixedSingle;
            Txtusuario.Location = new Point(131, 84);
            Txtusuario.Name = "Txtusuario";
            Txtusuario.PlaceholderText = "Ususario";
            Txtusuario.Size = new Size(122, 23);
            Txtusuario.TabIndex = 1;
            Txtusuario.TextChanged += Txtusuario_TextChanged_1;
            // 
            // Txtpass
            // 
            Txtpass.Location = new Point(130, 137);
            Txtpass.Name = "Txtpass";
            Txtpass.PasswordChar = '*';
            Txtpass.PlaceholderText = "Contraseña";
            Txtpass.Size = new Size(122, 23);
            Txtpass.TabIndex = 3;
            Txtpass.Tag = "";
            // 
            // Lblpass
            // 
            Lblpass.AutoSize = true;
            Lblpass.Location = new Point(130, 119);
            Lblpass.Name = "Lblpass";
            Lblpass.Size = new Size(67, 15);
            Lblpass.TabIndex = 2;
            Lblpass.Text = "Contraseña";
            // 
            // Btnenter
            // 
            Btnenter.Location = new Point(147, 199);
            Btnenter.Name = "Btnenter";
            Btnenter.Size = new Size(75, 33);
            Btnenter.TabIndex = 4;
            Btnenter.Text = "Entrar";
            Btnenter.UseVisualStyleBackColor = true;
            // 
            // Lnkrecu
            // 
            Lnkrecu.AutoSize = true;
            Lnkrecu.Location = new Point(50, 266);
            Lnkrecu.Name = "Lnkrecu";
            Lnkrecu.Size = new Size(121, 15);
            Lnkrecu.TabIndex = 5;
            Lnkrecu.TabStop = true;
            Lnkrecu.Text = "Recuperar contraseña";
            Lnkrecu.LinkClicked += lnkrecu_LinkClicked;
            // 
            // Frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 310);
            Controls.Add(Lnkrecu);
            Controls.Add(Btnenter);
            Controls.Add(Txtpass);
            Controls.Add(Lblpass);
            Controls.Add(Txtusuario);
            Controls.Add(Lbluser);
            MaximumSize = new Size(390, 349);
            MinimumSize = new Size(390, 349);
            Name = "Frmlogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbluser;
        private TextBox Txtusuario;
        private TextBox Txtpass;
        private Label Lblpass;
        private Button Btnenter;
        private LinkLabel Lnkrecu;
    }
}
