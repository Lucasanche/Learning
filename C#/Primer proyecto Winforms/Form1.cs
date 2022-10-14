using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_proyecto_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonDeSaludo_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textNombre.Text);
            textNombre.Clear();

        }

        private void deleteElements_Click(object sender, EventArgs e)
        {
            listView1.SelectedIndices.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColorFavorito.Items.Add("Azul");
            cbColorFavorito.Items.Add("Verde");
            cbColorFavorito.Items.Add("Rojo");
            cbColorFavorito.Items.Add("Amarillo");
            cbColorFavorito.Items.Add("Negro");
            cbColorFavorito.Items.Add("Naranja");
        }

        private void buttonVerPerfil_Click(object sender, EventArgs e)
        {
            string name = textNombre.Text;
            DateTime fechaNacimiento = dateNacimiento.Value;
            string chocolate = chboxChocolate.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string animalFavorito;
            if (rb1.Checked)
            {
                animalFavorito = "Perro";
            }
            else if (rb2.Checked)
            {
                animalFavorito = "Gato";
            }
            else
            {
                animalFavorito = "Iguana";
            }
            string colorFavorito = cbColorFavorito.SelectedItem.ToString();
            string materiasCursadas = numericMateriasCursadas.Value.ToString();
            string mensaje = $"Nombre: {name}\nFecha de nacimiento: {fechaNacimiento}\n{chocolate}\nAnimal favorito: {animalFavorito}\nColor favorito: {colorFavorito}\nCantidad de materias cursadas: {materiasCursadas}";
            MessageBox.Show(mensaje);
        }

        private void showName_Click(object sender, EventArgs e)
        {

        }
    }
}
