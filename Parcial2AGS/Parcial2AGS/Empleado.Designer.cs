namespace Parcial2AGS
{
    partial class Empleado
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
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.btTotal = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.rbSindicato = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medidor de productividad";
            // 
            // txNombre
            // 
            this.txNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNombre.Location = new System.Drawing.Point(59, 180);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(167, 30);
            this.txNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salario Básico";
            // 
            // txSalario
            // 
            this.txSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSalario.Location = new System.Drawing.Point(307, 180);
            this.txSalario.Name = "txSalario";
            this.txSalario.Size = new System.Drawing.Size(167, 30);
            this.txSalario.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad de unidades producidas";
            // 
            // txCantidad
            // 
            this.txCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCantidad.Location = new System.Drawing.Point(509, 180);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(176, 30);
            this.txCantidad.TabIndex = 7;
            // 
            // btTotal
            // 
            this.btTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTotal.Location = new System.Drawing.Point(196, 288);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(243, 63);
            this.btTotal.TabIndex = 9;
            this.btTotal.Text = "Total a pagar";
            this.btTotal.UseVisualStyleBackColor = true;
            this.btTotal.Click += new System.EventHandler(this.btTotal_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(543, 288);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(243, 63);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // rbSindicato
            // 
            this.rbSindicato.AutoSize = true;
            this.rbSindicato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSindicato.Location = new System.Drawing.Point(763, 180);
            this.rbSindicato.Name = "rbSindicato";
            this.rbSindicato.Size = new System.Drawing.Size(224, 29);
            this.rbSindicato.TabIndex = 11;
            this.rbSindicato.TabStop = true;
            this.rbSindicato.Text = "Pertenece al sindicato";
            this.rbSindicato.UseVisualStyleBackColor = true;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 730);
            this.Controls.Add(this.rbSindicato);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label1);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Button btTotal;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.RadioButton rbSindicato;
    }
}