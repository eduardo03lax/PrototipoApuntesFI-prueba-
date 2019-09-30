using System;
using System.Drawing;
using System.Windows.Forms;
using Usuarios;

namespace PrototipoApuntesFI
{
    public partial class FormRegistrarse : Form
    {
        private Form FormPadre;
        public FormRegistrarse(Form FormPadre)
        {
            this.FormPadre = FormPadre;
            InitializeComponent();
        }

        private void FormRegistrarse_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPadre.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormPadre.Show();
            this.Hide();
        }
    }
}
