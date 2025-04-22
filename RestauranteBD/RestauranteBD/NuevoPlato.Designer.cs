namespace RestauranteBD
{
    partial class NuevoPlato
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
            this.btBorrar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet = new RestauranteBD.RestauranteDataSet();
            this.chefTableAdapter = new RestauranteBD.RestauranteDataSetTableAdapters.chefTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(671, 399);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(185, 45);
            this.btRegresar.TabIndex = 35;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(671, 312);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(185, 45);
            this.btBorrar.TabIndex = 34;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(671, 230);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(185, 45);
            this.btAgregar.TabIndex = 33;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 50);
            this.label5.TabIndex = 32;
            this.label5.Text = "Agregar plato";
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(321, 286);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(194, 30);
            this.txNombre.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 36);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre";
            // 
            // txValor
            // 
            this.txValor.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Location = new System.Drawing.Point(321, 358);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(194, 30);
            this.txValor.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.TabIndex = 28;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código Chef";
            // 
            // txCodigo
            // 
            this.txCodigo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCodigo.Location = new System.Drawing.Point(321, 211);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(194, 30);
            this.txCodigo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chefBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 33);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.ValueMember = "codigo";
            // 
            // chefBindingSource
            // 
            this.chefBindingSource.DataMember = "chef";
            this.chefBindingSource.DataSource = this.restauranteDataSet;
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chefTableAdapter
            // 
            this.chefTableAdapter.ClearBeforeFill = true;
            // 
            // NuevoPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 719);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NuevoPlato";
            this.Text = "NuevoPlato";
            this.Load += new System.EventHandler(this.NuevoPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource chefBindingSource;
        private RestauranteDataSetTableAdapters.chefTableAdapter chefTableAdapter;
    }
}