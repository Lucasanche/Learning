namespace Primer_proyecto_winforms
{
    partial class Form1
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
            this.botonElementos = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.chboxChocolate = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.groupBoxAnimalPreferido = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.cbColorFavorito = new System.Windows.Forms.ComboBox();
            this.numericMateriasCursadas = new System.Windows.Forms.NumericUpDown();
            this.labelMateriasCursadas = new System.Windows.Forms.Label();
            this.buttonVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxAnimalPreferido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMateriasCursadas)).BeginInit();
            this.SuspendLayout();
            // 
            // botonElementos
            // 
            this.botonElementos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonElementos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.botonElementos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonElementos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botonElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonElementos.Location = new System.Drawing.Point(339, 483);
            this.botonElementos.Name = "botonElementos";
            this.botonElementos.Size = new System.Drawing.Size(75, 23);
            this.botonElementos.TabIndex = 8;
            this.botonElementos.Text = "Agregar";
            this.botonElementos.UseVisualStyleBackColor = false;
            this.botonElementos.Click += new System.EventHandler(this.botonDeSaludo_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(120, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nombre: ";
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textNombre.Location = new System.Drawing.Point(183, 74);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(200, 20);
            this.textNombre.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(101, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(217, 180);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateNacimiento.Location = new System.Drawing.Point(183, 100);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateNacimiento.TabIndex = 1;
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNacimiento.AutoSize = true;
            this.labelNacimiento.Location = new System.Drawing.Point(65, 100);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(112, 13);
            this.labelNacimiento.TabIndex = 6;
            this.labelNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // chboxChocolate
            // 
            this.chboxChocolate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chboxChocolate.AutoSize = true;
            this.chboxChocolate.Location = new System.Drawing.Point(183, 131);
            this.chboxChocolate.Name = "chboxChocolate";
            this.chboxChocolate.Size = new System.Drawing.Size(135, 17);
            this.chboxChocolate.TabIndex = 2;
            this.chboxChocolate.Text = "Te gusta el chocolate?";
            this.chboxChocolate.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(100, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(184, 31);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Perfil Persona";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(6, 29);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(50, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Perro";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb3.Location = new System.Drawing.Point(219, 29);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(58, 17);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "Iguana";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(104, 29);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(48, 17);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "Gato";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // groupBoxAnimalPreferido
            // 
            this.groupBoxAnimalPreferido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxAnimalPreferido.Controls.Add(this.rb1);
            this.groupBoxAnimalPreferido.Controls.Add(this.rb2);
            this.groupBoxAnimalPreferido.Controls.Add(this.rb3);
            this.groupBoxAnimalPreferido.Location = new System.Drawing.Point(106, 174);
            this.groupBoxAnimalPreferido.Name = "groupBoxAnimalPreferido";
            this.groupBoxAnimalPreferido.Size = new System.Drawing.Size(308, 63);
            this.groupBoxAnimalPreferido.TabIndex = 3;
            this.groupBoxAnimalPreferido.TabStop = false;
            this.groupBoxAnimalPreferido.Text = "Animal preferido";
            // 
            // labelColor
            // 
            this.labelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(108, 268);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(69, 13);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Color favorito";
            // 
            // cbColorFavorito
            // 
            this.cbColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbColorFavorito.FormattingEnabled = true;
            this.cbColorFavorito.Location = new System.Drawing.Point(192, 265);
            this.cbColorFavorito.Name = "cbColorFavorito";
            this.cbColorFavorito.Size = new System.Drawing.Size(191, 21);
            this.cbColorFavorito.TabIndex = 4;
            // 
            // numericMateriasCursadas
            // 
            this.numericMateriasCursadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericMateriasCursadas.Location = new System.Drawing.Point(192, 300);
            this.numericMateriasCursadas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.numericMateriasCursadas.Name = "numericMateriasCursadas";
            this.numericMateriasCursadas.Size = new System.Drawing.Size(120, 20);
            this.numericMateriasCursadas.TabIndex = 5;
            // 
            // labelMateriasCursadas
            // 
            this.labelMateriasCursadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelMateriasCursadas.AutoSize = true;
            this.labelMateriasCursadas.Location = new System.Drawing.Point(84, 300);
            this.labelMateriasCursadas.Name = "labelMateriasCursadas";
            this.labelMateriasCursadas.Size = new System.Drawing.Size(93, 13);
            this.labelMateriasCursadas.TabIndex = 16;
            this.labelMateriasCursadas.Text = "Materias cursadas";
            // 
            // buttonVerPerfil
            // 
            this.buttonVerPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerPerfil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerPerfil.Location = new System.Drawing.Point(339, 336);
            this.buttonVerPerfil.Name = "buttonVerPerfil";
            this.buttonVerPerfil.Size = new System.Drawing.Size(94, 39);
            this.buttonVerPerfil.TabIndex = 7;
            this.buttonVerPerfil.Text = "Ver Perfil";
            this.buttonVerPerfil.UseVisualStyleBackColor = false;
            this.buttonVerPerfil.Click += new System.EventHandler(this.buttonVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 539);
            this.Controls.Add(this.buttonVerPerfil);
            this.Controls.Add(this.labelMateriasCursadas);
            this.Controls.Add(this.numericMateriasCursadas);
            this.Controls.Add(this.cbColorFavorito);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.groupBoxAnimalPreferido);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.chboxChocolate);
            this.Controls.Add(this.labelNacimiento);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.botonElementos);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(449, 578);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAnimalPreferido.ResumeLayout(false);
            this.groupBoxAnimalPreferido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMateriasCursadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonElementos;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.CheckBox chboxChocolate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.GroupBox groupBoxAnimalPreferido;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox cbColorFavorito;
        private System.Windows.Forms.NumericUpDown numericMateriasCursadas;
        private System.Windows.Forms.Label labelMateriasCursadas;
        private System.Windows.Forms.Button buttonVerPerfil;
    }
}

