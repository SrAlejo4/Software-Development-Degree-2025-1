namespace PrestamosEquipos
{
    partial class Cajero
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
            this.txMonto = new System.Windows.Forms.TextBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.lbDiez = new System.Windows.Forms.Label();
            this.lbCinco = new System.Windows.Forms.Label();
            this.lbDos = new System.Windows.Forms.Label();
            this.lbMil = new System.Windows.Forms.Label();
            this.pbMil = new System.Windows.Forms.PictureBox();
            this.pbCinco = new System.Windows.Forms.PictureBox();
            this.pbDos = new System.Windows.Forms.PictureBox();
            this.pbDiez = new System.Windows.Forms.PictureBox();
            this.btRegresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiez)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el dinero a retirar (Máximo $200.000)";
            // 
            // txMonto
            // 
            this.txMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMonto.Location = new System.Drawing.Point(34, 123);
            this.txMonto.Name = "txMonto";
            this.txMonto.Size = new System.Drawing.Size(244, 30);
            this.txMonto.TabIndex = 1;
            this.txMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txMonto_KeyPress);
            // 
            // btIngresar
            // 
            this.btIngresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.Location = new System.Drawing.Point(350, 122);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(110, 38);
            this.btIngresar.TabIndex = 2;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // lbDiez
            // 
            this.lbDiez.AutoSize = true;
            this.lbDiez.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiez.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbDiez.Location = new System.Drawing.Point(220, 255);
            this.lbDiez.Name = "lbDiez";
            this.lbDiez.Size = new System.Drawing.Size(92, 48);
            this.lbDiez.TabIndex = 3;
            this.lbDiez.Text = "# X";
            this.lbDiez.Visible = false;
            // 
            // lbCinco
            // 
            this.lbCinco.AutoSize = true;
            this.lbCinco.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinco.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbCinco.Location = new System.Drawing.Point(220, 466);
            this.lbCinco.Name = "lbCinco";
            this.lbCinco.Size = new System.Drawing.Size(92, 48);
            this.lbCinco.TabIndex = 4;
            this.lbCinco.Text = "# X";
            this.lbCinco.Visible = false;
            // 
            // lbDos
            // 
            this.lbDos.AutoSize = true;
            this.lbDos.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbDos.Location = new System.Drawing.Point(220, 647);
            this.lbDos.Name = "lbDos";
            this.lbDos.Size = new System.Drawing.Size(92, 48);
            this.lbDos.TabIndex = 5;
            this.lbDos.Text = "# X";
            this.lbDos.Visible = false;
            // 
            // lbMil
            // 
            this.lbMil.AutoSize = true;
            this.lbMil.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbMil.Location = new System.Drawing.Point(220, 856);
            this.lbMil.Name = "lbMil";
            this.lbMil.Size = new System.Drawing.Size(92, 48);
            this.lbMil.TabIndex = 6;
            this.lbMil.Text = "# X";
            this.lbMil.Visible = false;
            // 
            // pbMil
            // 
            this.pbMil.Image = global::PrestamosEquipos.Properties.Resources.milpesos;
            this.pbMil.Location = new System.Drawing.Point(445, 798);
            this.pbMil.Name = "pbMil";
            this.pbMil.Size = new System.Drawing.Size(307, 162);
            this.pbMil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMil.TabIndex = 10;
            this.pbMil.TabStop = false;
            this.pbMil.Visible = false;
            // 
            // pbCinco
            // 
            this.pbCinco.Image = global::PrestamosEquipos.Properties.Resources._5mil;
            this.pbCinco.Location = new System.Drawing.Point(445, 399);
            this.pbCinco.Name = "pbCinco";
            this.pbCinco.Size = new System.Drawing.Size(307, 162);
            this.pbCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCinco.TabIndex = 9;
            this.pbCinco.TabStop = false;
            this.pbCinco.Visible = false;
            // 
            // pbDos
            // 
            this.pbDos.Image = global::PrestamosEquipos.Properties.Resources._2mil;
            this.pbDos.Location = new System.Drawing.Point(445, 596);
            this.pbDos.Name = "pbDos";
            this.pbDos.Size = new System.Drawing.Size(307, 162);
            this.pbDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDos.TabIndex = 8;
            this.pbDos.TabStop = false;
            this.pbDos.Visible = false;
            // 
            // pbDiez
            // 
            this.pbDiez.Image = global::PrestamosEquipos.Properties.Resources._10mil;
            this.pbDiez.Location = new System.Drawing.Point(445, 203);
            this.pbDiez.Name = "pbDiez";
            this.pbDiez.Size = new System.Drawing.Size(307, 162);
            this.pbDiez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiez.TabIndex = 7;
            this.pbDiez.TabStop = false;
            this.pbDiez.Visible = false;
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(529, 123);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(110, 38);
            this.btRegresar.TabIndex = 11;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(709, 123);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(110, 38);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(888, 983);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.pbMil);
            this.Controls.Add(this.pbCinco);
            this.Controls.Add(this.pbDos);
            this.Controls.Add(this.pbDiez);
            this.Controls.Add(this.lbMil);
            this.Controls.Add(this.lbDos);
            this.Controls.Add(this.lbCinco);
            this.Controls.Add(this.lbDiez);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.txMonto);
            this.Controls.Add(this.label1);
            this.Name = "Cajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbMil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txMonto;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Label lbDiez;
        private System.Windows.Forms.Label lbCinco;
        private System.Windows.Forms.Label lbDos;
        private System.Windows.Forms.Label lbMil;
        private System.Windows.Forms.PictureBox pbDiez;
        private System.Windows.Forms.PictureBox pbDos;
        private System.Windows.Forms.PictureBox pbCinco;
        private System.Windows.Forms.PictureBox pbMil;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btSalir;
    }
}