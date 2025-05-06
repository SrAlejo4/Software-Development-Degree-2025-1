namespace Platos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCod = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.txChef = new System.Windows.Forms.TextBox();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.btConGeneral = new System.Windows.Forms.Button();
            this.btPorCodigo = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones sobre Platos desde API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chef";
            // 
            // txCod
            // 
            this.txCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCod.Location = new System.Drawing.Point(241, 168);
            this.txCod.Name = "txCod";
            this.txCod.Size = new System.Drawing.Size(224, 30);
            this.txCod.TabIndex = 5;
            // 
            // txNom
            // 
            this.txNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNom.Location = new System.Drawing.Point(241, 246);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(224, 30);
            this.txNom.TabIndex = 6;
            // 
            // txValor
            // 
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Location = new System.Drawing.Point(241, 323);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(224, 30);
            this.txValor.TabIndex = 7;
            // 
            // txChef
            // 
            this.txChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txChef.Location = new System.Drawing.Point(241, 405);
            this.txChef.Name = "txChef";
            this.txChef.Size = new System.Drawing.Size(224, 30);
            this.txChef.TabIndex = 8;
            // 
            // txSalida
            // 
            this.txSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSalida.Location = new System.Drawing.Point(51, 529);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txSalida.Size = new System.Drawing.Size(1158, 219);
            this.txSalida.TabIndex = 9;
            // 
            // btConGeneral
            // 
            this.btConGeneral.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConGeneral.Location = new System.Drawing.Point(735, 135);
            this.btConGeneral.Name = "btConGeneral";
            this.btConGeneral.Size = new System.Drawing.Size(272, 44);
            this.btConGeneral.TabIndex = 10;
            this.btConGeneral.Text = "Consulta general";
            this.btConGeneral.UseVisualStyleBackColor = true;
            // 
            // btPorCodigo
            // 
            this.btPorCodigo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPorCodigo.Location = new System.Drawing.Point(735, 209);
            this.btPorCodigo.Name = "btPorCodigo";
            this.btPorCodigo.Size = new System.Drawing.Size(272, 44);
            this.btPorCodigo.TabIndex = 11;
            this.btPorCodigo.Text = "Consulta por código";
            this.btPorCodigo.UseVisualStyleBackColor = true;
            // 
            // btNuevo
            // 
            this.btNuevo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(735, 284);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(272, 44);
            this.btNuevo.TabIndex = 12;
            this.btNuevo.Text = "Nuevo Plato";
            this.btNuevo.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(735, 368);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(272, 44);
            this.btModificar.TabIndex = 13;
            this.btModificar.Text = "Modificar plato";
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(735, 454);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(278, 44);
            this.btEliminar.TabIndex = 14;
            this.btEliminar.Text = "Eliminar plato";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 771);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btPorCodigo);
            this.Controls.Add(this.btConGeneral);
            this.Controls.Add(this.txSalida);
            this.Controls.Add(this.txChef);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.txNom);
            this.Controls.Add(this.txCod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCod;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.TextBox txChef;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.Button btConGeneral;
        private System.Windows.Forms.Button btPorCodigo;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
    }
}

