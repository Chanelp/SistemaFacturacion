namespace SistemaFacturacion
{
    partial class Facturacion
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnColocar = new Button();
            btnEliminar = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnNuevo = new Button();
            btnFacturar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            ColCodigo = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColImporte = new DataGridViewTextBoxColumn();
            txtCodigoCli = new Contolesusuario.ErrorTxtBox();
            txtCliente = new Contolesusuario.ErrorTxtBox();
            lblAtiende = new Label();
            btnBuscar = new Button();
            lblTT = new Label();
            lblTotal = new Label();
            txtCodigoPro = new Contolesusuario.ErrorTxtBox();
            txtDescripcion = new Contolesusuario.ErrorTxtBox();
            txtPrecio = new Contolesusuario.ErrorTxtBox();
            txtCantidad = new Contolesusuario.ErrorTxtBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 408);
            btnSalir.Size = new Size(125, 25);
            // 
            // btnColocar
            // 
            btnColocar.Location = new Point(713, 154);
            btnColocar.Name = "btnColocar";
            btnColocar.Size = new Size(125, 23);
            btnColocar.TabIndex = 1;
            btnColocar.Text = "Colocar";
            btnColocar.UseVisualStyleBackColor = true;
            btnColocar.Click += btnColocar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(713, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(713, 240);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(125, 23);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(713, 280);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(125, 23);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(713, 323);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 23);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(713, 365);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(125, 23);
            btnFacturar.TabIndex = 6;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 8;
            label1.Text = "Le atiende:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 9;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 103);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 10;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 170);
            label4.Name = "label4";
            label4.Size = new Size(122, 27);
            label4.TabIndex = 11;
            label4.Text = "Código";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(143, 170);
            label5.Name = "label5";
            label5.Size = new Size(192, 27);
            label5.TabIndex = 12;
            label5.Text = "Descripción";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(331, 170);
            label6.Name = "label6";
            label6.Size = new Size(133, 27);
            label6.TabIndex = 13;
            label6.Text = "Precio";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(460, 170);
            label7.Name = "label7";
            label7.Size = new Size(106, 27);
            label7.TabIndex = 14;
            label7.Text = "Cantidad";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(562, 170);
            label8.Name = "label8";
            label8.Size = new Size(100, 27);
            label8.TabIndex = 15;
            label8.Text = "Importe";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColCodigo, ColDescripcion, ColPrecio, ColCantidad, ColImporte });
            dataGridView1.Location = new Point(23, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(639, 243);
            dataGridView1.TabIndex = 16;
            // 
            // ColCodigo
            // 
            ColCodigo.HeaderText = "Codigo";
            ColCodigo.Name = "ColCodigo";
            ColCodigo.Width = 110;
            // 
            // ColDescripcion
            // 
            ColDescripcion.HeaderText = "Descripcion";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.Width = 200;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.Width = 110;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.Width = 110;
            // 
            // ColImporte
            // 
            ColImporte.HeaderText = "Importe";
            ColImporte.Name = "ColImporte";
            ColImporte.Width = 110;
            // 
            // txtCodigoCli
            // 
            txtCodigoCli.Location = new Point(134, 62);
            txtCodigoCli.Name = "txtCodigoCli";
            txtCodigoCli.Size = new Size(112, 23);
            txtCodigoCli.SoloNumeros = false;
            txtCodigoCli.TabIndex = 18;
            txtCodigoCli.Validar = false;
            txtCodigoCli.TextChanged += errorTxtBox2_TextChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(134, 101);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(193, 23);
            txtCliente.SoloNumeros = false;
            txtCliente.TabIndex = 19;
            txtCliente.Validar = true;
            // 
            // lblAtiende
            // 
            lblAtiende.BackColor = SystemColors.ButtonHighlight;
            lblAtiende.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtiende.Location = new Point(134, 26);
            lblAtiende.Name = "lblAtiende";
            lblAtiende.Size = new Size(155, 23);
            lblAtiende.TabIndex = 20;
            lblAtiende.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(252, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblTT
            // 
            lblTT.AutoSize = true;
            lblTT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTT.Location = new Point(509, 451);
            lblTT.Name = "lblTT";
            lblTT.Size = new Size(47, 16);
            lblTT.TabIndex = 22;
            lblTT.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.GradientActiveCaption;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(562, 447);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 23;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodigoPro
            // 
            txtCodigoPro.Location = new Point(32, 141);
            txtCodigoPro.Name = "txtCodigoPro";
            txtCodigoPro.Size = new Size(100, 23);
            txtCodigoPro.SoloNumeros = false;
            txtCodigoPro.TabIndex = 24;
            txtCodigoPro.Validar = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(153, 141);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(173, 23);
            txtDescripcion.SoloNumeros = false;
            txtDescripcion.TabIndex = 25;
            txtDescripcion.Validar = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(346, 141);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(96, 23);
            txtPrecio.SoloNumeros = false;
            txtPrecio.TabIndex = 26;
            txtPrecio.Validar = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(460, 141);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.SoloNumeros = false;
            txtCantidad.TabIndex = 27;
            txtCantidad.Validar = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 493);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoPro);
            Controls.Add(lblTotal);
            Controls.Add(lblTT);
            Controls.Add(btnBuscar);
            Controls.Add(lblAtiende);
            Controls.Add(txtCliente);
            Controls.Add(txtCodigoCli);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFacturar);
            Controls.Add(btnNuevo);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnColocar);
            Controls.Add(dataGridView1);
            Name = "Facturacion";
            Text = "Facturacion";
            Load += Facturacion_Load_1;
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnColocar, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnClientes, 0);
            Controls.SetChildIndex(btnProductos, 0);
            Controls.SetChildIndex(btnNuevo, 0);
            Controls.SetChildIndex(btnFacturar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtCodigoCli, 0);
            Controls.SetChildIndex(txtCliente, 0);
            Controls.SetChildIndex(lblAtiende, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(lblTT, 0);
            Controls.SetChildIndex(lblTotal, 0);
            Controls.SetChildIndex(txtCodigoPro, 0);
            Controls.SetChildIndex(txtDescripcion, 0);
            Controls.SetChildIndex(txtPrecio, 0);
            Controls.SetChildIndex(txtCantidad, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnColocar;
        private Button btnEliminar;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnNuevo;
        private Button btnFacturar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Contolesusuario.ErrorTxtBox txtCodigoCli;
        private Contolesusuario.ErrorTxtBox txtCliente;
        private Label lblAtiende;
        private Button btnBuscar;
        private Label lblTT;
        private Label lblTotal;
        private Contolesusuario.ErrorTxtBox txtCodigoPro;
        private Contolesusuario.ErrorTxtBox txtDescripcion;
        private Contolesusuario.ErrorTxtBox txtPrecio;
        private Contolesusuario.ErrorTxtBox txtCantidad;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn ColCodigo;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColImporte;
    }
}