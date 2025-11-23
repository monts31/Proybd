namespace Proybd.Frontend
{
    partial class frmRegistroVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroVentas));
            dgvDOrdenes = new DataGridView();
            dgvOrdenes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            id_Orden = new DataGridViewTextBoxColumn();
            id_Producto = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            id_Orden1 = new DataGridViewTextBoxColumn();
            id_Producto1 = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDOrdenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // dgvDOrdenes
            // 
            dgvDOrdenes.BackgroundColor = Color.SeaShell;
            dgvDOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDOrdenes.Columns.AddRange(new DataGridViewColumn[] { id_Orden1, id_Producto1, precio, cantidad });
            dgvDOrdenes.Location = new Point(586, 65);
            dgvDOrdenes.Name = "dgvDOrdenes";
            dgvDOrdenes.RowHeadersWidth = 51;
            dgvDOrdenes.Size = new Size(451, 549);
            dgvDOrdenes.TabIndex = 15;
            dgvDOrdenes.CellContentClick += dgvProductos_CellContentClick;
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.BackgroundColor = Color.SeaShell;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Columns.AddRange(new DataGridViewColumn[] { id_Orden, id_Producto, fecha });
            dgvOrdenes.Location = new Point(96, 65);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersWidth = 51;
            dgvOrdenes.Size = new Size(354, 549);
            dgvOrdenes.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 17;
            label1.Text = "Ordenes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(723, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 18;
            label2.Text = "Detalles de orden";
            // 
            // id_Orden
            // 
            id_Orden.HeaderText = "id_Orden";
            id_Orden.Name = "id_Orden";
            // 
            // id_Producto
            // 
            id_Producto.HeaderText = "id_Usuario";
            id_Producto.Name = "id_Producto";
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            // 
            // id_Orden1
            // 
            id_Orden1.HeaderText = "id_Orden";
            id_Orden1.Name = "id_Orden1";
            // 
            // id_Producto1
            // 
            id_Producto1.HeaderText = "id_Producto";
            id_Producto1.Name = "id_Producto1";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.YellowGreen;
            btnInicio.Location = new Point(455, 645);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(124, 24);
            btnInicio.TabIndex = 20;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // frmRegistroVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1071, 703);
            Controls.Add(btnInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrdenes);
            Controls.Add(dgvDOrdenes);
            Name = "frmRegistroVentas";
            Text = "frmRegistroVentas";
            ((System.ComponentModel.ISupportInitialize)dgvDOrdenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDOrdenes;
        private DataGridView dgvOrdenes;
        private DataGridViewTextBoxColumn id_Orden;
        private DataGridViewTextBoxColumn id_Producto;
        private DataGridViewTextBoxColumn fecha;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn id_Orden1;
        private DataGridViewTextBoxColumn id_Producto1;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private Button btnInicio;
    }
}