namespace Parcial2AGS
{
    partial class Pizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTamano = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btFinDia = new System.Windows.Forms.Button();
            this.chbQueso = new System.Windows.Forms.CheckBox();
            this.chbChampinones = new System.Windows.Forms.CheckBox();
            this.chbTocineta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzeria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione las características de la pizza";
            // 
            // cbTamano
            // 
            this.cbTamano.FormattingEnabled = true;
            this.cbTamano.Items.AddRange(new object[] {
            "Pequeña",
            "Mediana",
            "Grande"});
            this.cbTamano.Location = new System.Drawing.Point(74, 235);
            this.cbTamano.Name = "cbTamano";
            this.cbTamano.Size = new System.Drawing.Size(242, 24);
            this.cbTamano.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingredientes extras";
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(846, 140);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(140, 51);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(846, 218);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(140, 51);
            this.btRegistrar.TabIndex = 9;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btFinDia
            // 
            this.btFinDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinDia.Location = new System.Drawing.Point(846, 308);
            this.btFinDia.Name = "btFinDia";
            this.btFinDia.Size = new System.Drawing.Size(140, 51);
            this.btFinDia.TabIndex = 10;
            this.btFinDia.Text = "Fin Día";
            this.btFinDia.UseVisualStyleBackColor = true;
            this.btFinDia.Click += new System.EventHandler(this.btFinDia_Click);
            // 
            // chbQueso
            // 
            this.chbQueso.AutoSize = true;
            this.chbQueso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbQueso.Location = new System.Drawing.Point(387, 236);
            this.chbQueso.Name = "chbQueso";
            this.chbQueso.Size = new System.Drawing.Size(93, 29);
            this.chbQueso.TabIndex = 14;
            this.chbQueso.Text = "Queso";
            this.chbQueso.UseVisualStyleBackColor = true;
            // 
            // chbChampinones
            // 
            this.chbChampinones.AutoSize = true;
            this.chbChampinones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbChampinones.Location = new System.Drawing.Point(386, 291);
            this.chbChampinones.Name = "chbChampinones";
            this.chbChampinones.Size = new System.Drawing.Size(156, 29);
            this.chbChampinones.TabIndex = 15;
            this.chbChampinones.Text = "Champiñones";
            this.chbChampinones.UseVisualStyleBackColor = true;
            // 
            // chbTocineta
            // 
            this.chbTocineta.AutoSize = true;
            this.chbTocineta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTocineta.Location = new System.Drawing.Point(386, 341);
            this.chbTocineta.Name = "chbTocineta";
            this.chbTocineta.Size = new System.Drawing.Size(110, 29);
            this.chbTocineta.TabIndex = 16;
            this.chbTocineta.Text = "Tocineta";
            this.chbTocineta.UseVisualStyleBackColor = true;
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 741);
            this.Controls.Add(this.chbTocineta);
            this.Controls.Add(this.chbChampinones);
            this.Controls.Add(this.chbQueso);
            this.Controls.Add(this.btFinDia);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTamano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTamano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btFinDia;
        private System.Windows.Forms.CheckBox chbQueso;
        private System.Windows.Forms.CheckBox chbChampinones;
        private System.Windows.Forms.CheckBox chbTocineta;
    }
}