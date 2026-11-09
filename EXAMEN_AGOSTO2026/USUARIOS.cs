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
    public partial class USUARIOS : Form
    {
        public USUARIOS()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            Conexiones.Cargar_SQL("EXEC LISTAR_USUARIOS", dgvUsuarios);
            
            if (dgvUsuarios.Columns.Contains("NOMBRES"))
                dgvUsuarios.Columns["NOMBRES"].HeaderText = "Nombres";
            if (dgvUsuarios.Columns.Contains("CONTRASENA"))
                dgvUsuarios.Columns["CONTRASENA"].HeaderText = "Contraseña";
            if (dgvUsuarios.Columns.Contains("TELEFONO"))
                dgvUsuarios.Columns["TELEFONO"].HeaderText = "Teléfono";
            if (dgvUsuarios.Columns.Contains("CORREO"))
                dgvUsuarios.Columns["CORREO"].HeaderText = "Correo";
        }
        private void USUARIOS_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // evita error si clickean el encabezado
            
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            TXTID.Text = fila.Cells["ID"].Value.ToString();
            TXTNOMBRES.Text = fila.Cells["NOMBRES"].Value.ToString();
            TXTCONTRA.Text = fila.Cells["CONTRASENA"].Value?.ToString() ?? "";
            TXTTELEFONO.Text = fila.Cells["TELEFONO"].Value?.ToString() ?? "";
            TXTCORREO.Text = fila.Cells["CORREO"].Value?.ToString() ?? "";
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TXTNOMBRES.Text) || string.IsNullOrWhiteSpace(TXTCONTRA.Text))
            {
                MessageBox.Show("Nombres y Contraseña son obligatorios.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(TXTTELEFONO.Text) && !int.TryParse(TXTTELEFONO.Text, out _))
            {
                MessageBox.Show("El teléfono debe ser numérico.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            TXTID.Clear();
            TXTNOMBRES.Clear();
            TXTCONTRA.Clear();
            TXTTELEFONO.Clear();
            TXTCORREO.Clear();
        }
        private void BTNAGREGAR_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string telefono = string.IsNullOrWhiteSpace(TXTTELEFONO.Text) ? "NULL" : TXTTELEFONO.Text.Trim();
            string correo = string.IsNullOrWhiteSpace(TXTCORREO.Text) ? "NULL" : "'" + TXTCORREO.Text.Trim().Replace("'", "''") + "'";

            string sql = "EXEC AGREGAR_USUARIO '" +
                TXTNOMBRES.Text.Trim().Replace("'", "''") + "', '" +
                TXTCONTRA.Text.Trim().Replace("'", "''") + "', " +
                telefono + ", " + correo + ")";

            Conexiones.registrar(sql); 

            LimpiarCampos();
            CargarGrid();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTID.Text))
            {
                MessageBox.Show("Selecciona un usuario de la lista primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            string telefono = string.IsNullOrWhiteSpace(TXTTELEFONO.Text) ? "NULL" : TXTTELEFONO.Text.Trim();
            string correo = string.IsNullOrWhiteSpace(TXTCORREO.Text) ? "NULL" : "'" + TXTCORREO.Text.Trim().Replace("'", "''") + "'";

            string sql = "EXEC MODIFICAR_USUARIO " + TXTID.Text + ", '" +
                TXTNOMBRES.Text.Trim().Replace("'", "''") + "', '" +
                TXTCONTRA.Text.Trim().Replace("'", "''") + "', " +
                telefono + ", " + correo;

            Conexiones.registrar(sql);

            LimpiarCampos();
            CargarGrid();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTID.Text))
            {
                MessageBox.Show("Selecciona un usuario de la lista primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar al usuario '" + TXTNOMBRES.Text + "'?\n"                ,
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            string sql = "EXEC ELIMINAR_USUARIO " + TXTID.Text;

            Conexiones.registrar(sql);

            LimpiarCampos();
            CargarGrid();
        }

        private void BTNLIMPIAR_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BTNCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
