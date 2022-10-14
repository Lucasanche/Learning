using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_new_forms
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

   
        private void tbEdad_KeyPress(object sender, EventArgs e)
        {
            
        }

        private void buttonAceptar_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("hola");
            }
        }
    }
}
