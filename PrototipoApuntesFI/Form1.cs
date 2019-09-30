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
    public partial class Form1 : Form
    {
        private FormRegistrarse formRegistrarse;
        private FormInicioSesion formInicioSesion;
        
        //Form Padre, la primera ventana que aparecera en la pantalla
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            formInicioSesion = new FormInicioSesion(this);
            formInicioSesion.Show();
            this.Hide();

        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            formRegistrarse = new FormRegistrarse(this);
            formRegistrarse.Show();
            this.Hide();
        }
    }
}
