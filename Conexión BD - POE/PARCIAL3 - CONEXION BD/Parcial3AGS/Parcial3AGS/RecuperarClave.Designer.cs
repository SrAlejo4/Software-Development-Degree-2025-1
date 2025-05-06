namespace Parcial3AGS
{
    partial class RecuperarClave
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
            this.btRegresar = new System.Windows.Forms.Button();
            this.btIngresar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.respuestaLabel = new System.Windows.Forms.Label();
            this.txRespuesta = new System.Windows.Forms.TextBox();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.showPregunta = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.showContrasena = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRegresar
            // 
            this.btRegresar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegresar.Location = new System.Drawing.Point(765, 462);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(185, 45);
            this.btRegresar.TabIndex = 59;
            this.btRegresar.Text = "Regresar";
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // btIngresar
            // 
            this.btIngresar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.Location = new System.Drawing.Point(765, 187);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(185, 45);
            this.btIngresar.TabIndex = 57;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 50);
            this.label5.TabIndex = 56;
            this.label5.Text = "Recuperar clave";
            // 
            // respuestaLabel
            // 
            this.respuestaLabel.AutoSize = true;
            this.respuestaLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuestaLabel.Location = new System.Drawing.Point(145, 364);
            this.respuestaLabel.Name = "respuestaLabel";
            this.respuestaLabel.Size = new System.Drawing.Size(220, 36);
            this.respuestaLabel.TabIndex = 54;
            this.respuestaLabel.Text = "Ingrese la respuesta";
            this.respuestaLabel.Visible = false;
            // 
            // txRespuesta
            // 
            this.txRespuesta.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRespuesta.Location = new System.Drawing.Point(388, 368);
            this.txRespuesta.Name = "txRespuesta";
            this.txRespuesta.Size = new System.Drawing.Size(291, 30);
            this.txRespuesta.TabIndex = 50;
            this.txRespuesta.Visible = false;
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.Location = new System.Drawing.Point(192, 277);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(108, 36);
            this.labelPregunta.TabIndex = 49;
            this.labelPregunta.Text = "Pregunta";
            this.labelPregunta.Visible = false;
            // 
            // showPregunta
            // 
            this.showPregunta.AutoSize = true;
            this.showPregunta.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPregunta.ForeColor = System.Drawing.Color.Red;
            this.showPregunta.Location = new System.Drawing.Point(379, 262);
            this.showPregunta.Name = "showPregunta";
            this.showPregunta.Size = new System.Drawing.Size(276, 50);
            this.showPregunta.TabIndex = 61;
            this.showPregunta.Text = "Recuperar clave";
            this.showPregunta.Visible = false;
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.Location = new System.Drawing.Point(154, 466);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(146, 36);
            this.labelContrasena.TabIndex = 62;
            this.labelContrasena.Text = "Contraseña: ";
            this.labelContrasena.Visible = false;
            // 
            // showContrasena
            // 
            this.showContrasena.AutoSize = true;
            this.showContrasena.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showContrasena.Location = new System.Drawing.Point(382, 466);
            this.showContrasena.Name = "showContrasena";
            this.showContrasena.Size = new System.Drawing.Size(278, 36);
            this.showContrasena.TabIndex = 63;
            this.showContrasena.Text = "AQUÍ VA LA CONTRASEÑA";
            this.showContrasena.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 36);
            this.label2.TabIndex = 65;
            this.label2.Text = "Ingrese su usuario";
            // 
            // txUsuario
            // 
            this.txUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsuario.Location = new System.Drawing.Point(388, 187);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(291, 30);
            this.txUsuario.TabIndex = 64;
            // 
            // btEnviar
            // 
            this.btEnviar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Location = new System.Drawing.Point(765, 355);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(185, 45);
            this.btEnviar.TabIndex = 66;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Visible = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // RecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.showContrasena);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.showPregunta);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.respuestaLabel);
            this.Controls.Add(this.txRespuesta);
            this.Controls.Add(this.labelPregunta);
            this.Name = "RecuperarClave";
            this.Text = "RecuperarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label respuestaLabel;
        private System.Windows.Forms.TextBox txRespuesta;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label showPregunta;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label showContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Button btEnviar;
    }
}