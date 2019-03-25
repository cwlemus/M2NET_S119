using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2NET_S119_INTRO_FORMULARIOS
{
    class Formulario:Form
    {
        Button b;
        public Formulario()
        {
            b = new Button();
            this.Text = "Formulario de prueba";
            b.Text = "Aceptar";
            b.Click += new EventHandler(b_Clic);
            this.Controls.Add(b);
        }

        public void b_Clic(object sender, EventArgs e)
        {
            MessageBox.Show("El boton ha sido pulsado");
            b.Text = "Pulsado";
        }

        static void Main(string[] args)
        {
            Formulario f = new Formulario();
            f.BackColor = Color.Azure;
            Application.Run(f);
        }
    }
}
