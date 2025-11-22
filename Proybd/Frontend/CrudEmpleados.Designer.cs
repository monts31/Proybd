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
            id_Empleado = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            horas = new DataGridViewTextBoxColumn();
            sueldo = new DataGridViewTextBoxColumn();
            fecha_Contrato = new DataGridViewTextBoxColumn();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnRegresar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtRol = new TextBox();
            label3 = new Label();
            txtSueldo = new TextBox();
            label4 = new Label();
            txtHoras = new TextBox();
            label5 = new Label();
            txtfecha_Contrato = new TextBox();
            label7 = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            txtId_Empleado = new TextBox();
            label6 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { id_Empleado, nombre, telefono, rol, horas, sueldo, fecha_Contrato });
            dgvEmpleados.Location = new Point(490, 93);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(642, 538);
            dgvEmpleados.TabIndex = 0;
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
            // btnInsertar
            // 
            btnInsertar.Location = new Point(38, 524);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(165, 35);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(262, 524);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(38, 585);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(165, 35);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(262, 585);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(165, 35);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Insertar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
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
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(160, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 35);
            txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(160, 180);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(267, 35);
            txtTelefono.TabIndex = 8;
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
            // txtRol
            // 
            txtRol.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRol.Location = new Point(160, 240);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(267, 35);
            txtRol.TabIndex = 10;
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
            // txtSueldo
            // 
            txtSueldo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSueldo.Location = new Point(160, 363);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(267, 35);
            txtSueldo.TabIndex = 14;
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
            // txtHoras
            // 
            txtHoras.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoras.Location = new Point(160, 300);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(267, 35);
            txtHoras.TabIndex = 12;
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
            // txtfecha_Contrato
            // 
            txtfecha_Contrato.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfecha_Contrato.Location = new Point(185, 429);
            txtfecha_Contrato.Name = "txtfecha_Contrato";
            txtfecha_Contrato.Size = new Size(242, 35);
            txtfecha_Contrato.TabIndex = 16;
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
            // txtId_Empleado
            // 
            txtId_Empleado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId_Empleado.Location = new Point(160, 58);
            txtId_Empleado.Name = "txtId_Empleado";
            txtId_Empleado.Size = new Size(267, 35);
            txtId_Empleado.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 65);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 19;
            label6.Text = "Id_Empleado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 480);
            label8.Name = "label8";
            label8.Size = new Size(389, 30);
            label8.TabIndex = 21;
            label8.Text = "Nota: Los campos como el id_Empleado o fecha de contrato pueden ser \r\nauto rellenados, el resto de campos son obligatorios.\r\n";
            // 
            // CrudEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1163, 683);
            Controls.Add(label8);
            Controls.Add(txtId_Empleado);
            Controls.Add(label6);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtfecha_Contrato);
            Controls.Add(label7);
            Controls.Add(txtSueldo);
            Controls.Add(label4);
            Controls.Add(txtHoras);
            Controls.Add(label5);
            Controls.Add(txtRol);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombre);
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
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtRol;
        private Label label3;
        private TextBox txtSueldo;
        private Label label4;
        private TextBox txtHoras;
        private Label label5;
        private TextBox txtfecha_Contrato;
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
        private TextBox txtId_Empleado;
        private Label label6;
        private Label label8;
    }
}