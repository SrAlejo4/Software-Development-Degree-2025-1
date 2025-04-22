namespace RestauranteBD
{
    partial class ActualizarPlato
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
            this.components = new System.ComponentModel.Container();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.cbCodChef = new System.Windows.Forms.ComboBox();
            this.restauranteDataSet = new RestauranteBD.RestauranteDataSet();
            this.chefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chefTableAdapter = new RestauranteBD.RestauranteDataSetTableAdapters.chefTableAdapter();
            this.btGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(666, 467);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(185, 45);
            this.btRegresar.TabIndex = 59;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(666, 319);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(185, 45);
            this.btLimpiar.TabIndex = 58;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Location = new System.Drawing.Point(666, 245);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(185, 45);
            this.btConsultar.TabIndex = 57;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 50);
            this.label5.TabIndex = 56;
            this.label5.Text = "Actualizar plato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.TabIndex = 52;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 51;
            this.label2.Text = "Código Chef";
            // 
            // txCodigo
            // 
            this.txCodigo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodigo.Location = new System.Drawing.Point(305, 245);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(194, 30);
            this.txCodigo.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código";
            // 
            // txNombre
            // 
            this.txNombre.Enabled = false;
            this.txNombre.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(305, 322);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(194, 30);
            this.txNombre.TabIndex = 60;
            // 
            // txValor
            // 
            this.txValor.Enabled = false;
            this.txValor.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Location = new System.Drawing.Point(305, 392);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(194, 30);
            this.txValor.TabIndex = 61;
            // 
            // cbCodChef
            // 
            this.cbCodChef.DataSource = this.chefBindingSource;
            this.cbCodChef.DisplayMember = "nombre";
            this.cbCodChef.Enabled = false;
            this.cbCodChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodChef.FormattingEnabled = true;
            this.cbCodChef.Location = new System.Drawing.Point(305, 474);
            this.cbCodChef.Name = "cbCodChef";
            this.cbCodChef.Size = new System.Drawing.Size(194, 33);
            this.cbCodChef.TabIndex = 62;
            this.cbCodChef.ValueMember = "codigo";
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chefBindingSource
            // 
            this.chefBindingSource.DataMember = "chef";
            this.chefBindingSource.DataSource = this.restauranteDataSet;
            // 
            // chefTableAdapter
            // 
            this.chefTableAdapter.ClearBeforeFill = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Enabled = false;
            this.btGuardar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(666, 392);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(185, 45);
            this.btGuardar.TabIndex = 63;
            this.btGuardar.Text = "Guardar Cambios";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // ActualizarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 695);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.cbCodChef);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarPlato";
            this.Text = "ActualizarPlato";
            this.Load += new System.EventHandler(this.ActualizarPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.ComboBox cbCodChef;
        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource chefBindingSource;
        private RestauranteDataSetTableAdapters.chefTableAdapter chefTableAdapter;
        private System.Windows.Forms.Button btGuardar;
    }
}