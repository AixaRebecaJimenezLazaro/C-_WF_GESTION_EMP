namespace GESTION_EMPLEADOS
{
    partial class FormAsistencia
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
            panel1 = new Panel();
            label7 = new Label();
            comboBoxEmpleado = new ComboBox();
            groupBoxEstado = new GroupBox();
            radioRetardo = new RadioButton();
            radioInasistencia = new RadioButton();
            radioAsistio = new RadioButton();
            txtMotivoRetardo = new TextBox();
            datePicker = new DateTimePicker();
            btnRegistrarAsistencia = new Button();
            dataGridViewAsistencia = new DataGridView();
            btnExportarExcel = new Button();
            comboFiltroExportar = new ComboBox();
            label9 = new Label();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            groupBoxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsistencia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 47, 62);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 95);
            panel1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(533, 26);
            label7.Name = "label7";
            label7.Size = new Size(321, 38);
            label7.TabIndex = 21;
            label7.Text = "Asistencia de Empleados";
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(255, 223);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(371, 28);
            comboBoxEmpleado.TabIndex = 22;
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.BackColor = Color.Transparent;
            groupBoxEstado.Controls.Add(radioRetardo);
            groupBoxEstado.Controls.Add(radioInasistencia);
            groupBoxEstado.Controls.Add(radioAsistio);
            groupBoxEstado.FlatStyle = FlatStyle.Flat;
            groupBoxEstado.Location = new Point(255, 297);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(371, 77);
            groupBoxEstado.TabIndex = 23;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "Estado de Asistencia:";
            // 
            // radioRetardo
            // 
            radioRetardo.AutoSize = true;
            radioRetardo.Cursor = Cursors.Hand;
            radioRetardo.Location = new Point(282, 36);
            radioRetardo.Name = "radioRetardo";
            radioRetardo.Size = new Size(83, 24);
            radioRetardo.TabIndex = 25;
            radioRetardo.TabStop = true;
            radioRetardo.Text = "Retardo";
            radioRetardo.UseVisualStyleBackColor = true;
            // 
            // radioInasistencia
            // 
            radioInasistencia.AutoSize = true;
            radioInasistencia.Cursor = Cursors.Hand;
            radioInasistencia.Location = new Point(140, 36);
            radioInasistencia.Name = "radioInasistencia";
            radioInasistencia.Size = new Size(106, 24);
            radioInasistencia.TabIndex = 25;
            radioInasistencia.TabStop = true;
            radioInasistencia.Text = "Inasistencia";
            radioInasistencia.UseVisualStyleBackColor = true;
            // 
            // radioAsistio
            // 
            radioAsistio.AutoSize = true;
            radioAsistio.Cursor = Cursors.Hand;
            radioAsistio.Location = new Point(6, 36);
            radioAsistio.Name = "radioAsistio";
            radioAsistio.Size = new Size(74, 24);
            radioAsistio.TabIndex = 24;
            radioAsistio.TabStop = true;
            radioAsistio.Text = "Asistió";
            radioAsistio.UseVisualStyleBackColor = true;
            // 
            // txtMotivoRetardo
            // 
            txtMotivoRetardo.Location = new Point(255, 422);
            txtMotivoRetardo.Name = "txtMotivoRetardo";
            txtMotivoRetardo.PlaceholderText = "Escriba aquí el motivo de retardo o inasistencia";
            txtMotivoRetardo.Size = new Size(749, 27);
            txtMotivoRetardo.TabIndex = 24;
            txtMotivoRetardo.Visible = false;
            txtMotivoRetardo.TextChanged += txtMotivoRetardo_TextChanged;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(661, 221);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(349, 27);
            datePicker.TabIndex = 25;
            // 
            // btnRegistrarAsistencia
            // 
            btnRegistrarAsistencia.BackColor = Color.FromArgb(15, 188, 249);
            btnRegistrarAsistencia.FlatAppearance.BorderSize = 0;
            btnRegistrarAsistencia.FlatStyle = FlatStyle.Flat;
            btnRegistrarAsistencia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarAsistencia.Image = Properties.Resources.regi24;
            btnRegistrarAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarAsistencia.Location = new Point(1039, 219);
            btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            btnRegistrarAsistencia.Size = new Size(204, 50);
            btnRegistrarAsistencia.TabIndex = 26;
            btnRegistrarAsistencia.Text = "Registrar";
            btnRegistrarAsistencia.UseVisualStyleBackColor = false;
            btnRegistrarAsistencia.Click += btnRegistrarAsistencia_Click;
            // 
            // dataGridViewAsistencia
            // 
            dataGridViewAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAsistencia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAsistencia.BackgroundColor = Color.FromArgb(220, 221, 225);
            dataGridViewAsistencia.BorderStyle = BorderStyle.None;
            dataGridViewAsistencia.ColumnHeadersHeight = 50;
            dataGridViewAsistencia.Cursor = Cursors.Hand;
            dataGridViewAsistencia.Location = new Point(261, 483);
            dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            dataGridViewAsistencia.RowHeadersVisible = false;
            dataGridViewAsistencia.RowHeadersWidth = 51;
            dataGridViewAsistencia.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewAsistencia.Size = new Size(749, 305);
            dataGridViewAsistencia.TabIndex = 27;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(5, 196, 107);
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarExcel.Image = Properties.Resources.excel24;
            btnExportarExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportarExcel.Location = new Point(1039, 333);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(204, 48);
            btnExportarExcel.TabIndex = 28;
            btnExportarExcel.Text = "Exportar";
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // comboFiltroExportar
            // 
            comboFiltroExportar.FormattingEnabled = true;
            comboFiltroExportar.Location = new Point(1039, 421);
            comboFiltroExportar.Name = "comboFiltroExportar";
            comboFiltroExportar.Size = new Size(204, 28);
            comboFiltroExportar.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1039, 464);
            label9.Name = "label9";
            label9.Size = new Size(204, 34);
            label9.TabIndex = 30;
            label9.Text = "Nota: si desea exportar mediante\r\nfiltrado seleccione una opción";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(245, 59, 87);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Image = Properties.Resources.can24;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1039, 533);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 48);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Cancelar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 221, 225);
            ClientSize = new Size(1291, 812);
            Controls.Add(btnLimpiar);
            Controls.Add(label9);
            Controls.Add(comboFiltroExportar);
            Controls.Add(btnExportarExcel);
            Controls.Add(dataGridViewAsistencia);
            Controls.Add(btnRegistrarAsistencia);
            Controls.Add(datePicker);
            Controls.Add(txtMotivoRetardo);
            Controls.Add(groupBoxEstado);
            Controls.Add(comboBoxEmpleado);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            Load += FormAsistencia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxEstado.ResumeLayout(false);
            groupBoxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private ComboBox comboBoxEmpleado;
        private GroupBox groupBoxEstado;
        private RadioButton radioRetardo;
        private RadioButton radioInasistencia;
        private RadioButton radioAsistio;
        private TextBox txtMotivoRetardo;
        private DateTimePicker datePicker;
        private Button btnRegistrarAsistencia;
        private DataGridView dataGridViewAsistencia;
        private Button btnExportarExcel;
        private ComboBox comboFiltroExportar;
        private Label label9;
        private Button btnLimpiar;
    }
}