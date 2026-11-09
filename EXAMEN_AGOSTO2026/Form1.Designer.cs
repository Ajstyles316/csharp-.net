namespace EXAMEN_AGOSTO2026
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.TXTCONTRA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.BTNINGRESAR = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTCONTRA
            // 
            this.TXTCONTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCONTRA.Location = new System.Drawing.Point(549, 242);
            this.TXTCONTRA.Margin = new System.Windows.Forms.Padding(5);
            this.TXTCONTRA.Name = "TXTCONTRA";
            this.TXTCONTRA.PasswordChar = '*';
            this.TXTCONTRA.Size = new System.Drawing.Size(467, 34);
            this.TXTCONTRA.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(543, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(543, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "INGRESE SU CORREO";
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSUARIO.Location = new System.Drawing.Point(548, 108);
            this.TXTUSUARIO.Margin = new System.Windows.Forms.Padding(5);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(467, 34);
            this.TXTUSUARIO.TabIndex = 14;
            // 
            // BTNINGRESAR
            // 
            this.BTNINGRESAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNINGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNINGRESAR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Alien_Logo;
            this.BTNINGRESAR.Location = new System.Drawing.Point(587, 308);
            this.BTNINGRESAR.Margin = new System.Windows.Forms.Padding(5);
            this.BTNINGRESAR.Name = "BTNINGRESAR";
            this.BTNINGRESAR.Size = new System.Drawing.Size(365, 111);
            this.BTNINGRESAR.TabIndex = 13;
            this.BTNINGRESAR.Text = "INGRESAR";
            this.BTNINGRESAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNINGRESAR.UseVisualStyleBackColor = false;
            this.BTNINGRESAR.Click += new System.EventHandler(this.BTNINGRESAR_Click);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNSALIR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Error1;
            this.BTNSALIR.Location = new System.Drawing.Point(587, 440);
            this.BTNSALIR.Margin = new System.Windows.Forms.Padding(5);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(365, 108);
            this.BTNSALIR.TabIndex = 12;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.IronMan;
            this.pictureBox1.Location = new System.Drawing.Point(75, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1041, 596);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.BTNINGRESAR);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.TXTCONTRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGIN";
            this.Text = "INICIO DE SESIÓN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNINGRESAR;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.TextBox TXTCONTRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXTUSUARIO;
    }
}

