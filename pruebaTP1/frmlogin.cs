namespace pruebaTP1
{
    partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
            VerificarCampos();
            Txtpass.TextChanged += Txtpass_TextChanged;
            Txtusuario.TextChanged+= Txtusuario_TextChanged;
        }

        private void lnkrecu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void VerificarCampos()
        {
            Btnenter.Enabled = Txtusuario.Text.Length > 3 && Txtpass.Text.Length > 7;
        }

        private void Txtusuario_TextChanged(object? sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void Txtpass_TextChanged(object? sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void ChbTerm_CheckedChanged(object? sender, EventArgs e)
        {

        }

        private void Txtusuario_TextChanged_1(object? sender, EventArgs e)
        {

        }
    }
}