namespace GUI
{
    partial class Juego
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
            this.txNumero = new System.Windows.Forms.TextBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btJugar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(215, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adivina Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txNumero
            // 
            this.txNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumero.Location = new System.Drawing.Point(175, 131);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(117, 30);
            this.txNumero.TabIndex = 1;
            // 
            // btNuevo
            // 
            this.btNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(587, 157);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(154, 71);
            this.btNuevo.TabIndex = 2;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btJugar
            // 
            this.btJugar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btJugar.Enabled = false;
            this.btJugar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJugar.Location = new System.Drawing.Point(587, 272);
            this.btJugar.Name = "btJugar";
            this.btJugar.Size = new System.Drawing.Size(154, 71);
            this.btJugar.TabIndex = 3;
            this.btJugar.Text = "Jugar";
            this.btJugar.UseVisualStyleBackColor = false;
            this.btJugar.Click += new System.EventHandler(this.btJugar_Click);
            this.btJugar.Enter += new System.EventHandler(this.btJugar_Enter);
            this.btJugar.Leave += new System.EventHandler(this.btJugar_Leave);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(587, 394);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(154, 77);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(62, 219);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 23);
            this.lbMensaje.TabIndex = 7;
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::GUI.Properties.Resources.snoopy;
            this.pbImagen.Location = new System.Drawing.Point(56, 272);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(299, 234);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            this.pbImagen.Visible = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 603);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btJugar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.label1);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Click += new System.EventHandler(this.label1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btJugar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lbMensaje;
    }
}