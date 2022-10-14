namespace testing_new_forms
{
    partial class DatosPersonales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button buttonAceptar;
            System.Windows.Forms.Button buttonCancelar;
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            buttonAceptar = new System.Windows.Forms.Button();
            buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            buttonAceptar.FlatAppearance.BorderSize = 0;
            buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buttonAceptar.Location = new System.Drawing.Point(164, 389);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new System.Drawing.Size(91, 23);
            buttonAceptar.TabIndex = 9;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAceptar_MouseClick);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buttonCancelar.Location = new System.Drawing.Point(307, 389);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new System.Drawing.Size(91, 23);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(11, 27);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 13);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "APELLIDO";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(11, 62);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(11, 102);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(37, 13);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "EDAD";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(11, 141);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(66, 13);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "DIRECCIÓN";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(11, 193);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(73, 13);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "RESULTADO";
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellido.Location = new System.Drawing.Point(89, 22);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(484, 20);
            this.tbApellido.TabIndex = 5;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(89, 62);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(484, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(89, 102);
            this.tbEdad.MaxLength = 3;
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdad.TabIndex = 7;
            this.tbEdad.Tag = "int";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccion.Location = new System.Drawing.Point(89, 141);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(484, 20);
            this.tbDireccion.TabIndex = 8;
            // 
            // DatosPersonales
            // 
            this.AcceptButton = buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 452);
            this.Controls.Add(buttonCancelar);
            this.Controls.Add(buttonAceptar);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.MaximumSize = new System.Drawing.Size(601, 491);
            this.MinimumSize = new System.Drawing.Size(405, 491);
            this.Name = "DatosPersonales";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbDireccion;
    }
}

