
namespace TPWinForm_Sanchez_Flores
{
    partial class VentanaListaArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pictureArticulo = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbOpcionesColumna = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.aRTICULOSTableAdapter = new TPWinForm_Sanchez_Flores.CATALOGO_DBDataSetTableAdapters.ARTICULOSTableAdapter();
            this.BindingSourceCatalogo_DB = new System.Windows.Forms.BindingSource(this.components);
            this.cATALOGO_DBDataSet = new TPWinForm_Sanchez_Flores.CATALOGO_DBDataSet();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.cbOpcionesCriterio = new System.Windows.Forms.ComboBox();
            this.numericBusquedaPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCatalogo_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGO_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBusquedaPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.AllowUserToAddRows = false;
            this.dgvListadoArticulos.AllowUserToDeleteRows = false;
            this.dgvListadoArticulos.AllowUserToResizeRows = false;
            this.dgvListadoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListadoArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoArticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListadoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListadoArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListadoArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(26, 69);
            this.dgvListadoArticulos.MultiSelect = false;
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.ReadOnly = true;
            this.dgvListadoArticulos.RowHeadersVisible = false;
            this.dgvListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoArticulos.Size = new System.Drawing.Size(490, 393);
            this.dgvListadoArticulos.TabIndex = 0;
            this.dgvListadoArticulos.SelectionChanged += new System.EventHandler(this.dgvListadoArticulos_SelectionChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(542, 428);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Location = new System.Drawing.Point(542, 486);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Articulo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescripcion.Location = new System.Drawing.Point(539, 225);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(153, 157);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(536, 204);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // pictureArticulo
            // 
            this.pictureArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureArticulo.Location = new System.Drawing.Point(539, 12);
            this.pictureArticulo.Name = "pictureArticulo";
            this.pictureArticulo.Size = new System.Drawing.Size(150, 189);
            this.pictureArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureArticulo.TabIndex = 7;
            this.pictureArticulo.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(542, 457);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(536, 404);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodigo.Location = new System.Drawing.Point(577, 404);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(115, 13);
            this.txtCodigo.TabIndex = 9;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(302, 34);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(150, 20);
            this.tbBusqueda.TabIndex = 11;
            // 
            // cbOpcionesColumna
            // 
            this.cbOpcionesColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcionesColumna.FormattingEnabled = true;
            this.cbOpcionesColumna.Location = new System.Drawing.Point(26, 34);
            this.cbOpcionesColumna.Name = "cbOpcionesColumna";
            this.cbOpcionesColumna.Size = new System.Drawing.Size(132, 21);
            this.cbOpcionesColumna.TabIndex = 12;
            this.cbOpcionesColumna.SelectedIndexChanged += new System.EventHandler(this.cbOpcionesColumna_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(458, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // aRTICULOSTableAdapter
            // 
            this.aRTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // BindingSourceCatalogo_DB
            // 
            this.BindingSourceCatalogo_DB.DataMember = "ARTICULOS";
            this.BindingSourceCatalogo_DB.DataSource = this.cATALOGO_DBDataSet;
            // 
            // cATALOGO_DBDataSet
            // 
            this.cATALOGO_DBDataSet.DataSetName = "CATALOGO_DBDataSet";
            this.cATALOGO_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(26, 468);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFiltro.TabIndex = 14;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // cbOpcionesCriterio
            // 
            this.cbOpcionesCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcionesCriterio.FormattingEnabled = true;
            this.cbOpcionesCriterio.Location = new System.Drawing.Point(164, 34);
            this.cbOpcionesCriterio.Name = "cbOpcionesCriterio";
            this.cbOpcionesCriterio.Size = new System.Drawing.Size(132, 21);
            this.cbOpcionesCriterio.TabIndex = 15;
            // 
            // numericBusquedaPrecio
            // 
            this.numericBusquedaPrecio.DecimalPlaces = 2;
            this.numericBusquedaPrecio.Location = new System.Drawing.Point(302, 34);
            this.numericBusquedaPrecio.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericBusquedaPrecio.Name = "numericBusquedaPrecio";
            this.numericBusquedaPrecio.Size = new System.Drawing.Size(150, 20);
            this.numericBusquedaPrecio.TabIndex = 22;
            // 
            // VentanaListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.numericBusquedaPrecio);
            this.Controls.Add(this.cbOpcionesCriterio);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbOpcionesColumna);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pictureArticulo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvListadoArticulos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 560);
            this.MinimumSize = new System.Drawing.Size(599, 462);
            this.Name = "VentanaListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.VentanaListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCatalogo_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGO_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBusquedaPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pictureArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbOpcionesColumna;
        private System.Diagnostics.Process process1;
        private CATALOGO_DBDataSetTableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private System.Windows.Forms.BindingSource BindingSourceCatalogo_DB;
        private CATALOGO_DBDataSet cATALOGO_DBDataSet;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.ComboBox cbOpcionesCriterio;
        private System.Windows.Forms.NumericUpDown numericBusquedaPrecio;
    }
}

