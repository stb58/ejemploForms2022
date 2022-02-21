using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploForms
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//Oculta esta ventana

            VentanaPrincipal ventana = new VentanaPrincipal(); //Creamos el nuevo formulario en la pantalla
            ventana.Show(); //Y lo mostramos
        }
    }
}
