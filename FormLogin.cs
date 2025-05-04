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
    public partial class FormLogin : Form
    {

        string connectionString = "Server=REBECALAZARO\\SQLEXPRESS;Database=GestionEmpleados;Trusted_Connection=True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            //MessageBox.Show("Login exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FormMenu inicio = new FormMenu();
                            inicio.Show();
                            this.Hide();
                        }
                        else
                        {
                            DialogResult resultado = MessageBox.Show(
                                "Usuario o contraseña incorrectos.\n¿Deseas registrarte?",
                                "Usuario no encontrado",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (resultado == DialogResult.Yes)
                            {
                                frmRegistro registro = new frmRegistro();
                                registro.Show();
                                this.Hide();
                            }
                            else
                            {
                                txtContrasena.Clear();
                                txtContrasena.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo al ingresar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
