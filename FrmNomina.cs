using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Diagnostics;






namespace GESTION_EMPLEADOS
{
    public partial class FrmNomina : Form
    {

        string connectionString = "Server=REBECALAZARO\\SQLEXPRESS;Database=GestionEmpleados;Trusted_Connection=True;";
        public FrmNomina()
        {
            InitializeComponent();
        }

        private void FrmNomina_Load(object sender, EventArgs e)
        {


          

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Consulta para obtener empleados activos con nombre completo y puesto
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Nombre + ' ' + Apellido_Paterno + ' ' + Apellido_Materno + ' - ' + Puesto AS EmpleadoCompleto " +
                    "FROM Empleados WHERE Estado = 1", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar y llenar el ComboBox con los empleados activos
                cbEmpleado.Items.Clear();
                while (reader.Read())
                {
                    cbEmpleado.Items.Add(new ComboboxItem
                    {
                        Text = reader["EmpleadoCompleto"].ToString(),
                        Value = Convert.ToInt32(reader["Id"])
                    });
                }

                reader.Close();
            }

            // Cargar nóminas existentes en el DataGridView
            CargarNominas();


        }

        private void cbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpleado.SelectedItem is ComboboxItem selectedItem)
            {
                int idEmpleado = (int)selectedItem.Value;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Salario FROM Empleados WHERE Id = @IdEmpleado", conn);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        txtSueldoBase.Text = result.ToString();
                    }
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener datos ingresados
            decimal sueldoBase = Convert.ToDecimal(txtSueldoBase.Text);
            int diasTrabajados = Convert.ToInt32(txtDiasTrabajados.Value);
            int retardos = Convert.ToInt32(txtRetardos.Value);
            int faltas = Convert.ToInt32(txtFaltas.Value);
            decimal bonos = string.IsNullOrEmpty(txtBonos.Text) ? 0 : Convert.ToDecimal(txtBonos.Text);
            decimal descuentos = string.IsNullOrEmpty(txtDescuentos.Text) ? 0 : Convert.ToDecimal(txtDescuentos.Text);

            // Calcular el total
            decimal pagoPorDia = sueldoBase / 30; // Suponiendo que es mensual, dividido entre 30 días
            decimal pagoBase = pagoPorDia * diasTrabajados;
            decimal penalizacion = (retardos * 0.05m * pagoPorDia) + (faltas * pagoPorDia);
            decimal total = pagoBase - penalizacion + bonos - descuentos;

            // Mostrar el resultado en el cuadro de texto
            txtTotal.Text = total.ToString("0.00");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbEmpleado.SelectedItem is not ComboboxItem selectedItem)
            {
                MessageBox.Show("Por favor, selecciona un empleado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSueldoBase.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos necesarios.");
                return;
            }

            int idEmpleado = (int)selectedItem.Value;

            decimal sueldoBase = Convert.ToDecimal(txtSueldoBase.Text);
            int diasTrabajados = Convert.ToInt32(txtDiasTrabajados.Value);
            int retardos = Convert.ToInt32(txtRetardos.Value);
            int faltas = Convert.ToInt32(txtFaltas.Value);
            decimal bonos = string.IsNullOrEmpty(txtBonos.Text) ? 0 : Convert.ToDecimal(txtBonos.Text);
            decimal descuentos = string.IsNullOrEmpty(txtDescuentos.Text) ? 0 : Convert.ToDecimal(txtDescuentos.Text);
            decimal totalPagar = Convert.ToDecimal(txtTotal.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Nomina (IdEmpleado, SueldoBase, DiasTrabajados, Retardos, Faltas, Bonos, Descuentos, TotalPagar, Fecha) " +
                    "VALUES (@IdEmpleado, @SueldoBase, @DiasTrabajados, @Retardos, @Faltas, @Bonos, @Descuentos, @TotalPagar, @Fecha)",
                    conn
                );

                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@SueldoBase", sueldoBase);
                cmd.Parameters.AddWithValue("@DiasTrabajados", diasTrabajados);
                cmd.Parameters.AddWithValue("@Retardos", retardos);
                cmd.Parameters.AddWithValue("@Faltas", faltas);
                cmd.Parameters.AddWithValue("@Bonos", bonos);
                cmd.Parameters.AddWithValue("@Descuentos", descuentos);
                cmd.Parameters.AddWithValue("@TotalPagar", totalPagar);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Nómina guardada exitosamente.");

            // Generar recibo
            string[] datosEmpleado = selectedItem.Text.Split('-');
            string nombreCompleto = datosEmpleado[0].Trim();
            string puesto = datosEmpleado.Length > 1 ? datosEmpleado[1].Trim() : "";

            GenerarReciboNominaCompleto(nombreCompleto, puesto, sueldoBase,
                                         diasTrabajados, retardos, faltas,
                                         bonos, descuentos, totalPagar);

            CargarNominas();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtBonos.Clear();
            txtDescuentos.Clear();
            txtTotal.Clear();
            txtSueldoBase.Clear();
            // Limpiar los NumericUpDown
            txtDiasTrabajados.Value = 0;
            txtRetardos.Value = 0;
            txtFaltas.Value = 0;
        }

        private void CargarNominas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT N.Id,           -- ID de la nómina
                   E.Nombre, 
                   E.Apellido_Paterno, 
                   E.Apellido_Materno, 
                   N.SueldoBase, 
                   N.DiasTrabajados, 
                   N.Retardos, 
                   N.Faltas, 
                   N.Bonos, 
                   N.Descuentos, 
                   N.TotalPagar, 
                   N.Fecha
            FROM Nomina N
            INNER JOIN Empleados E ON N.IdEmpleado = E.Id";  // Relación con la tabla Empleados

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                System.Data.DataTable tabla = new System.Data.DataTable();
                adapter.Fill(tabla);
                dgvNomina.DataSource = tabla;
            }
        }




        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }




        private void GuardarComoPDF(string rutaDocx)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;

            Document wordDoc = wordApp.Documents.Open(rutaDocx);

            string rutaPdf = Path.ChangeExtension(rutaDocx, ".pdf");
            wordDoc.SaveAs2(rutaPdf, WdSaveFormat.wdFormatPDF);

            wordDoc.Close(false);
            wordApp.Quit(false);

            MessageBox.Show("Recibo convertido a PDF.");

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaPdf,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el PDF: " + ex.Message);
            }
        }

        private void GenerarReciboNominaCompleto(string nombreCompleto, string puesto, decimal sueldoBase,
                                          int diasTrabajados, int retardos, int faltas,
                                          decimal bonos, decimal descuentos, decimal total)
        {
            try
            {
                // Crear instancia de Word
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false;

                // Crear un nuevo documento
                Document doc = wordApp.Documents.Add();

                // Agregar título centrado
                Paragraph titulo = doc.Content.Paragraphs.Add();
                titulo.Range.Text = "RECIBO DE NÓMINA";
                titulo.Range.Font.Size = 16;
                titulo.Range.Font.Bold = 1;
                titulo.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                titulo.Range.InsertParagraphAfter();

                // Agregar los datos
                void AddLinea(string texto)
                {
                    Paragraph p = doc.Content.Paragraphs.Add();
                    p.Range.Text = texto;
                    p.Range.Font.Size = 12;
                    p.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                    p.Range.InsertParagraphAfter();
                }

                AddLinea($"Fecha: {DateTime.Now:dd/MM/yyyy}");
                AddLinea($"Empleado: {nombreCompleto}");
                AddLinea($"Puesto: {puesto}");
                AddLinea($"Sueldo base mensual: ${sueldoBase:F2}");
                AddLinea($"Días trabajados: {diasTrabajados}");
                AddLinea($"Retardos: {retardos}");
                AddLinea($"Faltas: {faltas}");
                AddLinea($"Bonos adicionales: ${bonos:F2}");
                AddLinea($"Descuentos: ${descuentos:F2}");
                AddLinea($"Total a pagar: ${total:F2}");
                AddLinea("");
                AddLinea("Firma del empleado:\n\n__________________________");

                // Guardar en el escritorio
                string nombreSeguro = new string(nombreCompleto
                    .Where(c => !Path.GetInvalidFileNameChars().Contains(c))
                    .ToArray());
                string rutaDocx = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                               $"Recibo_{nombreSeguro}_{DateTime.Now:yyyyMMdd_HHmmss}.docx");

                doc.SaveAs2(rutaDocx);
                doc.Close();
                wordApp.Quit();

                MessageBox.Show("Recibo de nómina generado en el escritorio.");

                // Convertir a PDF
                GuardarComoPDF(rutaDocx);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el recibo: " + ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cbEmpleado.SelectedItem is not ComboboxItem selectedItem)
            {
                MessageBox.Show("Por favor, selecciona un empleado.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSueldoBase.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos necesarios.");
                return;
            }

            // Obtener datos
            decimal sueldoBase = Convert.ToDecimal(txtSueldoBase.Text);
            int diasTrabajados = Convert.ToInt32(txtDiasTrabajados.Value);
            int retardos = Convert.ToInt32(txtRetardos.Value);
            int faltas = Convert.ToInt32(txtFaltas.Value);
            decimal bonos = string.IsNullOrEmpty(txtBonos.Text) ? 0 : Convert.ToDecimal(txtBonos.Text);
            decimal descuentos = string.IsNullOrEmpty(txtDescuentos.Text) ? 0 : Convert.ToDecimal(txtDescuentos.Text);
            decimal total = Convert.ToDecimal(txtTotal.Text);

            // Extraer nombre y puesto
            string[] datosEmpleado = selectedItem.Text.Split('-');
            string nombreCompleto = datosEmpleado[0].Trim();
            string puesto = datosEmpleado.Length > 1 ? datosEmpleado[1].Trim() : "";

            // Llamar al generador del recibo
            GenerarReciboNominaCompleto(nombreCompleto, puesto, sueldoBase,
                                         diasTrabajados, retardos, faltas,
                                         bonos, descuentos, total);
        }


        private void dgvNomina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    
}




