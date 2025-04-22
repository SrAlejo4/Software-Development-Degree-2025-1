namespace RestauranteBD
{
    partial class Restaurante
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
            this.label3 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txClave = new System.Windows.Forms.TextBox();
            this.lbRecuperar = new System.Windows.Forms.LinkLabel();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(292, 179);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(315, 30);
            this.txUsuario.TabIndex = 3;
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(292, 259);
            this.txClave.Name = "txClave";
            this.txClave.PasswordChar = '*';
            this.txClave.Size = new System.Drawing.Size(315, 30);
            this.txClave.TabIndex = 4;
            // 
            // lbRecuperar
            // 
            this.lbRecuperar.AutoSize = true;
            this.lbRecuperar.Location = new System.Drawing.Point(171, 362);
            this.lbRecuperar.Name = "lbRecuperar";
            this.lbRecuperar.Size = new System.Drawing.Size(153, 25);
            this.lbRecuperar.TabIndex = 5;
            this.lbRecuperar.TabStop = true;
            this.lbRecuperar.Text = "Recuperar clave";
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(768, 159);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(151, 45);
            this.btEnviar.TabIndex = 6;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(768, 252);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(151, 45);
            this.btBorrar.TabIndex = 7;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Image = global::RestauranteBD.Properties.Resources.Salir;
            this.btSalir.Location = new System.Drawing.Point(768, 342);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(151, 45);
            this.btSalir.TabIndex = 8;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 726);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.lbRecuperar);
            this.Controls.Add(this.txClave);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Restaurante";
            this.Text = "AppRestaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.LinkLabel lbRecuperar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btSalir;
    }
}