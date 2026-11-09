namespace EXAMEN_AGOSTO2026
{
    partial class PRINCIPAL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRINCIPAL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNREPORTE = new System.Windows.Forms.Button();
            this.BTNUSUARIO = new System.Windows.Forms.Button();
            this.LBLBIENVENIDA = new System.Windows.Forms.Label();
            this.LBLRELOJ = new System.Windows.Forms.Label();
            this.TIMERRELOJ = new System.Windows.Forms.Timer(this.components);
            this.LBLTOTALACCESOS = new System.Windows.Forms.Label();
            this.LBLTOTALUSUARIOS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.LBLTOTALUSUARIOS);
            this.groupBox1.Controls.Add(this.LBLTOTALACCESOS);
            this.groupBox1.Controls.Add(this.LBLRELOJ);
            this.groupBox1.Controls.Add(this.LBLBIENVENIDA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(4, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENÚ PRINCIPAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.BTNSALIR);
            this.panel1.Controls.Add(this.BTNREPORTE);
            this.panel1.Controls.Add(this.BTNUSUARIO);
            this.panel1.Location = new System.Drawing.Point(4, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 170);
            this.panel1.TabIndex = 2;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.SteelBlue;
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNSALIR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Error1;
            this.BTNSALIR.Location = new System.Drawing.Point(880, 0);
            this.BTNSALIR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(184, 170);
            this.BTNSALIR.TabIndex = 2;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNREPORTE
            // 
            this.BTNREPORTE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTNREPORTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREPORTE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNREPORTE.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Desktop;
            this.BTNREPORTE.Location = new System.Drawing.Point(193, 0);
            this.BTNREPORTE.Margin = new System.Windows.Forms.Padding(4);
            this.BTNREPORTE.Name = "BTNREPORTE";
            this.BTNREPORTE.Size = new System.Drawing.Size(184, 170);
            this.BTNREPORTE.TabIndex = 1;
            this.BTNREPORTE.Text = "REPORTE\r\nINGRESO";
            this.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNREPORTE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNREPORTE.UseVisualStyleBackColor = false;
            this.BTNREPORTE.Click += new System.EventHandler(this.BTNREPORTE_Click);
            // 
            // BTNUSUARIO
            // 
            this.BTNUSUARIO.BackColor = System.Drawing.Color.SteelBlue;
            this.BTNUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUSUARIO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNUSUARIO.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.User1;
            this.BTNUSUARIO.Location = new System.Drawing.Point(1, 0);
            this.BTNUSUARIO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNUSUARIO.Name = "BTNUSUARIO";
            this.BTNUSUARIO.Size = new System.Drawing.Size(184, 170);
            this.BTNUSUARIO.TabIndex = 0;
            this.BTNUSUARIO.Text = "USUARIOS";
            this.BTNUSUARIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNUSUARIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNUSUARIO.UseVisualStyleBackColor = false;
            this.BTNUSUARIO.Click += new System.EventHandler(this.BTNUSUARIO_Click);
            // 
            // LBLBIENVENIDA
            // 
            this.LBLBIENVENIDA.AutoSize = true;
            this.LBLBIENVENIDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBIENVENIDA.Location = new System.Drawing.Point(397, 58);
            this.LBLBIENVENIDA.Name = "LBLBIENVENIDA";
            this.LBLBIENVENIDA.Size = new System.Drawing.Size(240, 39);
            this.LBLBIENVENIDA.TabIndex = 0;
            this.LBLBIENVENIDA.Text = "BIENVENIDO";
            // 
            // LBLRELOJ
            // 
            this.LBLRELOJ.AutoSize = true;
            this.LBLRELOJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRELOJ.Location = new System.Drawing.Point(346, 177);
            this.LBLRELOJ.Name = "LBLRELOJ";
            this.LBLRELOJ.Size = new System.Drawing.Size(95, 29);
            this.LBLRELOJ.TabIndex = 1;
            this.LBLRELOJ.Text = "RELOJ";
            // 
            // TIMERRELOJ
            // 
            this.TIMERRELOJ.Enabled = true;
            this.TIMERRELOJ.Interval = 1000;
            this.TIMERRELOJ.Tick += new System.EventHandler(this.TIMERRELOJ_Tick);
            // 
            // LBLTOTALACCESOS
            // 
            this.LBLTOTALACCESOS.AutoSize = true;
            this.LBLTOTALACCESOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTOTALACCESOS.Location = new System.Drawing.Point(636, 269);
            this.LBLTOTALACCESOS.Name = "LBLTOTALACCESOS";
            this.LBLTOTALACCESOS.Size = new System.Drawing.Size(136, 29);
            this.LBLTOTALACCESOS.TabIndex = 2;
            this.LBLTOTALACCESOS.Text = "ACCESOS";
            // 
            // LBLTOTALUSUARIOS
            // 
            this.LBLTOTALUSUARIOS.AutoSize = true;
            this.LBLTOTALUSUARIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTOTALUSUARIOS.Location = new System.Drawing.Point(270, 269);
            this.LBLTOTALUSUARIOS.Name = "LBLTOTALUSUARIOS";
            this.LBLTOTALUSUARIOS.Size = new System.Drawing.Size(144, 29);
            this.LBLTOTALUSUARIOS.TabIndex = 3;
            this.LBLTOTALUSUARIOS.Text = "USUARIOS";
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRINCIPAL";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Button BTNREPORTE;
        private System.Windows.Forms.Button BTNUSUARIO;
        private System.Windows.Forms.Label LBLTOTALUSUARIOS;
        private System.Windows.Forms.Label LBLTOTALACCESOS;
        private System.Windows.Forms.Label LBLRELOJ;
        private System.Windows.Forms.Label LBLBIENVENIDA;
        private System.Windows.Forms.Timer TIMERRELOJ;
    }
}