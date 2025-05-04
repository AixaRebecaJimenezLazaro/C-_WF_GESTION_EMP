namespace GESTION_EMPLEADOS
{
    partial class FormPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermisos));
            comboBoxEmpleado = new ComboBox();
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            txtMotivo = new TextBox();
            comboBoxEstado = new ComboBox();
            btnRegistrarPermiso = new Button();
            btnGenerarDocumento = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewPermisos = new DataGridView();
            btnModificar = new Button();
            panel1 = new Panel();
            label7 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermisos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(210, 197);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(439, 28);
            comboBoxEmpleado.TabIndex = 23;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Format = DateTimePickerFormat.Short;
            dateTimePickerFin.Location = new Point(889, 198);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(184, 27);
            dateTimePickerFin.TabIndex = 24;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(680, 195);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(182, 27);
            dateTimePickerInicio.TabIndex = 25;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(210, 291);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.PlaceholderText = "Ingrese aquí el motivo ";
            txtMotivo.Size = new Size(863, 197);
            txtMotivo.TabIndex = 26;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(1121, 198);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(228, 28);
            comboBoxEstado.TabIndex = 27;
            // 
            // btnRegistrarPermiso
            // 
            btnRegistrarPermiso.BackColor = Color.FromArgb(255, 121, 63);
            btnRegistrarPermiso.FlatAppearance.BorderSize = 0;
            btnRegistrarPermiso.FlatStyle = FlatStyle.Flat;
            btnRegistrarPermiso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPermiso.Image = (Image)resources.GetObject("btnRegistrarPermiso.Image");
            btnRegistrarPermiso.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarPermiso.Location = new Point(1121, 336);
            btnRegistrarPermiso.Name = "btnRegistrarPermiso";
            btnRegistrarPermiso.Size = new Size(228, 53);
            btnRegistrarPermiso.TabIndex = 28;
            btnRegistrarPermiso.Text = "Registrar Permiso";
            btnRegistrarPermiso.UseVisualStyleBackColor = false;
            btnRegistrarPermiso.Click += btnRegistrarPermiso_Click;
            // 
            // btnGenerarDocumento
            // 
            btnGenerarDocumento.BackColor = Color.FromArgb(46, 134, 222);
            btnGenerarDocumento.FlatAppearance.BorderSize = 0;
            btnGenerarDocumento.FlatStyle = FlatStyle.Flat;
            btnGenerarDocumento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarDocumento.Image = (Image)resources.GetObject("btnGenerarDocumento.Image");
            btnGenerarDocumento.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerarDocumento.Location = new Point(1121, 291);
            btnGenerarDocumento.Name = "btnGenerarDocumento";
            btnGenerarDocumento.Size = new Size(228, 39);
            btnGenerarDocumento.TabIndex = 29;
            btnGenerarDocumento.Text = "Generar Documento";
            btnGenerarDocumento.UseVisualStyleBackColor = false;
            btnGenerarDocumento.Click += btnGenerarDocumento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 167);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 30;
            label1.Text = "Empleado que solicita el permiso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(680, 167);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 31;
            label2.Text = "Fecha de inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(889, 167);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 32;
            label3.Text = "Fecha de finalización:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1121, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 33;
            label4.Text = "Estado:";
            // 
            // dataGridViewPermisos
            // 
            dataGridViewPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPermisos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPermisos.BackgroundColor = Color.FromArgb(220, 221, 225);
            dataGridViewPermisos.BorderStyle = BorderStyle.None;
            dataGridViewPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPermisos.EnableHeadersVisualStyles = false;
            dataGridViewPermisos.Location = new Point(210, 506);
            dataGridViewPermisos.Name = "dataGridViewPermisos";
            dataGridViewPermisos.RowHeadersWidth = 51;
            dataGridViewPermisos.Size = new Size(1139, 359);
            dataGridViewPermisos.TabIndex = 34;
            dataGridViewPermisos.CellContentClick += dataGridViewPermisos_CellContentClick;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(241, 196, 15);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Image = Properties.Resources.modi24;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(1121, 395);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(228, 38);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 47, 62);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 95);
            panel1.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(709, 23);
            label7.Name = "label7";
            label7.Size = new Size(235, 38);
            label7.TabIndex = 21;
            label7.Text = "Generar Permisos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(245, 59, 87);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Image = Properties.Resources.can24;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1121, 439);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(228, 36);
            btnLimpiar.TabIndex = 45;
            btnLimpiar.Text = "Cancelar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 221, 225);
            ClientSize = new Size(1488, 892);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(dataGridViewPermisos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerarDocumento);
            Controls.Add(btnRegistrarPermiso);
            Controls.Add(comboBoxEstado);
            Controls.Add(txtMotivo);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(dateTimePickerFin);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPermisos";
            Text = "FormPermisos";
            Load += FormPermisos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermisos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxEmpleado;
        private DateTimePicker dateTimePickerFin;
        private DateTimePicker dateTimePickerInicio;
        private TextBox txtMotivo;
        private ComboBox comboBoxEstado;
        private Button btnRegistrarPermiso;
        private Button btnGenerarDocumento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewPermisos;
        private Button btnModificar;
        private Panel panel1;
        private Label label7;
        private Button btnLimpiar;
    }
}