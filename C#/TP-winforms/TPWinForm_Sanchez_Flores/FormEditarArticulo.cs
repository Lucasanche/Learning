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
using Comercio;

namespace TPWinForm_Sanchez_Flores
{
    public partial class FormEditarArticulo : Form
    {
        private Articulo articulo;
        public FormEditarArticulo(Articulo art)
        {
            InitializeComponent();
            articulo = art;
        }

        private void FormVerArticulo_Load(object sender, EventArgs e)
        {
            tbId.Text = articulo.Id.ToString();
            tbCodigo.Text = articulo.Codigo;
            tbNombre.Text = articulo.Nombre;
            tbDescripcion.Text = articulo.Descripcion;
            numericPrecio.Value = articulo.Precio;
            tbURLimagen.Text = articulo.ImagenUrl;
            btnGuardar.Enabled = false;
            //carga basica de imagen
            try
            {
                DataClasificacion dataClasificacion = new DataClasificacion();
                cboMarca.DataSource = dataClasificacion.listar("MARCAS");
                cboMarca.Text = articulo.Marca.Descripcion;
                cboCategorias.DataSource = dataClasificacion.listar("CATEGORIAS");
                cboCategorias.Text = articulo.Categoria.Descripcion;
                BoxImg.Load(articulo.ImagenUrl);
            }
            catch
            {
                BoxImg.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AccesData datos = new AccesData();
            DataClasificacion dataClasificacion = new DataClasificacion();
            int IDMarca = 0;
            int IDCategoria = 0;
            List<Clasificacion> listaMarcas = dataClasificacion.listar("MARCAS");
            List<Clasificacion> listaCategorias = dataClasificacion.listar("CATEGORIAS");

            foreach (Clasificacion clasificacion in listaCategorias)
            {
                if (clasificacion.Descripcion == cboCategorias.Text)
                {
                    IDCategoria = clasificacion.ID;
                }
            }
            foreach (Clasificacion clasificacion in listaMarcas)
            {
                if (clasificacion.Descripcion == cboMarca.Text)
                {
                    IDMarca = clasificacion.ID;
                }
            }
            try
            {
                
                string query = $"UPDATE ARTICULOS SET Nombre='{tbNombre.Text}', Descripcion='{tbDescripcion.Text}', Codigo='{tbCodigo.Text}', IdCategoria={IDCategoria}, IdMarca={IDMarca}, imagenURL='{tbURLimagen.Text}', Precio={numericPrecio.Value} WHERE Id='{tbId.Text}'";
                datos.setQuery(query);
                datos.executeQuery();
                MessageBox.Show("Cambios guardados con éxito");
            }
            catch
            {
                MessageBox.Show("Error al guardar los cambios");
            }
            finally
            {
                datos.closeConnection();
            }
            btnGuardar.Enabled = false;
        }

        private void btnActualizarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                BoxImg.Load(articulo.ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("URL de imagen inválida");
                BoxImg.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void tbURLimagen_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }
    }
}
