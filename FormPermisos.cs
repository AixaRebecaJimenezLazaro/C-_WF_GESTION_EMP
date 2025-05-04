using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace GESTION_EMPLEADOS
{
    public partial class FormPermisos : Form
    {

        string connectionString = "Server=REBECALAZARO\\SQLEXPRESS;Database=GestionEmpleados;Trusted_Connection=True;";
        public FormPermisos()
        {
            InitializeComponent();
        }

        private void FormPermisos_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarPermisos();

            comboBoxEstado.Items.Clear();
            comboBoxEstado.Items.Add("Pendiente");
            comboBoxEstado.Items.Add("Aprobado");
            comboBoxEstado.Items.Add("Rechazado");
            comboBoxEstado.SelectedIndex = 0;

        }


        private void CargarEmpleados()
        {
            comboBoxEmpleado.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Apellido_Paterno, Apellido_Materno, Puesto FROM Empleados WHERE Estado = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nombreCompleto = $"{reader["Nombre"]} {reader["Apellido_Paterno"]} {reader["Apellido_Materno"]}";
                    string puesto = reader["Puesto"].ToString();
                    string displayText = $"{nombreCompleto} - {puesto}";

                    comboBoxEmpleado.Items.Add(new ComboItem
                    {
                        Text = displayText,
                        Value = Convert.ToInt32(reader["Id"])
                    });
                }
            }
        }

        private void btnRegistrarPermiso_Click(object sender, EventArgs e)
        {
            if (comboBoxEmpleado.SelectedIndex == -1 || string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            int empleadoId = ((ComboItem)comboBoxEmpleado.SelectedItem).Value;
            DateTime fechaSolicitud = DateTime.Now;
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            string motivo = txtMotivo.Text;
            string estado = "Pendiente";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Permisos (EmpleadoId, FechaSolicitud, FechaInicio, FechaFin, Motivo, Estado) " +
                                   "VALUES (@EmpleadoId, @FechaSolicitud, @FechaInicio, @FechaFin, @Motivo, @Estado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                    cmd.Parameters.AddWithValue("@FechaSolicitud", fechaSolicitud);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@Motivo", motivo);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Permiso registrado correctamente.");
                    CargarPermisos(); // Actualizar el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar permiso: " + ex.Message);
                }
            }

        }

        private void CargarPermisos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT p.Id, 
                        p.EmpleadoId,  -- 👈 Agregado aquí
                        e.Nombre + ' ' + e.Apellido_Paterno + ' ' + e.Apellido_Materno AS Empleado, 
                        e.Puesto, 
                        p.FechaSolicitud, 
                        p.FechaInicio, 
                        p.FechaFin, 
                        p.Motivo, 
                        p.Estado
                 FROM Permisos p
                 INNER JOIN Empleados e ON p.EmpleadoId = e.Id
                 ORDER BY p.FechaSolicitud DESC";


                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable permisosTable = new System.Data.DataTable();  // Usamos DataTable de System.Data
                adapter.Fill(permisosTable);

                // Asociamos el DataTable al DataGridView
                dataGridViewPermisos.DataSource = permisosTable;
            }
        }

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            if (comboBoxEmpleado.SelectedIndex == -1 || string.IsNullOrEmpty(txtMotivo.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            string empleadoNombre = ((ComboItem)comboBoxEmpleado.SelectedItem).Text;
            string motivo = txtMotivo.Text;
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;

            try
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = wordApp.Documents.Add();
                wordApp.Visible = true;

                Paragraph para = wordDoc.Content.Paragraphs.Add();
                para.Range.Text = "Permiso de Empleado";
                para.Range.Font.Size = 16;
                para.Range.Font.Bold = 1;
                para.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                para.Range.InsertParagraphAfter();

                para = wordDoc.Content.Paragraphs.Add();
                para.Range.Text = $"Empleado: {empleadoNombre}";
                para.Range.InsertParagraphAfter();

                para = wordDoc.Content.Paragraphs.Add();
                para.Range.Text = $"Motivo: {motivo}";
                para.Range.InsertParagraphAfter();

                para = wordDoc.Content.Paragraphs.Add();
                para.Range.Text = $"Fecha de Solicitud: {DateTime.Now:dd/MM/yyyy}";
                para.Range.InsertParagraphAfter();

                para = wordDoc.Content.Paragraphs.Add();
                para.Range.Text = $"Desde: {fechaInicio:dd/MM/yyyy} Hasta: {fechaFin:dd/MM/yyyy}";
                para.Range.InsertParagraphAfter();

                para = wordDoc.Content.Paragraphs.Add();
                para.Range.Text = $"Estado: Pendiente";
                para.Range.InsertParagraphAfter();

                MessageBox.Show("Documento generado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar documento: " + ex.Message);
            }
        }

        // Clase auxiliar para el ComboBox
        public class ComboItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private int permisoSeleccionadoId = -1;


        private void dataGridViewPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPermisos.Rows[e.RowIndex];
                permisoSeleccionadoId = Convert.ToInt32(row.Cells["Id"].Value);

                int empleadoId = Convert.ToInt32(row.Cells["EmpleadoId"].Value);
                // Buscar el item correspondiente en comboBoxEmpleado
                for (int i = 0; i < comboBoxEmpleado.Items.Count; i++)
                {
                    if (((ComboItem)comboBoxEmpleado.Items[i]).Value == empleadoId)
                    {
                        comboBoxEmpleado.SelectedIndex = i;
                        break;
                    }
                }

                txtMotivo.Text = row.Cells["Motivo"].Value.ToString();
                dateTimePickerInicio.Value = Convert.ToDateTime(row.Cells["FechaInicio"].Value);
                dateTimePickerFin.Value = Convert.ToDateTime(row.Cells["FechaFin"].Value);
                comboBoxEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (permisoSeleccionadoId == -1)
            {
                MessageBox.Show("Seleccione un permiso desde la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxEmpleado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Complete todos los campos antes de modificar.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empleadoId = ((ComboItem)comboBoxEmpleado.SelectedItem).Value;
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;
            string motivo = txtMotivo.Text.Trim();
            string estado = comboBoxEstado.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Permisos 
                             SET EmpleadoId = @EmpleadoId, 
                                 FechaInicio = @FechaInicio, 
                                 FechaFin = @FechaFin, 
                                 Motivo = @Motivo, 
                                 Estado = @Estado
                             WHERE Id = @Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@Motivo", motivo);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@Id", permisoSeleccionadoId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Permiso modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPermisos(); // Refresca la tabla
                    LimpiarCampos();  // Limpia los campos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar permiso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            comboBoxEmpleado.SelectedIndex = -1;
            txtMotivo.Clear();
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerFin.Value = DateTime.Now;
            comboBoxEstado.SelectedIndex = 0;
            permisoSeleccionadoId = -1;
        }

        private void dataGridViewPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermisos_CellClick);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }

}
