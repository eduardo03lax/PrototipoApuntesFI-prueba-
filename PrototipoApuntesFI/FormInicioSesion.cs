using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoApuntesFI
{
    public partial class FormInicioSesion : Form
    {
        private Form FormPadre;

        public FormInicioSesion(Form FormPadre)
        {
            this.FormPadre = FormPadre;

            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormPadre.Show();
            this.Hide();
        }

        private void FormInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPadre.Show();
        }
    }
}
