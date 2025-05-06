namespace PrestamosEquipos
{
    partial class Computadores
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
            this.txSalidaComputadores = new System.Windows.Forms.TextBox();
            this.lbNombreAppear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txSalidaComputadores
            // 
            this.txSalidaComputadores.AllowDrop = true;
            this.txSalidaComputadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txSalidaComputadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSalidaComputadores.Location = new System.Drawing.Point(36, 113);
            this.txSalidaComputadores.Multiline = true;
            this.txSalidaComputadores.Name = "txSalidaComputadores";
            this.txSalidaComputadores.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txSalidaComputadores.Size = new System.Drawing.Size(1204, 373);
            this.txSalidaComputadores.TabIndex = 0;
            // 
            // lbNombreAppear
            // 
            this.lbNombreAppear.AutoSize = true;
            this.lbNombreAppear.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAppear.Location = new System.Drawing.Point(41, 50);
            this.lbNombreAppear.Name = "lbNombreAppear";
            this.lbNombreAppear.Size = new System.Drawing.Size(578, 47);
            this.lbNombreAppear.TabIndex = 31;
            this.lbNombreAppear.Text = "Listado de prestamo de computadores";
            // 
            // Computadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1265, 767);
            this.Controls.Add(this.lbNombreAppear);
            this.Controls.Add(this.txSalidaComputadores);
            this.Name = "Computadores";
            this.Text = "Computadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txSalidaComputadores;
        private System.Windows.Forms.Label lbNombreAppear;
    }
}