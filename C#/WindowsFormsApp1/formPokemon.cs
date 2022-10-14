using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class Pokemons : Form
    {
        private List<Pokemon> listaPokemon;
        public Pokemons()
        {
            InitializeComponent();
        }

        private void Pokemons_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemon.DataSource = listaPokemon;
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaPokemon[0].URLImagen);
        }

        private void dgbPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.URLImagen);

        }
        private void cargarImagen(string image)
        {
            try
            {
                pbPokemon.Load(image);
            }
            catch (Exception)
            {
                cargarImagen("https://www.came-educativa.com.ar/wp-content/uploads/2022/03/placeholder.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }
    }
}
