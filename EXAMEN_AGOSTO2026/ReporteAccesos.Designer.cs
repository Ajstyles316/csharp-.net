namespace EXAMEN_AGOSTO2026
{
    partial class ReporteAccesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAccesos));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNREPUS = new System.Windows.Forms.Button();
            this.BTNREPGEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(797, 522);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelWidth = 150;
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Location = new System.Drawing.Point(8, 99);
            this.TXTUSUARIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(132, 20);
            this.TXTUSUARIO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Escriba el nombre del usuario";
            // 
            // BTNREPUS
            // 
            this.BTNREPUS.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNREPUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREPUS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNREPUS.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Printer_Folder2;
            this.BTNREPUS.Location = new System.Drawing.Point(10, 316);
            this.BTNREPUS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNREPUS.Name = "BTNREPUS";
            this.BTNREPUS.Size = new System.Drawing.Size(130, 70);
            this.BTNREPUS.TabIndex = 16;
            this.BTNREPUS.Text = "REPORTE USUARIO";
            this.BTNREPUS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNREPUS.UseVisualStyleBackColor = false;
            this.BTNREPUS.Click += new System.EventHandler(this.BTNREPUS_Click);
            // 
            // BTNREPGEN
            // 
            this.BTNREPGEN.BackColor = System.Drawing.Color.AliceBlue;
            this.BTNREPGEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREPGEN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNREPGEN.Image = global::EXAMEN_AGOSTO2026.Properties.Resources.Printer_Folder_22;
            this.BTNREPGEN.Location = new System.Drawing.Point(10, 220);
            this.BTNREPGEN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNREPGEN.Name = "BTNREPGEN";
            this.BTNREPGEN.Size = new System.Drawing.Size(130, 70);
            this.BTNREPGEN.TabIndex = 15;
            this.BTNREPGEN.Text = "REPORTE GENERAL";
            this.BTNREPGEN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNREPGEN.UseVisualStyleBackColor = false;
            this.BTNREPGEN.Click += new System.EventHandler(this.BTNREPGEN_Click);
            // 
            // ReporteAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNREPUS);
            this.Controls.Add(this.BTNREPGEN);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReporteAccesos";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.Button BTNREPGEN;
        private System.Windows.Forms.Button BTNREPUS;
        private System.Windows.Forms.Label label1;
    }
}