namespace LaboratorioEnClase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId_consola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.dataGridViewTabla = new System.Windows.Forms.DataGridView();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCompañia = new System.Windows.Forms.ComboBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonProbar = new System.Windows.Forms.Button();
            this.dateTimePickerAñolanza = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscarCompañia = new System.Windows.Forms.Button();
            this.Labelrasdfasd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxId_consola
            // 
            this.textBoxId_consola.Location = new System.Drawing.Point(220, 40);
            this.textBoxId_consola.Name = "textBoxId_consola";
            this.textBoxId_consola.Size = new System.Drawing.Size(251, 22);
            this.textBoxId_consola.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la consola";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(220, 85);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(251, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año de lanzamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Generación";
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(220, 203);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(251, 22);
            this.textBoxGeneracion.TabIndex = 7;
            // 
            // dataGridViewTabla
            // 
            this.dataGridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabla.Location = new System.Drawing.Point(519, 162);
            this.dataGridViewTabla.Name = "dataGridViewTabla";
            this.dataGridViewTabla.RowHeadersWidth = 51;
            this.dataGridViewTabla.RowTemplate.Height = 24;
            this.dataGridViewTabla.Size = new System.Drawing.Size(773, 393);
            this.dataGridViewTabla.TabIndex = 8;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertar.Location = new System.Drawing.Point(47, 271);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(120, 38);
            this.buttonInsertar.TabIndex = 9;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Location = new System.Drawing.Point(212, 271);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(120, 38);
            this.buttonBorrar.TabIndex = 10;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(47, 362);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(120, 38);
            this.buttonActualizar.TabIndex = 11;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(212, 362);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(120, 38);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Compañia ";
            // 
            // comboBoxCompañia
            // 
            this.comboBoxCompañia.FormattingEnabled = true;
            this.comboBoxCompañia.Location = new System.Drawing.Point(220, 118);
            this.comboBoxCompañia.Name = "comboBoxCompañia";
            this.comboBoxCompañia.Size = new System.Drawing.Size(251, 24);
            this.comboBoxCompañia.TabIndex = 14;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(212, 454);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(120, 38);
            this.buttonCargar.TabIndex = 15;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonProbar
            // 
            this.buttonProbar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbar.Location = new System.Drawing.Point(47, 454);
            this.buttonProbar.Name = "buttonProbar";
            this.buttonProbar.Size = new System.Drawing.Size(120, 38);
            this.buttonProbar.TabIndex = 16;
            this.buttonProbar.Text = "Prueba";
            this.buttonProbar.UseVisualStyleBackColor = true;
            this.buttonProbar.Click += new System.EventHandler(this.buttonProbar_Click);
            // 
            // dateTimePickerAñolanza
            // 
            this.dateTimePickerAñolanza.Location = new System.Drawing.Point(220, 158);
            this.dateTimePickerAñolanza.Name = "dateTimePickerAñolanza";
            this.dateTimePickerAñolanza.Size = new System.Drawing.Size(251, 22);
            this.dateTimePickerAñolanza.TabIndex = 17;
            // 
            // buttonBuscarCompañia
            // 
            this.buttonBuscarCompañia.Location = new System.Drawing.Point(495, 120);
            this.buttonBuscarCompañia.Name = "buttonBuscarCompañia";
            this.buttonBuscarCompañia.Size = new System.Drawing.Size(93, 23);
            this.buttonBuscarCompañia.TabIndex = 18;
            this.buttonBuscarCompañia.Text = "Buscar";
            this.buttonBuscarCompañia.UseVisualStyleBackColor = true;
            // 
            // Labelrasdfasd
            // 
            this.Labelrasdfasd.AutoSize = true;
            this.Labelrasdfasd.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelrasdfasd.Location = new System.Drawing.Point(12, 575);
            this.Labelrasdfasd.Name = "Labelrasdfasd";
            this.Labelrasdfasd.Size = new System.Drawing.Size(495, 39);
            this.Labelrasdfasd.TabIndex = 19;
            this.Labelrasdfasd.Text = "Yenci Maria Hernandez Martinez";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(526, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Marvin Alexander Cámbara Alonzo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 575);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Carnet: 0905-23-5766";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 39);
            this.label8.TabIndex = 22;
            this.label8.Text = "Carnet: 0905-23-17848";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 710);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Labelrasdfasd);
            this.Controls.Add(this.buttonBuscarCompañia);
            this.Controls.Add(this.dateTimePickerAñolanza);
            this.Controls.Add(this.buttonProbar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.comboBoxCompañia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.dataGridViewTabla);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId_consola);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId_consola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.DataGridView dataGridViewTabla;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCompañia;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonProbar;
        private System.Windows.Forms.DateTimePicker dateTimePickerAñolanza;
        private System.Windows.Forms.Button buttonBuscarCompañia;
        private System.Windows.Forms.Label Labelrasdfasd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

