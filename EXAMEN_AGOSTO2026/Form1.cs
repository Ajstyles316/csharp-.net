using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PROYECTO2;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_AGOSTO2026
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            TXTCONTRA.Clear();
            TXTUSUARIO.Clear();
            TXTUSUARIO.Focus();
        }

        private void BTNINGRESAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTUSUARIO.Text))
            {
                MessageBox.Show("Ingresa tu correo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXTCONTRA.Text))
            {
                MessageBox.Show("Ingresa la contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string correo = TXTUSUARIO.Text.Trim();
            string contra = TXTCONTRA.Text.Trim();
            string sqlValidar =
                "SELECT dbo.OBTENER_USUARIO('" + correo.Replace("'", "''") + "', '" +
                contra.Replace("'", "''") + "') AS Nombre";

            string nombreUsuario = Conexiones.obtiene_campo(sqlValidar, "Nombre");

            if (!string.IsNullOrWhiteSpace(nombreUsuario))
            {
                // Registra el acceso llamando al PROCEDIMIENTO sp_RegistrarAcceso
                Conexiones.registrar2("EXEC REGISTRAR_ACCESO '" + nombreUsuario.Replace("'", "''") + "'");

                PRINCIPAL frmPrincipal = new PRINCIPAL(nombreUsuario);
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCONTRA.Clear();
                TXTCONTRA.Focus();
            }
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
