namespace EXAMEN_AGOSTO2026
{
    partial class USUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USUARIOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNLIMPIAR = new System.Windows.Forms.Button();
            this.BTNAGREGAR = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCONTRA = new System.Windows.Forms.TextBox();
            this.TXTNOMBRES = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.BTNCERRAR);
            this.groupBox1.Controls.Add(this.BTNMODIFICAR);
            this.groupBox1.Controls.Add(this.BTNELIMINAR);
            this.groupBox1.Controls.Add(this.BTNLIMPIAR);
            this.groupBox1.Controls.Add(this.BTNAGREGAR);
            this.groupBox1.Controls.Add(this.TXTID);
            this.groupBox1.Controls.Add(this.TXTTELEFONO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXTCORREO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTCONTRA);
            this.groupBox1.Controls.Add(this.TXTNOMBRES);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 515);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USUARIOS";
            // 
            // BTNCERRAR
            // 
            this.BTNCERRAR.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCERRAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNCERRAR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Error1;
            this.BTNCERRAR.Location = new System.Drawing.Point(660, 70);
            this.BTNCERRAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(74, 68);
            this.BTNCERRAR.TabIndex = 18;
            this.BTNCERRAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNCERRAR.UseVisualStyleBackColor = false;
            this.BTNCERRAR.Click += new System.EventHandler(this.BTNCERRAR_Click);
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMODIFICAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNMODIFICAR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.editar;
            this.BTNMODIFICAR.Location = new System.Drawing.Point(195, 146);
            this.BTNMODIFICAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(175, 70);
            this.BTNMODIFICAR.TabIndex = 17;
            this.BTNMODIFICAR.Text = "MODIFICAR USUARIO";
            this.BTNMODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNMODIFICAR.UseVisualStyleBackColor = false;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNELIMINAR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.eliminara;
            this.BTNELIMINAR.Location = new System.Drawing.Point(382, 146);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(166, 70);
            this.BTNELIMINAR.TabIndex = 16;
            this.BTNELIMINAR.Text = "ELIMINAR USUARIO";
            this.BTNELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNLIMPIAR
            // 
            this.BTNLIMPIAR.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLIMPIAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNLIMPIAR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.My_Documents21;
            this.BTNLIMPIAR.Location = new System.Drawing.Point(568, 146);
            this.BTNLIMPIAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNLIMPIAR.Name = "BTNLIMPIAR";
            this.BTNLIMPIAR.Size = new System.Drawing.Size(166, 70);
            this.BTNLIMPIAR.TabIndex = 15;
            this.BTNLIMPIAR.Text = "LIMPIAR";
            this.BTNLIMPIAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNLIMPIAR.UseVisualStyleBackColor = false;
            this.BTNLIMPIAR.Click += new System.EventHandler(this.BTNLIMPIAR_Click);
            // 
            // BTNAGREGAR
            // 
            this.BTNAGREGAR.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNAGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAGREGAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNAGREGAR.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.nueva_cuenta;
            this.BTNAGREGAR.Location = new System.Drawing.Point(14, 146);
            this.BTNAGREGAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNAGREGAR.Name = "BTNAGREGAR";
            this.BTNAGREGAR.Size = new System.Drawing.Size(166, 70);
            this.BTNAGREGAR.TabIndex = 14;
            this.BTNAGREGAR.Text = "AGREGAR USUARIO";
            this.BTNAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNAGREGAR.UseVisualStyleBackColor = false;
            this.BTNAGREGAR.Click += new System.EventHandler(this.BTNAGREGAR_Click);
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(393, 109);
            this.TXTID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(93, 26);
            this.TXTID.TabIndex = 9;
            this.TXTID.Visible = false;
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(490, 75);
            this.TXTTELEFONO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.Size = new System.Drawing.Size(160, 26);
            this.TXTTELEFONO.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELÉFONO";
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(148, 112);
            this.TXTCORREO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.Size = new System.Drawing.Size(222, 26);
            this.TXTCORREO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CORREO";
            // 
            // TXTCONTRA
            // 
            this.TXTCONTRA.Location = new System.Drawing.Point(148, 75);
            this.TXTCONTRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTCONTRA.Name = "TXTCONTRA";
            this.TXTCONTRA.PasswordChar = '*';
            this.TXTCONTRA.Size = new System.Drawing.Size(222, 26);
            this.TXTCONTRA.TabIndex = 4;
            // 
            // TXTNOMBRES
            // 
            this.TXTNOMBRES.Location = new System.Drawing.Point(148, 38);
            this.TXTNOMBRES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTNOMBRES.Name = "TXTNOMBRES";
            this.TXTNOMBRES.Size = new System.Drawing.Size(588, 26);
            this.TXTNOMBRES.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRES";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(8, 223);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(741, 284);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "USUARIOS";
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.USUARIOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox TXTCORREO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCONTRA;
        private System.Windows.Forms.TextBox TXTNOMBRES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTTELEFONO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNAGREGAR;
        private System.Windows.Forms.Button BTNMODIFICAR;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNLIMPIAR;
        private System.Windows.Forms.Button BTNCERRAR;
    }
}