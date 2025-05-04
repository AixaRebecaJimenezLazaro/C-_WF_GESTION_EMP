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

namespace GESTION_EMPLEADOS
{
    public partial class frmRegistro : Form
    {

        string connectionString = "Server=REBECALAZARO\\SQLEXPRESS;Database=GestionEmpleados;Trusted_Connection=True;";

        public frmRegistro()
        {
            InitializeComponent();
            this.Load += frmRegistro_Load;
            //dataGridViewEmpleados.CellClick += dataGridViewEmpleados_CellClick;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
           
            CargarPuestosDesdeBD();

            comboBoxEstado.Items.Clear();
            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");

            comboBoxGenero.Items.Clear();
            comboBoxGenero.Items.Add("Masculino");
            comboBoxGenero.Items.Add("Femenino");
            comboBoxGenero.Items.Add("Otro");

            ListarEmpleados();
            dataGridViewEmpleados.CellClick += dataGridViewEmpleados_CellClick;

            dataGridViewEmpleados.ClearSelection(); // ← AQUÍ para evitar que se seleccione la primera fila automáticamente

            dataGridViewEmpleados.SelectionChanged += dataGridView1_SelectionChanged;

            LimpiarCampos(); // ← Al final, para que borre los campos sin que el DataGrid los sobrescriba

        }

        private void CargarPuestosDesdeBD()
        {
            comboBoxPuesto.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Nombre FROM Puestos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxPuesto.Items.Add(reader["Nombre"].ToString());
                }
                if (comboBoxPuesto.Items.Count > 0)
                    comboBoxPuesto.SelectedIndex = 0;
            }
        }




        private void ListarEmpleados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Nombre, Apellido_Paterno, Apellido_Materno, Puesto, Genero, Estado, Salario FROM Empleados", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewEmpleados.DataSource = dt;
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Validaciones de los campos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtAPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtAMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                comboBoxPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            // Convertir el estado
            bool estadoActivo = comboBoxEstado.SelectedItem.ToString() == "Activo"; // Usar ComboBox para seleccionar el estado

            // Obtener el valor seleccionado en el ComboBox de Genero
            string genero = comboBoxGenero.SelectedItem.ToString();

            // Agregar el empleado a la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Puesto, Salario, Genero, Estado) " +
                                   "VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Puesto, @Salario, @Genero, @Estado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", txtAPaterno.Text);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", txtAMaterno.Text);
                    cmd.Parameters.AddWithValue("@Puesto", comboBoxPuesto.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Salario", salario);
                    cmd.Parameters.AddWithValue("@Genero", genero);  // Agregar el valor de Genero
                    cmd.Parameters.AddWithValue("@Estado", estadoActivo); // Usar 1 para activo y 0 para inactivo
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado exitosamente.");
                    LimpiarCampos();
                    ListarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
            }
        }
    

         

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }


       
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtSalario.Clear();

            if (comboBoxPuesto.Items.Count > 0)
                comboBoxPuesto.SelectedIndex = 0;

            comboBoxGenero.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;

            dataGridViewEmpleados.ClearSelection();

        }



        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewEmpleados.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = fila.Cells["Apellido_Paterno"].Value.ToString();
                txtAMaterno.Text = fila.Cells["Apellido_Materno"].Value.ToString();
                comboBoxPuesto.SelectedItem = fila.Cells["Puesto"].Value.ToString();
                txtSalario.Text = fila.Cells["Salario"].Value.ToString();
                comboBoxGenero.SelectedItem = fila.Cells["Genero"].Value.ToString();
                comboBoxEstado.SelectedItem = (Convert.ToBoolean(fila.Cells["Estado"].Value)) ? "Activo" : "Inactivo";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarEmpleados();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleados(txtBuscar.Text);
        }

        private void BuscarEmpleados(string texto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT Id, Nombre, Apellido_Paterno, Apellido_Materno, Puesto, Salario 
                             FROM Empleados 
                             WHERE Nombre LIKE @Texto 
                                OR Apellido_Paterno LIKE @Texto 
                                OR Apellido_Materno LIKE @Texto 
                                OR Puesto LIKE @Texto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Texto", "%" + texto + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewEmpleados.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un empleado para modificar.");
                return;
            }

            DataGridViewRow fila = dataGridViewEmpleados.SelectedRows[0];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);

            string nombre = txtNombre.Text.Trim();
            string apellidoPaterno = txtAPaterno.Text.Trim();
            string apellidoMaterno = txtAMaterno.Text.Trim();
            string puesto = comboBoxPuesto.SelectedItem?.ToString();
            string genero = comboBoxGenero.SelectedItem?.ToString();
            decimal salario;
            bool salarioValido = decimal.TryParse(txtSalario.Text, out salario);
            bool estadoActivo = comboBoxEstado.SelectedItem.ToString() == "Activo";

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(puesto) || !salarioValido)
            {
                MessageBox.Show("Por favor, seleccione un empleado para modificar.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Empleados 
                         SET Nombre = @Nombre,
                             Apellido_Paterno = @ApellidoPaterno,
                             Apellido_Materno = @ApellidoMaterno,
                             Puesto = @Puesto,
                             Genero = @Genero,
                             Salario = @Salario,
                             Estado = @Estado
                         WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                cmd.Parameters.AddWithValue("@Puesto", puesto);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@Salario", salario);
                cmd.Parameters.AddWithValue("@Estado", estadoActivo);
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empleado modificado correctamente.");
                    ListarEmpleados();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }



        private void CargarEmpleados()
        {
            using (SqlConnection conn = new SqlConnection("Server=REBECALAZARO\\SQLEXPRESS;Database=GestionEmpleados;Trusted_Connection=True;"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre, Apellido_Paterno, Apellido_Materno, Puesto, Genero, Salario, Estado FROM Empleados", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEmpleados.DataSource = dt;

                // Colorea según el estado
                foreach (DataGridViewRow row in dataGridViewEmpleados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Estado"].Value) == false)
                        row.DefaultCellStyle.BackColor = Color.LightGray; // Inactivo
                    else
                        row.DefaultCellStyle.BackColor = Color.White; // Activo
                }
            }
        }



    }
}

