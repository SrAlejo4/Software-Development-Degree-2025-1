namespace GUI
{
    partial class Caja
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
            this.gbLogueo = new System.Windows.Forms.GroupBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.txClave = new System.Windows.Forms.TextBox();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFacturacion = new System.Windows.Forms.GroupBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btBalance = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btNueva = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.ltSucursal = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.txPago = new System.Windows.Forms.TextBox();
            this.btPagar = new System.Windows.Forms.Button();
            this.btFinFactura = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbIVA = new System.Windows.Forms.CheckBox();
            this.rbDiez = new System.Windows.Forms.RadioButton();
            this.rbCinco = new System.Windows.Forms.RadioButton();
            this.rbCero = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ldProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLogueo.SuspendLayout();
            this.gbFacturacion.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // gbLogueo
            // 
            this.gbLogueo.Controls.Add(this.btBorrar);
            this.gbLogueo.Controls.Add(this.btEnviar);
            this.gbLogueo.Controls.Add(this.txClave);
            this.gbLogueo.Controls.Add(this.txUsuario);
            this.gbLogueo.Controls.Add(this.label3);
            this.gbLogueo.Controls.Add(this.label2);
            this.gbLogueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogueo.Location = new System.Drawing.Point(36, 77);
            this.gbLogueo.Name = "gbLogueo";
            this.gbLogueo.Size = new System.Drawing.Size(640, 193);
            this.gbLogueo.TabIndex = 1;
            this.gbLogueo.TabStop = false;
            this.gbLogueo.Text = "Login";
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(454, 111);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(105, 44);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(454, 44);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(105, 45);
            this.btEnviar.TabIndex = 4;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(118, 111);
            this.txClave.Name = "txClave";
            this.txClave.PasswordChar = '*';
            this.txClave.Size = new System.Drawing.Size(303, 30);
            this.txClave.TabIndex = 3;
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(118, 51);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(303, 30);
            this.txUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario";
            // 
            // gbFacturacion
            // 
            this.gbFacturacion.Controls.Add(this.gbCliente);
            this.gbFacturacion.Controls.Add(this.gbFactura);
            this.gbFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFacturacion.Location = new System.Drawing.Point(29, 311);
            this.gbFacturacion.Name = "gbFacturacion";
            this.gbFacturacion.Size = new System.Drawing.Size(1146, 633);
            this.gbFacturacion.TabIndex = 2;
            this.gbFacturacion.TabStop = false;
            this.gbFacturacion.Text = "Facturación";
            this.gbFacturacion.Visible = false;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCliente.Controls.Add(this.btBalance);
            this.gbCliente.Controls.Add(this.btCerrar);
            this.gbCliente.Controls.Add(this.btNueva);
            this.gbCliente.Controls.Add(this.dtFecha);
            this.gbCliente.Controls.Add(this.ltSucursal);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.txCliente);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(6, 21);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1134, 153);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btBalance
            // 
            this.btBalance.Location = new System.Drawing.Point(992, 99);
            this.btBalance.Name = "btBalance";
            this.btBalance.Size = new System.Drawing.Size(101, 38);
            this.btBalance.TabIndex = 9;
            this.btBalance.Text = "Balance";
            this.btBalance.UseVisualStyleBackColor = true;
            this.btBalance.Click += new System.EventHandler(this.btBalance_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(444, 99);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(162, 37);
            this.btCerrar.TabIndex = 8;
            this.btCerrar.Text = "Cerrar Sesión";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btNueva
            // 
            this.btNueva.Location = new System.Drawing.Point(30, 103);
            this.btNueva.Name = "btNueva";
            this.btNueva.Size = new System.Drawing.Size(147, 34);
            this.btNueva.TabIndex = 7;
            this.btNueva.Text = "NuevaFactura";
            this.btNueva.UseVisualStyleBackColor = true;
            this.btNueva.Click += new System.EventHandler(this.btNueva_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(773, 29);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(334, 27);
            this.dtFecha.TabIndex = 5;
            // 
            // ltSucursal
            // 
            this.ltSucursal.FormattingEnabled = true;
            this.ltSucursal.ItemHeight = 20;
            this.ltSucursal.Items.AddRange(new object[] {
            "Bello",
            "Itagüí",
            "Envigado",
            "Medellín"});
            this.ltSucursal.Location = new System.Drawing.Point(404, 34);
            this.ltSucursal.Name = "ltSucursal";
            this.ltSucursal.Size = new System.Drawing.Size(199, 44);
            this.ltSucursal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sucursal:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha:";
            // 
            // txCliente
            // 
            this.txCliente.Location = new System.Drawing.Point(101, 34);
            this.txCliente.Name = "txCliente";
            this.txCliente.Size = new System.Drawing.Size(195, 27);
            this.txCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // gbFactura
            // 
            this.gbFactura.BackColor = System.Drawing.SystemColors.Info;
            this.gbFactura.Controls.Add(this.txPago);
            this.gbFactura.Controls.Add(this.btPagar);
            this.gbFactura.Controls.Add(this.btFinFactura);
            this.gbFactura.Controls.Add(this.btAgregar);
            this.gbFactura.Controls.Add(this.txSalida);
            this.gbFactura.Controls.Add(this.label11);
            this.gbFactura.Controls.Add(this.cbIVA);
            this.gbFactura.Controls.Add(this.rbDiez);
            this.gbFactura.Controls.Add(this.rbCinco);
            this.gbFactura.Controls.Add(this.rbCero);
            this.gbFactura.Controls.Add(this.label10);
            this.gbFactura.Controls.Add(this.nmCantidad);
            this.gbFactura.Controls.Add(this.label9);
            this.gbFactura.Controls.Add(this.txValor);
            this.gbFactura.Controls.Add(this.label8);
            this.gbFactura.Controls.Add(this.ldProducto);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.Location = new System.Drawing.Point(7, 180);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(1133, 447);
            this.gbFactura.TabIndex = 6;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            this.gbFactura.Visible = false;
            // 
            // txPago
            // 
            this.txPago.Location = new System.Drawing.Point(756, 148);
            this.txPago.Name = "txPago";
            this.txPago.Size = new System.Drawing.Size(182, 30);
            this.txPago.TabIndex = 16;
            this.txPago.Visible = false;
            // 
            // btPagar
            // 
            this.btPagar.Location = new System.Drawing.Point(756, 196);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(148, 34);
            this.btPagar.TabIndex = 15;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Visible = false;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // btFinFactura
            // 
            this.btFinFactura.Location = new System.Drawing.Point(756, 88);
            this.btFinFactura.Name = "btFinFactura";
            this.btFinFactura.Size = new System.Drawing.Size(148, 40);
            this.btFinFactura.TabIndex = 14;
            this.btFinFactura.Text = "FinFactura";
            this.btFinFactura.UseVisualStyleBackColor = true;
            this.btFinFactura.Click += new System.EventHandler(this.btFinFactura_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(756, 33);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(148, 40);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txSalida
            // 
            this.txSalida.Location = new System.Drawing.Point(15, 263);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txSalida.Size = new System.Drawing.Size(1091, 164);
            this.txSalida.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Salida";
            // 
            // cbIVA
            // 
            this.cbIVA.AutoSize = true;
            this.cbIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIVA.Location = new System.Drawing.Point(612, 95);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(67, 29);
            this.cbIVA.TabIndex = 10;
            this.cbIVA.Text = "IVA";
            this.cbIVA.UseVisualStyleBackColor = true;
            // 
            // rbDiez
            // 
            this.rbDiez.AutoSize = true;
            this.rbDiez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiez.Location = new System.Drawing.Point(286, 96);
            this.rbDiez.Name = "rbDiez";
            this.rbDiez.Size = new System.Drawing.Size(73, 29);
            this.rbDiez.TabIndex = 9;
            this.rbDiez.TabStop = true;
            this.rbDiez.Text = "10%";
            this.rbDiez.UseVisualStyleBackColor = true;
            // 
            // rbCinco
            // 
            this.rbCinco.AutoSize = true;
            this.rbCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCinco.Location = new System.Drawing.Point(206, 96);
            this.rbCinco.Name = "rbCinco";
            this.rbCinco.Size = new System.Drawing.Size(62, 29);
            this.rbCinco.TabIndex = 8;
            this.rbCinco.TabStop = true;
            this.rbCinco.Text = "5%";
            this.rbCinco.UseVisualStyleBackColor = true;
            // 
            // rbCero
            // 
            this.rbCero.AutoSize = true;
            this.rbCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCero.Location = new System.Drawing.Point(134, 96);
            this.rbCero.Name = "rbCero";
            this.rbCero.Size = new System.Drawing.Size(62, 29);
            this.rbCero.TabIndex = 7;
            this.rbCero.TabStop = true;
            this.rbCero.Text = "0%";
            this.rbCero.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Descuento";
            // 
            // nmCantidad
            // 
            this.nmCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCantidad.Location = new System.Drawing.Point(612, 39);
            this.nmCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(103, 30);
            this.nmCantidad.TabIndex = 5;
            this.nmCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(514, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cantidad";
            // 
            // txValor
            // 
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Location = new System.Drawing.Point(359, 35);
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            this.txValor.Size = new System.Drawing.Size(100, 30);
            this.txValor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Valor";
            // 
            // ldProducto
            // 
            this.ldProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldProducto.FormattingEnabled = true;
            this.ldProducto.Items.AddRange(new object[] {
            "Pantalón",
            "Camisa",
            "Falda",
            "Blusa",
            "Medias"});
            this.ldProducto.Location = new System.Drawing.Point(118, 30);
            this.ldProducto.Name = "ldProducto";
            this.ldProducto.Size = new System.Drawing.Size(136, 33);
            this.ldProducto.TabIndex = 1;
            this.ldProducto.SelectedIndexChanged += new System.EventHandler(this.ldProducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(808, 257);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(105, 48);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.calc;
            this.pictureBox1.Location = new System.Drawing.Point(750, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1187, 951);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.gbFacturacion);
            this.Controls.Add(this.gbLogueo);
            this.Controls.Add(this.label1);
            this.Name = "Caja";
            this.Text = "Caja";
            this.gbLogueo.ResumeLayout(false);
            this.gbLogueo.PerformLayout();
            this.gbFacturacion.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLogueo;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFacturacion;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ltSucursal;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btBalance;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btNueva;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ldProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbIVA;
        private System.Windows.Forms.RadioButton rbDiez;
        private System.Windows.Forms.RadioButton rbCinco;
        private System.Windows.Forms.RadioButton rbCero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.TextBox txPago;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.Button btFinFactura;
        private System.Windows.Forms.Button btAgregar;
    }
}