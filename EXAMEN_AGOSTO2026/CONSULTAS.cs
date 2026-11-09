using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PROYECTO2
{

    static class Conexiones
    {
        // :::Declaramos los objetos globales de conexion

        // :::Procedimiento para conexion
        // OJO: se agregó "\SQLEXPRESS" porque tu servicio es una instancia nombrada
        // (lo confirmaste en services.msc: "SQL Server (SQLEXPRESS)")
        private static SqlConnection Con2 = new SqlConnection("Data Source = " + System.Windows.Forms.SystemInformation.ComputerName + "\\SQLEXPRESS; Initial Catalog = EXAMEN_AGOSTO2026; Integrated Security = True");

        // ==========================================================================================================
        public static void IMPRIMIR()
        {
            Interaction.MsgBox("Data Source = " + System.Windows.Forms.SystemInformation.ComputerName + "\\SQLEXPRESS; Initial Catalog = EXAMEN_AGOSTO2026; Integrated Security = True");
        }

        // :::Procedimiento para Cargar los registro
        public static void Cargar_SQL(string Sql, DataGridView Tabla)
        {
            var Da = new SqlDataAdapter(Sql, Con2);
            var Dt = new DataTable();
            try
            {
                Da.Fill(Dt);
                Tabla.DataSource = Dt;
                Tabla.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                Tabla.RowsDefaultCellStyle.ForeColor = Color.Black;
                Tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                Tabla.ClearSelection();
                Tabla.CurrentCell = Tabla.Rows[Tabla.RowCount - 1].Cells[0];
                Tabla.Refresh();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("No se puede realizar la consulta por: " + ex.Message);
            }
        }

        public static DataTable ejecuta_sql(string sql)
        {
            var cmd = new SqlCommand();
            var da = new SqlDataAdapter();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                Con2.Open();
                cmd.Connection = Con2;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                if (Con2.State == ConnectionState.Open) Con2.Close();
            }
            return dt;
        }

        public static void Filtro_DG(string Sql, DataGridView Tabla)
        {
            var Da = new SqlDataAdapter(Sql, Con2);
            var Dt = new DataTable();
            Da.Fill(Dt);
            Tabla.DataSource = Dt;
            Tabla.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            Tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            if (Tabla.Columns.Contains("Hora"))
                Tabla.Columns["Hora"].DefaultCellStyle.Format = "hh:mm:ss tt";
        }

        public static void Operaciones_SQL(string sql, PictureBox imagen)
        {
            var MS = new MemoryStream();
            byte[] Imag = Imagen_Bytes(imagen.Image);
            var cmd = new SqlCommand(sql, Con2);
            cmd.Parameters.AddWithValue("@imagen", (object)Imag ?? DBNull.Value);
            try
            {
                Con2.Open();
                cmd.ExecuteNonQuery();
                Con2.Close();
                Interaction.MsgBox("Operación realizada con exito", MsgBoxStyle.Information, "::::");
            }
            catch (Exception ex)
            {
                if (Con2.State == ConnectionState.Open) Con2.Close();
                Interaction.MsgBox("No se pueden guardar los registro por: " + ex.Message, MsgBoxStyle.Critical, "::::");
            }
        }

        public static void Operaciones_SQL2(string sql, string CAMPO, PictureBox imagen)
        {
            try
            {
                SqlDataReader lector;
                Con2.Open();
                if (Con2.State == ConnectionState.Open)
                {
                    byte[] Imag;
                    var Comando = new SqlCommand(sql, Con2);
                    lector = Comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Imag = (byte[])lector[CAMPO];
                        imagen.Image = Bytes_Imagen(Imag);
                    }
                    lector.Close();
                }
                Con2.Close();
            }
            catch (Exception ex)
            {
                if (Con2.State == ConnectionState.Open) Con2.Close();
                Interaction.MsgBox("Error al obtener la imagen: " + ex.Message);
            }
        }

        public static Image Bytes_Imagen(byte[] Imagen)
        {
            try
            {
                if (Imagen is not null)
                {
                    var Bin = new MemoryStream(Imagen);
                    var Resultado = Image.FromStream(Bin);
                    return Resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] Imagen_Bytes(Image Imagen)
        {
            if (Imagen is not null)
            {
                var Bin = new MemoryStream();
                Imagen.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg);
                return Bin.GetBuffer();
            }
            else
            {
                return null;
            }
        }

        public static bool existencia(string consulta, string tabla)
        {
            SqlDataAdapter da;
            var ds = new DataSet();
            bool sw = false;
            try
            {
                da = new SqlDataAdapter(consulta, Con2);
                ds.Clear();
                da.Fill(ds, tabla);
                sw = ds.Tables[tabla].Rows.Count != 0;
            }
            catch (Exception)
            {
                sw = false;
            }
            return sw;
        }

        public static void cargarcmb(string sql, string campo, ComboBox cmb)
        {
            try
            {
                var command = new SqlCommand(sql, Con2);
                var daTabla = new SqlDataAdapter();
                var tTabla = new DataTable();
                daTabla.SelectCommand = command;
                daTabla.Fill(tTabla);
                cmb.DataSource = tTabla;
                cmb.DisplayMember = campo;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al cargar los datos: " + ex.Message);
            }
        }

        public static string obtiene_campo(string sql, string campo)
        {
            string res = "";
            try
            {
                var command = new SqlCommand(sql, Con2);
                var daTabla = new SqlDataAdapter();
                var tTabla = new DataTable();
                daTabla.SelectCommand = command;
                daTabla.Fill(tTabla);
                var row = tTabla.Rows[0];
                res = Conversions.ToString(row[campo]);
            }
            catch (Exception)
            {
            }
            return res;
        }

        public static void registrar(string sql)
        {
            var cmd = new SqlCommand(sql, Con2);
            try
            {
                Con2.Open();
                cmd.ExecuteNonQuery();
                Con2.Close();
                Interaction.MsgBox("Operación realizada con exito", MsgBoxStyle.Information, "");
            }
            catch (Exception ex)
            {
                if (Con2.State == ConnectionState.Open) Con2.Close();
                Interaction.MsgBox("No se pueden guardar los registro por: " + ex.Message, MsgBoxStyle.Critical, "");
            }
        }

        public static void registrar2(string sql)
        {
            var cmd = new SqlCommand(sql, Con2);
            try
            {
                Con2.Open();
                cmd.ExecuteNonQuery();
                Con2.Close();
            }
            catch (Exception ex)
            {
                if (Con2.State == ConnectionState.Open) Con2.Close();
                Interaction.MsgBox("No se pueden guardar los registro por: " + ex.Message, MsgBoxStyle.Critical, "");
            }
        }

        public static void DESCONECTAR()
        {
            if (Con2.State == ConnectionState.Open) Con2.Close();
        }
    }
}