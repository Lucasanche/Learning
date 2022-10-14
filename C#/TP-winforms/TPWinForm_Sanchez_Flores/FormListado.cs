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
    public partial class VentanaListaArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public VentanaListaArticulos()
        {
            InitializeComponent();
        }

        private void VentanaListaArticulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cATALOGO_DBDataSet.ARTICULOS' table. You can move, or remove it, as needed.
            this.aRTICULOSTableAdapter.Fill(this.cATALOGO_DBDataSet.ARTICULOS);
            cargar();
        }

        private void cargar()
        {
            DataArticulo datos = new DataArticulo();
            //le asignamos una lista de articulos al dataGridView
            try
            {
                listaArticulos = datos.listar();
                dgvListadoArticulos.DataSource = listaArticulos;
                columnsProperties();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cbOpcionesColumna.Items.Add("Nombre");
            cbOpcionesColumna.Items.Add("Marca");
            cbOpcionesColumna.Items.Add("Categoría");
            cbOpcionesColumna.Items.Add("Código");
            cbOpcionesColumna.Items.Add("Precio");
            cbOpcionesCriterio.Items.Add("Igual que");
        }

        private void columnsProperties()
        {
            dgvListadoArticulos.AllowUserToOrderColumns = true;
            dgvListadoArticulos.Columns["ImagenUrl"].Visible = false;
            dgvListadoArticulos.Columns["Codigo"].Visible = false;
            dgvListadoArticulos.Columns["Descripcion"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Articulo seleccion = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            FormEditarArticulo frmVer = new FormEditarArticulo(seleccion);
            frmVer.ShowDialog();
            cargar();
            //despues de editar el articulo la ventana actual tiene que actualizar las listas
        }


        //evento cuando cambia la seleccion. Aplica tambien para la columna inicial
        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListadoArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;

                //Debajo de la imagen se muestran detalles del articulo seleccionado
                txtDescripcion.Text = seleccion.Descripcion;
                txtCodigo.Text = seleccion.Codigo;
                //esta es una carga basica de imagenes
                try
                {
                    pictureArticulo.Load(seleccion.ImagenUrl);
                }
                catch
                {
                    pictureArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccion;
            DataArticulo dataArticulo = new DataArticulo();
            try
            {
                DialogResult respuesta = MessageBox.Show("El articulo se eliminará de forma permanente", "Eliminar Articulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {
                    seleccion = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                    dataArticulo.eliminar(seleccion.Id);
                    cargar();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo frmAgregar = new FormAgregarArticulo();
            frmAgregar.ShowDialog();
            cargar();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DataFilter filtro = new DataFilter();
                if (cbOpcionesColumna.SelectedItem != null)
                {
                    if (cbOpcionesColumna.SelectedItem.ToString() == "Precio")
                    {
                        listaArticulos = filtro.listar(numericBusquedaPrecio.Value.ToString(), cbOpcionesColumna.Text, cbOpcionesCriterio.Text);
                    }
                    else
                    {
                        listaArticulos = filtro.listar(tbBusqueda.Text, cbOpcionesColumna.Text, cbOpcionesCriterio.Text);
                    }

                    if (listaArticulos.Count == 0)
                    {
                        MessageBox.Show("La búsqueda no arrojó ningún resultado");
                        cargar();
                        tbBusqueda.Clear();
                    }
                    dgvListadoArticulos.DataSource = listaArticulos;
                    columnsProperties();
                }
                

            }
            catch
            {
                MessageBox.Show("La búsqueda no arrojó ningún resultado");
                tbBusqueda.Clear();
            }
        }

        private void cbOpcionesColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcionesColumna.Text == "Precio")
            {
                numericBusquedaPrecio.Visible = true;
                tbBusqueda.Visible = false;
                cbOpcionesCriterio.Items.Add("Menor que");
                cbOpcionesCriterio.Items.Add("Mayor que");
                cbOpcionesCriterio.Items.Remove("Contiene");
                cbOpcionesCriterio.Items.Remove("Termina con");
                cbOpcionesCriterio.Items.Remove("Empieza con");

            }
            else
            {
                numericBusquedaPrecio.Visible = false;
                tbBusqueda.Visible = true;
                cbOpcionesCriterio.Items.Remove("Menor que");
                cbOpcionesCriterio.Items.Remove("Mayor que");
                cbOpcionesCriterio.Items.Add("Contiene");
                cbOpcionesCriterio.Items.Add("Termina con");
                cbOpcionesCriterio.Items.Add("Empieza con");
            }
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
