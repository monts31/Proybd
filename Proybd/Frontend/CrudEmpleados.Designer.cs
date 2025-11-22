namespace Proybd.Frontend
{
    partial class CrudEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudEmpleados));
            dgvEmpleados = new DataGridView();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnRegresar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            id_Empleado = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            horas = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            fecha_Contrato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { id_Empleado, nombre, telefono, rol, horas, sueldo, fecha_Contrato });
            dgvEmpleados.Location = new Point(487, 90);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(642, 538);
            dgvEmpleados.TabIndex = 0;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(38, 495);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(165, 35);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(262, 495);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(38, 556);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(165, 35);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(262, 556);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(165, 35);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Insertar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 126);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(160, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 35);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(160, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 35);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 187);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 7;
            label2.Text = "Telefono";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(160, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 35);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 250);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 9;
            label3.Text = "Rol (1,2)";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(160, 363);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 35);
            textBox4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 373);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 13;
            label4.Text = "Sueldo";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(160, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(267, 35);
            textBox5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 310);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 11;
            label5.Text = "Horas";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(185, 429);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(242, 35);
            textBox7.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 436);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 15;
            label7.Text = "Fecha de contrato";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(606, 40);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(500, 35);
            txtBuscar.TabIndex = 18;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(501, 47);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(68, 25);
            lblBuscar.TabIndex = 17;
            lblBuscar.Text = "Buscar";
            // 
            // id_Empleado
            // 
            id_Empleado.HeaderText = "id_Empleado";
            id_Empleado.Name = "id_Empleado";
            id_Empleado.Width = 80;
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // telefono
            // 
            telefono.HeaderText = "telefono";
            telefono.Name = "telefono";
            // 
            // rol
            // 
            rol.HeaderText = "rol";
            rol.Name = "rol";
            // 
            // horas
            // 
            horas.HeaderText = "horas";
            horas.Name = "horas";
            horas.Width = 50;
            // 
            // sueldo
            // 
            sueldo.HeaderText = "sueldo";
            sueldo.Name = "sueldo";
            sueldo.Width = 90;
            // 
            // fecha_Contrato
            // 
            fecha_Contrato.HeaderText = "fecha_Contrato";
            fecha_Contrato.Name = "fecha_Contrato";
            // 
            // CrudEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1163, 683);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvEmpleados);
            Name = "CrudEmpleados";
            Text = "Form1";
            Load += CrudEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnRegresar;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox7;
        private Label label7;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridViewTextBoxColumn id_Empleado;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn horas;
        private DataGridViewTextBoxColumn sueldo;
        private DataGridViewTextBoxColumn fecha_Contrato;
    }
}