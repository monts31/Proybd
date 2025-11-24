namespace Proybd.Frontend
{
    partial class CrudProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudProductos));
            dgvProductos = new DataGridView();
            co = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblId_Producto = new Label();
            lblNombre = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            txtId_Producto = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { co, Column1, Column2, Column3, Column4 });
            dgvProductos.Location = new Point(453, 57);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(647, 594);
            dgvProductos.TabIndex = 0;
            // 
            // co
            // 
            co.HeaderText = "id_Producto";
            co.MinimumWidth = 6;
            co.Name = "co";
            co.Width = 80;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripcion";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stock";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.BlanchedAlmond;
            btnInsertar.Location = new Point(42, 491);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(157, 41);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.BlanchedAlmond;
            btnModificar.Location = new Point(233, 491);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(157, 41);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.BlanchedAlmond;
            btnEliminar.Location = new Point(42, 551);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 41);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblId_Producto
            // 
            lblId_Producto.AutoSize = true;
            lblId_Producto.BackColor = Color.Transparent;
            lblId_Producto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId_Producto.Location = new Point(24, 114);
            lblId_Producto.Name = "lblId_Producto";
            lblId_Producto.Size = new Size(113, 25);
            lblId_Producto.TabIndex = 4;
            lblId_Producto.Text = "id_Producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(33, 183);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(33, 394);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 25);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock";
            lblStock.Click += lblStock_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(33, 323);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(65, 25);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(24, 253);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(111, 25);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripción";
            // 
            // txtId_Producto
            // 
            txtId_Producto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId_Producto.Location = new Point(131, 107);
            txtId_Producto.Name = "txtId_Producto";
            txtId_Producto.Size = new Size(269, 35);
            txtId_Producto.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(131, 176);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 35);
            txtNombre.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(131, 316);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(269, 35);
            txtPrecio.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(131, 246);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(269, 35);
            txtDescripcion.TabIndex = 12;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(131, 384);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(269, 35);
            txtStock.TabIndex = 14;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.BlanchedAlmond;
            btnInicio.Location = new Point(233, 551);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(160, 40);
            btnInicio.TabIndex = 23;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // CrudProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1153, 693);
            Controls.Add(btnInicio);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtId_Producto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblNombre);
            Controls.Add(lblId_Producto);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvProductos);
            Name = "CrudProductos";
            Text = "CrudProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblId_Producto;
        private Label lblNombre;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblDescripcion;
        private TextBox txtId_Producto;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtStock;
        private Button btnInicio;
        private DataGridViewTextBoxColumn co;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}