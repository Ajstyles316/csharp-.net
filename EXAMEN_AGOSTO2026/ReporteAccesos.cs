using CrystalDecisions.CrystalReports.Engine;
using PROYECTO2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_AGOSTO2026
{
    public partial class ReporteAccesos : Form
    {
        public ReporteAccesos()
        {
            InitializeComponent();
        }

        private void BTNREPGEN_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Conexiones.ejecuta_sql("EXEC REPORTE_GENERAL");

                ReportDocument reporte = new ReportDocument();
                reporte.Load(Application.StartupPath + @"\Reportes\ReporteAccesosGeneral.rpt");
                reporte.SetDataSource(dt);

                crystalReportViewer1.ReportSource = reporte;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte general:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNREPUS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTUSUARIO.Text))
            {
                MessageBox.Show("Escribe el nombre de usuario a filtrar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string usuario = TXTUSUARIO.Text.Trim().Replace("'", "''");

                DataTable dt = Conexiones.ejecuta_sql("EXEC REPORTE_USUARIO '" + usuario + "'");

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ese usuario no tiene accesos registrados.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ReportDocument reporte = new ReportDocument();
                reporte.Load(Application.StartupPath + @"\Reportes\ReporteAccesosPorUsuario.rpt");
                reporte.SetDataSource(dt);

                crystalReportViewer1.ReportSource = reporte;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte por usuario:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
