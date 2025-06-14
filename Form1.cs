namespace pruebaTP1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void lnkrecu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void chbTerm_CheckedChanged(object sender, EventArgs e)

        {
            if (chbTerm.Checked) {
                btnenter.Enabled = true;
            }
            else
            {btnenter.Enabled = false;
            }
        
            if (chbTerm.Checked)
            {
                MessageBox.Show("Acepto los terminos y condiciones");
            }
            else
            {
                MessageBox.Show("Debe aceptar los terminos y condiciones para continuar");
            }
        }
    }
}