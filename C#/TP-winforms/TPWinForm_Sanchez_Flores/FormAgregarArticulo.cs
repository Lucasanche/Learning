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
    public partial class FormAgregarArticulo : Form
    {
        private bool flagNombre = false;
        private bool flagDescripcion = false;
        private bool flagCodigo = false;
        private bool flagURLimagen = false;
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }
        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            DataClasificacion dataClasificacion = new DataClasificacion();
            btnGuardar.Enabled = false;
            cboCategorias.DataSource = dataClasificacion.listar("CATEGORIAS");
            cboCategorias.Text = "-Sin especificar-";
            cboMarca.DataSource = dataClasificacion.listar("MARCAS");
            cboMarca.Text = "-Sin especificar-";
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
                string query = $"insert into ARTICULOS (codigo, IdCategoria, IdMarca, Nombre, Descripcion, Precio, ImagenUrl) VALUES ('{tbCodigo.Text}', {IDCategoria}, {IDMarca}, '{tbNombre.Text}', '{tbDescripcion.Text}', {numericPrecio.Value}, '{tbURLimagen.Text}')";
                datos.setQuery(query);
                datos.executeQuery();
                MessageBox.Show("Cambios guardados con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.closeConnection();
                tbCodigo.Clear();
                tbDescripcion.Clear();
                tbNombre.Clear();
                tbURLimagen.Clear();
                cboCategorias.Text = "-Sin especificar-";
                cboMarca.Text = "-Sin especificar-";
                numericPrecio.Value = 0;
            }
            btnGuardar.Enabled = false;
        }
        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length > 0)
            {
                flagCodigo = true;
            }
            else
            {
                flagCodigo = false;
            }
            if (flagCodigo && flagDescripcion && flagNombre && flagURLimagen)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text.Length > 0)
            {
                flagNombre = true;
            }
            else
            {
                flagDescripcion = false;
            }
            if (flagCodigo && flagDescripcion && flagNombre && flagURLimagen)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (tbDescripcion.Text.Length > 0)
            {
                flagDescripcion = true;
            }
            else
            {
                flagDescripcion = false;
            }
            if (flagCodigo && flagDescripcion && flagNombre && flagURLimagen)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void tbURLimagen_TextChanged(object sender, EventArgs e)
        {
            if (tbURLimagen.Text.Length > 0)
            {
                flagURLimagen = true;
            }
            else
            {
                flagURLimagen = false;
            }
            if (flagCodigo && flagDescripcion && flagNombre && flagURLimagen)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
    }
}
