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
    public partial class PRINCIPAL : Form
    {
        private readonly string usuarioActivo = "";
        public PRINCIPAL(string usuario)
        {
            InitializeComponent();
            usuarioActivo = usuario;

        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            this.Text = "MENU PRINCIPAL - Sesión: " + usuarioActivo;
            LBLBIENVENIDA.Text = "Bienvenido, " + usuarioActivo;

            ActualizarReloj();
            CargarDashboard();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                Form login = new LOGIN();
                login.Show();
                Close();
            }
        }

        private void BTNUSUARIO_Click(object sender, EventArgs e)
        {
            USUARIOS frmUsuarios = new USUARIOS();
            frmUsuarios.ShowDialog();
        }

        private void BTNREPORTE_Click(object sender, EventArgs e)
        {
            ReporteAccesos frmReporte = new ReporteAccesos();
            frmReporte.ShowDialog();
        }

        private void TIMERRELOJ_Tick(object sender, EventArgs e)
        {
            ActualizarReloj();
        }
        private void CargarDashboard()
        {
            try
            {
                // Total de usuarios registrados
                var dtUsuarios = Conexiones.ejecuta_sql("SELECT COUNT(*) AS Total FROM USUARIOS");
                string totalUsuarios = dtUsuarios.Rows.Count > 0 ? dtUsuarios.Rows[0]["Total"].ToString() : "0";
                LBLTOTALUSUARIOS.Text = "Usuarios registrados: " + totalUsuarios;

                // Total de accesos registrados hoy (comparando la parte de fecha guardada como texto dd/MM/yyyy)
                string hoy = DateTime.Now.ToString("dd/MM/yyyy");
                var dtAccesosHoy = Conexiones.ejecuta_sql(
                    "SELECT COUNT(*) AS Total FROM ACCESOS WHERE FECHA = '" + hoy + "'");
                string totalAccesosHoy = dtAccesosHoy.Rows.Count > 0 ? dtAccesosHoy.Rows[0]["Total"].ToString() : "0";
                LBLTOTALACCESOS.Text = "Accesos hoy: " + totalAccesosHoy;

                // Último acceso registrado (el más reciente de toda la tabla)
                var dtUltimo = Conexiones.ejecuta_sql(
                    "SELECT TOP 1 USUARIO, FECHA, HORA FROM ACCESOS ORDER BY ID DESC");

                if (dtUltimo.Rows.Count > 0)
                {
                    string usuarioUltimo = dtUltimo.Rows[0]["USUARIO"].ToString();
                    string fechaUltimo = dtUltimo.Rows[0]["FECHA"].ToString();
                    string horaUltimo = dtUltimo.Rows[0]["HORA"].ToString();
                                      
                }
            }
            catch (Exception ex)
            {
                LBLTOTALUSUARIOS.Text = "Usuarios registrados: --";
                LBLTOTALACCESOS.Text = "Accesos hoy: --";
            }
        }
        private void ActualizarReloj()
        {
            LBLRELOJ.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy - HH:mm:ss",
                new System.Globalization.CultureInfo("es-ES"));
        }
    }
}
