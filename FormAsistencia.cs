using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;



namespace GESTION_EMPLEADOS
{
    public partial class FormAsistencia : Form
    {

        string connectionString = "Server=REBECALAZARO\\SQLEXPRESS;Database=GestionEmpleados;Trusted_Connection=True;";
        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void FormAsistencia_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            txtMotivoRetardo.Visible = false;
            radioAsistio.CheckedChanged += ActualizarMotivoVisible;
            radioInasistencia.CheckedChanged += ActualizarMotivoVisible;
            radioRetardo.CheckedChanged += ActualizarMotivoVisible;
            CargarAsistencias();

            comboFiltroExportar.Items.AddRange(new string[] { "Todos", "Asistió", "Inasistencia", "Retardo" });
            comboFiltroExportar.SelectedIndex = 0; // Por defecto, "Todos"

        }

        private void CargarEmpleados()
        {
            comboBoxEmpleado.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, Apellido_Paterno, Apellido_Materno, Puesto FROM Empleados", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                var listaEmpleados = new List<KeyValuePair<int, string>>();

                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string nombreCompleto = $"{reader["Nombre"]} {reader["Apellido_Paterno"]} {reader["Apellido_Materno"]} - {reader["Puesto"]}";
                    listaEmpleados.Add(new KeyValuePair<int, string>(id, nombreCompleto));
                }

                comboBoxEmpleado.DataSource = listaEmpleados;
                comboBoxEmpleado.DisplayMember = "Value";
                comboBoxEmpleado.ValueMember = "Key";
            }
        }


        private void ActualizarMotivoVisible(object sender, EventArgs e)
        {
            txtMotivoRetardo.Visible = radioRetardo.Checked || radioInasistencia.Checked;

        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {


            if (comboBoxEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            string estado = radioAsistio.Checked ? "Asistió" :
                            radioInasistencia.Checked ? "Inasistencia" :
                            "Retardo";

            string motivo = "";
            if (radioRetardo.Checked || radioInasistencia.Checked)
            {
                motivo = txtMotivoRetardo.Text.Trim();
                if (string.IsNullOrWhiteSpace(motivo))
                {
                    string tipo = radioRetardo.Checked ? "retardo" : "inasistencia";
                    MessageBox.Show($"Ingrese el motivo del {tipo}.");
                    return;
                }
            }

            int empleadoId = ((KeyValuePair<int, string>)comboBoxEmpleado.SelectedItem).Key;
            DateTime fecha = datePicker.Value.Date;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand verificarCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Asistencias WHERE EmpleadoId = @EmpleadoId AND Fecha = @Fecha", conn);
                verificarCmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                verificarCmd.Parameters.AddWithValue("@Fecha", fecha);

                int existe = (int)verificarCmd.ExecuteScalar();
                if (existe > 0)
                {
                    MessageBox.Show("Ya existe un registro de asistencia para este empleado en la fecha seleccionada.");
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Asistencias (EmpleadoId, Fecha, Estado, Motivo) VALUES (@EmpleadoId, @Fecha, @Estado, @Motivo)", conn);
                cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@Motivo", motivo);
                cmd.ExecuteNonQuery();
            }

            CargarAsistencias();
            MessageBox.Show("Asistencia registrada correctamente.");

            BorrarCampos();

        }

        //agregue aqui
        private void BorrarCampos()
        {
            txtMotivoRetardo.Clear();

            foreach (Control control in groupBoxEstado.Controls)
            {
                if(control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void CargarAsistencias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        A.Fecha, 
                        CONCAT(E.Nombre, ' ', E.Apellido_Paterno, ' ', E.Apellido_Materno) AS Empleado,
                        E.Puesto,
                        A.Estado, 
                        A.Motivo
                    FROM Asistencias A
                    JOIN Empleados E ON A.EmpleadoId = E.Id", conn);

                System.Data.DataTable dt = new System.Data.DataTable();

                da.Fill(dt);
                dataGridViewAsistencia.DataSource = dt;

                foreach (DataGridViewRow row in dataGridViewAsistencia.Rows)
                {
                    if (row.Cells["Estado"].Value == null) continue;
                    string estado = row.Cells["Estado"].Value.ToString();
                    if (estado == "Asistió") row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (estado == "Inasistencia") row.DefaultCellStyle.BackColor = Color.LightCoral;
                    else if (estado == "Retardo") row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsistencia.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                // Verificar que se haya seleccionado un filtro
                if (comboFiltroExportar.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un filtro.");
                    return;
                }

                string filtro = comboFiltroExportar.SelectedItem.ToString();

                // Verificar si el DataSource es un DataTable
                if (dataGridViewAsistencia.DataSource is System.Data.DataTable tablaOriginal)
                {
                    DataView vistaFiltrada = new DataView(tablaOriginal);

                    // Aplicar filtro si no es "Todos"
                    if (filtro != "Todos")
                    {
                        vistaFiltrada.RowFilter = $"Estado = '{filtro}'";
                    }

                    System.Data.DataTable tablaFiltrada = vistaFiltrada.ToTable();

                    // Verificar si la tabla filtrada tiene datos
                    if (tablaFiltrada.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay registros con ese filtro.");
                        return;
                    }

                    // Crear aplicación de Excel
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                    worksheet.Name = "Asistencias Filtradas";

                    // Encabezados
                    for (int i = 0; i < tablaFiltrada.Columns.Count; i++)
                    {
                        Excel.Range cell = worksheet.Cells[1, i + 1];
                        cell.Value = tablaFiltrada.Columns[i].ColumnName;
                        cell.Interior.Color = ColorTranslator.ToOle(Color.Black);
                        cell.Font.Color = ColorTranslator.ToOle(Color.White);
                        cell.Font.Bold = true;
                    }

                    // Datos
                    for (int i = 0; i < tablaFiltrada.Rows.Count; i++)
                    {
                        for (int j = 0; j < tablaFiltrada.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = tablaFiltrada.Rows[i][j]?.ToString();
                        }
                    }

                    // Ajustar el tamaño de las columnas
                    worksheet.Columns.AutoFit();

                    // Hacer visible la aplicación de Excel
                    excelApp.Visible = true;
                }
                else
                {
                    MessageBox.Show("El origen de datos no es un DataTable.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

        private void txtMotivoRetardo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
