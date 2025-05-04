using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_EMPLEADOS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            //maximiza la pantalla
            this.WindowState = FormWindowState.Maximized;
            // esto hace que los iconos cambien dependiendo como este el frm
            pbMaximizar.Visible = false;
            pbRes.Visible = true;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AbrirFrmNuevo(Form AbrirFrmNuevo) //rebeca
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            AbrirFrmNuevo.TopLevel = false; // establecer que no es formulario de nivel superior
            AbrirFrmNuevo.Dock = DockStyle.Fill; // ajusta al panel completo
            this.pnlContenedor.Controls.Add(AbrirFrmNuevo); // agregar el nuevo formulario al pnlContenedor
            this.pnlContenedor.Tag = AbrirFrmNuevo;// Marcar el nuevo formulario
            AbrirFrmNuevo.Show(); //mostrar el formulario
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFrmNuevo(new frmRegistro());
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            //devuelve a tamaño normal
            this.WindowState = FormWindowState.Normal;
            pbRes.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFrmNuevo(new FormAsistencia());
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirFrmNuevo(new FormPermisos());
        }

        private void btnNominas_Click(object sender, EventArgs e)
        {
            AbrirFrmNuevo(new FrmNomina());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //private void btnVentas_Click(object sender, EventArgs e)
        //{  EJEMPLO
        //abre frm ventas
        //AbrirFrmNuevo(new Ventas());
        //}



    }
}
