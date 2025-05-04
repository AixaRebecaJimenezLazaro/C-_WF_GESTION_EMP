namespace GESTION_EMPLEADOS
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel1 = new Panel();
            pbRes = new PictureBox();
            pbMinimizar = new PictureBox();
            pbMaximizar = new PictureBox();
            pbCerrar = new PictureBox();
            panel2 = new Panel();
            btnNominas = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPermisos = new Button();
            btnAsistencias = new Button();
            pictureBox1 = new PictureBox();
            btnRegistrar = new Button();
            pnlContenedor = new Panel();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 42, 86);
            panel1.Controls.Add(pbRes);
            panel1.Controls.Add(pbMinimizar);
            panel1.Controls.Add(pbMaximizar);
            panel1.Controls.Add(pbCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1792, 57);
            panel1.TabIndex = 0;
            // 
            // pbRes
            // 
            pbRes.Image = (Image)resources.GetObject("pbRes.Image");
            pbRes.Location = new Point(1682, 12);
            pbRes.Name = "pbRes";
            pbRes.Size = new Size(37, 35);
            pbRes.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRes.TabIndex = 4;
            pbRes.TabStop = false;
            pbRes.Click += pbMaximizar_Click;
            // 
            // pbMinimizar
            // 
            pbMinimizar.Image = Properties.Resources.minimizar64;
            pbMinimizar.Location = new Point(1621, 12);
            pbMinimizar.Name = "pbMinimizar";
            pbMinimizar.Size = new Size(36, 35);
            pbMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMinimizar.TabIndex = 3;
            pbMinimizar.TabStop = false;
            pbMinimizar.Click += pbMinimizar_Click;
            // 
            // pbMaximizar
            // 
            pbMaximizar.Image = Properties.Resources.cuadrosolo64;
            pbMaximizar.Location = new Point(1682, 12);
            pbMaximizar.Name = "pbMaximizar";
            pbMaximizar.Size = new Size(37, 35);
            pbMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMaximizar.TabIndex = 3;
            pbMaximizar.TabStop = false;
            pbMaximizar.Click += pbRestaurar_Click;
            // 
            // pbCerrar
            // 
            pbCerrar.Image = Properties.Resources.cerrar64;
            pbCerrar.Location = new Point(1743, 12);
            pbCerrar.Name = "pbCerrar";
            pbCerrar.Size = new Size(37, 35);
            pbCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrar.TabIndex = 2;
            pbCerrar.TabStop = false;
            pbCerrar.Click += pbCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 59, 72);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnNominas);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnPermisos);
            panel2.Controls.Add(btnAsistencias);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnRegistrar);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 905);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnNominas
            // 
            btnNominas.BackColor = Color.FromArgb(53, 59, 72);
            btnNominas.Cursor = Cursors.Hand;
            btnNominas.FlatAppearance.BorderSize = 0;
            btnNominas.FlatStyle = FlatStyle.Flat;
            btnNominas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNominas.ForeColor = Color.Transparent;
            btnNominas.Location = new Point(3, 664);
            btnNominas.Name = "btnNominas";
            btnNominas.Size = new Size(272, 58);
            btnNominas.TabIndex = 3;
            btnNominas.Text = "Nóminas";
            btnNominas.UseVisualStyleBackColor = false;
            btnNominas.Click += btnNominas_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 566);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 474);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.REGISTRARimg64;
            pictureBox2.Location = new Point(23, 379);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnPermisos
            // 
            btnPermisos.BackColor = Color.FromArgb(53, 59, 72);
            btnPermisos.Cursor = Cursors.Hand;
            btnPermisos.FlatAppearance.BorderSize = 0;
            btnPermisos.FlatStyle = FlatStyle.Flat;
            btnPermisos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPermisos.ForeColor = Color.Transparent;
            btnPermisos.Location = new Point(3, 566);
            btnPermisos.Name = "btnPermisos";
            btnPermisos.Size = new Size(272, 58);
            btnPermisos.TabIndex = 2;
            btnPermisos.Text = "Permisos";
            btnPermisos.UseVisualStyleBackColor = false;
            btnPermisos.Click += btnPermisos_Click;
            // 
            // btnAsistencias
            // 
            btnAsistencias.BackColor = Color.FromArgb(53, 59, 72);
            btnAsistencias.Cursor = Cursors.Hand;
            btnAsistencias.FlatAppearance.BorderSize = 0;
            btnAsistencias.FlatStyle = FlatStyle.Flat;
            btnAsistencias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsistencias.ForeColor = Color.Transparent;
            btnAsistencias.Location = new Point(0, 474);
            btnAsistencias.Name = "btnAsistencias";
            btnAsistencias.Size = new Size(272, 58);
            btnAsistencias.TabIndex = 1;
            btnAsistencias.Text = "Asistencias";
            btnAsistencias.UseVisualStyleBackColor = false;
            btnAsistencias.Click += btnAsistencias_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gemsf;
            pictureBox1.Location = new Point(3, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(53, 59, 72);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Transparent;
            btnRegistrar.Location = new Point(3, 379);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(272, 58);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.ForeColor = Color.Black;
            pnlContenedor.Location = new Point(272, 57);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1520, 905);
            pnlContenedor.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 664);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 221, 225);
            ClientSize = new Size(1792, 962);
            Controls.Add(pnlContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(127, 143, 166);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbMinimizar;
        private PictureBox pbMaximizar;
        private PictureBox pbCerrar;
        private Panel panel2;
        private PictureBox pbRes;
        private Panel pnlContenedor;
        private Button btnRegistrar;
        private PictureBox pictureBox1;
        private Button btnAsistencias;
        private Button btnPermisos;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnNominas;
        private PictureBox pictureBox5;
    }
}