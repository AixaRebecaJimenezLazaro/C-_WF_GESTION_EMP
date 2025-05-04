namespace GESTION_EMPLEADOS
{
    partial class frmRegistro
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            comboBoxPuesto = new ComboBox();
            txtSalario = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            dataGridViewEmpleados = new DataGridView();
            txtBuscar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxGenero = new ComboBox();
            btnModificar = new Button();
            panel1 = new Panel();
            label7 = new Label();
            comboBoxEstado = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            btnExportarExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(278, 179);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(525, 180);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(237, 27);
            txtAPaterno.TabIndex = 1;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(783, 179);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(246, 27);
            txtAMaterno.TabIndex = 2;
            // 
            // comboBoxPuesto
            // 
            comboBoxPuesto.FormattingEnabled = true;
            comboBoxPuesto.Location = new Point(783, 280);
            comboBoxPuesto.Name = "comboBoxPuesto";
            comboBoxPuesto.Size = new Size(246, 28);
            comboBoxPuesto.TabIndex = 3;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(525, 280);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(237, 27);
            txtSalario.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(15, 188, 249);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.regi24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(1119, 169);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 48);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(245, 59, 87);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Image = Properties.Resources.can24;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1119, 243);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 48);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Cancelar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEmpleados.BackgroundColor = Color.FromArgb(27, 20, 100);
            dataGridViewEmpleados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(6, 82, 221);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(6, 82, 221);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewEmpleados.ColumnHeadersHeight = 50;
            dataGridViewEmpleados.Cursor = Cursors.Hand;
            dataGridViewEmpleados.GridColor = SystemColors.InfoText;
            dataGridViewEmpleados.Location = new Point(278, 557);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(116, 125, 140);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewEmpleados.RowHeadersVisible = false;
            dataGridViewEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(116, 125, 140);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(27, 20, 100);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmpleados.Size = new Size(912, 314);
            dataGridViewEmpleados.TabIndex = 9;
            dataGridViewEmpleados.CellContentClick += dataGridViewEmpleados_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(278, 515);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Empleado";
            txtBuscar.Size = new Size(208, 27);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 156);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 157);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 13;
            label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(783, 156);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 14;
            label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(783, 257);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 15;
            label4.Text = "Puesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 257);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 16;
            label5.Text = "Salario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 255);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 18;
            label6.Text = "Género:";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(278, 278);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(225, 28);
            comboBoxGenero.TabIndex = 17;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(241, 196, 15);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Image = Properties.Resources.modi24;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(1119, 314);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(204, 48);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "Modificar";
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
            panel1.Size = new Size(1364, 95);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(610, 27);
            label7.Name = "label7";
            label7.Size = new Size(299, 38);
            label7.TabIndex = 21;
            label7.Text = "Registro de Empleados";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Femenino", "Masculino" });
            comboBoxEstado.Location = new Point(278, 365);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(225, 28);
            comboBoxEstado.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 342);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 23;
            label8.Text = "Estado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(281, 396);
            label9.Name = "label9";
            label9.Size = new Size(199, 34);
            label9.TabIndex = 24;
            label9.Text = "Nota: si el empleado esta activo,\r\naparecera marcada la casilla";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(5, 196, 107);
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarExcel.Image = Properties.Resources.excel24;
            btnExportarExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarExcel.Location = new Point(1119, 382);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(204, 48);
            btnExportarExcel.TabIndex = 29;
            btnExportarExcel.Text = "Exportar";
            btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 221, 225);
            ClientSize = new Size(1364, 883);
            Controls.Add(btnExportarExcel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBoxEstado);
            Controls.Add(panel1);
            Controls.Add(btnModificar);
            Controls.Add(label6);
            Controls.Add(comboBoxGenero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridViewEmpleados);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(txtSalario);
            Controls.Add(comboBoxPuesto);
            Controls.Add(txtAMaterno);
            Controls.Add(txtAPaterno);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistro";
            Text = "frmRegistro";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private ComboBox comboBoxPuesto;
        private TextBox txtSalario;
        private Button btnAgregar;
        private Button btnLimpiar;
        private DataGridView dataGridViewEmpleados;
        private TextBox txtBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxGenero;
        private Button btnModificar;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBoxEstado;
        private Label label8;
        private Label label9;
        private Button btnExportarExcel;
    }
}