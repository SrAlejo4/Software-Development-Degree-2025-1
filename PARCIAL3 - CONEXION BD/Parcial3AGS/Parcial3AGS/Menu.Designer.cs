namespace Parcial3AGS
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eliminarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recodarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarAplicaciónToolStripMenuItem,
            this.registroProgramadorToolStripMenuItem,
            this.recodarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eliminarAplicaciónToolStripMenuItem
            // 
            this.eliminarAplicaciónToolStripMenuItem.Name = "eliminarAplicaciónToolStripMenuItem";
            this.eliminarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.eliminarAplicaciónToolStripMenuItem.Text = "Eliminar Aplicación";
            this.eliminarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.eliminarAplicaciónToolStripMenuItem_Click);
            // 
            // registroProgramadorToolStripMenuItem
            // 
            this.registroProgramadorToolStripMenuItem.Name = "registroProgramadorToolStripMenuItem";
            this.registroProgramadorToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.registroProgramadorToolStripMenuItem.Text = "Registro Programador";
            this.registroProgramadorToolStripMenuItem.Click += new System.EventHandler(this.registroProgramadorToolStripMenuItem_Click);
            // 
            // recodarClaveToolStripMenuItem
            // 
            this.recodarClaveToolStripMenuItem.Name = "recodarClaveToolStripMenuItem";
            this.recodarClaveToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.recodarClaveToolStripMenuItem.Text = "Recodar Clave";
            this.recodarClaveToolStripMenuItem.Click += new System.EventHandler(this.recodarClaveToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 699);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recodarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}