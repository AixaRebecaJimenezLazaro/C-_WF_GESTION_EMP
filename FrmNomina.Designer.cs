namespace GESTION_EMPLEADOS
{
    partial class FrmNomina
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            cbEmpleado = new ComboBox();
            txtSueldoBase = new TextBox();
            txtDiasTrabajados = new NumericUpDown();
            txtRetardos = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFaltas = new NumericUpDown();
            txtBonos = new TextBox();
            txtDescuentos = new TextBox();
            btnCalcular = new Button();
            txtTotal = new TextBox();
            btnGuardar = new Button();
            label4 = new Label();
            label5 = new Label();
            dgvNomina = new DataGridView();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnGenerar = new Button();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDiasTrabajados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRetardos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFaltas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 47, 62);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 95);
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(715, 29);
            label7.Name = "label7";
            label7.Size = new Size(115, 38);
            label7.TabIndex = 21;
            label7.Text = "Nómina";
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(155, 206);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(348, 28);
            cbEmpleado.TabIndex = 24;
            cbEmpleado.SelectedIndexChanged += cbEmpleado_SelectedIndexChanged;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Enabled = false;
            txtSueldoBase.Location = new Point(518, 206);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.PlaceholderText = "Sueldo Base";
            txtSueldoBase.Size = new Size(190, 27);
            txtSueldoBase.TabIndex = 25;
            // 
            // txtDiasTrabajados
            // 
            txtDiasTrabajados.Location = new Point(155, 312);
            txtDiasTrabajados.Name = "txtDiasTrabajados";
            txtDiasTrabajados.Size = new Size(114, 27);
            txtDiasTrabajados.TabIndex = 26;
            // 
            // txtRetardos
            // 
            txtRetardos.Location = new Point(288, 312);
            txtRetardos.Name = "txtRetardos";
            txtRetardos.Size = new Size(100, 27);
            txtRetardos.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 289);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 28;
            label1.Text = "Días trabajados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 290);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 29;
            label2.Text = "Retardos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 287);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 31;
            label3.Text = "Faltas:";
            // 
            // txtFaltas
            // 
            txtFaltas.Location = new Point(411, 312);
            txtFaltas.Name = "txtFaltas";
            txtFaltas.Size = new Size(92, 27);
            txtFaltas.TabIndex = 30;
            // 
            // txtBonos
            // 
            txtBonos.Location = new Point(723, 207);
            txtBonos.Name = "txtBonos";
            txtBonos.PlaceholderText = "Ingrese si los hay";
            txtBonos.Size = new Size(225, 27);
            txtBonos.TabIndex = 32;
            // 
            // txtDescuentos
            // 
            txtDescuentos.Location = new Point(965, 207);
            txtDescuentos.Name = "txtDescuentos";
            txtDescuentos.PlaceholderText = "Ingrese si los hay";
            txtDescuentos.Size = new Size(166, 27);
            txtDescuentos.TabIndex = 33;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(241, 196, 15);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Image = Properties.Resources.calcu24;
            btnCalcular.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalcular.Location = new Point(1196, 206);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(204, 44);
            btnCalcular.TabIndex = 34;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(518, 311);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "Total = $";
            txtTotal.Size = new Size(190, 27);
            txtTotal.TabIndex = 35;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(15, 188, 249);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = Properties.Resources.regi24;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(1196, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 44);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 183);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 37;
            label4.Text = "Empleado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 183);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 38;
            label5.Text = "Sueldo:";
            // 
            // dgvNomina
            // 
            dgvNomina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNomina.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNomina.BackgroundColor = Color.FromArgb(27, 20, 100);
            dgvNomina.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(6, 82, 221);
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(6, 82, 221);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvNomina.ColumnHeadersHeight = 50;
            dgvNomina.Cursor = Cursors.Hand;
            dgvNomina.GridColor = SystemColors.InfoText;
            dgvNomina.Location = new Point(158, 510);
            dgvNomina.Name = "dgvNomina";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(223, 228, 234);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(116, 125, 140);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvNomina.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvNomina.RowHeadersVisible = false;
            dgvNomina.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(116, 125, 140);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(27, 20, 100);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dgvNomina.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvNomina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNomina.Size = new Size(1242, 359);
            dgvNomina.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 289);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 40;
            label6.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(723, 184);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 41;
            label8.Text = "Bonos adicionales:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(965, 184);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 42;
            label9.Text = "Descuentos:";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(56, 173, 169);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Image = Properties.Resources.reci24;
            btnGenerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerar.Location = new Point(1196, 345);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(204, 44);
            btnGenerar.TabIndex = 43;
            btnGenerar.Text = "Generar Recibo";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(245, 59, 87);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Image = Properties.Resources.can24;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1196, 419);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 48);
            btnLimpiar.TabIndex = 44;
            btnLimpiar.Text = "Cancelar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmNomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 221, 225);
            ClientSize = new Size(1541, 898);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGenerar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(dgvNomina);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnGuardar);
            Controls.Add(txtTotal);
            Controls.Add(btnCalcular);
            Controls.Add(txtDescuentos);
            Controls.Add(txtBonos);
            Controls.Add(label3);
            Controls.Add(txtFaltas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRetardos);
            Controls.Add(txtDiasTrabajados);
            Controls.Add(txtSueldoBase);
            Controls.Add(cbEmpleado);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNomina";
            Text = "FrmNomina";
            Load += FrmNomina_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDiasTrabajados).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRetardos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFaltas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNomina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private ComboBox cbEmpleado;
        private TextBox txtSueldoBase;
        private NumericUpDown txtDiasTrabajados;
        private NumericUpDown txtRetardos;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown txtFaltas;
        private TextBox txtBonos;
        private TextBox txtDescuentos;
        private Button btnCalcular;
        private TextBox txtTotal;
        private Button btnGuardar;
        private Label label4;
        private Label label5;
        private DataGridView dgvNomina;
        private Label label6;
        private Label label8;
        private Label label9;
        private Button btnGenerar;
        private Button btnLimpiar;
    }
}