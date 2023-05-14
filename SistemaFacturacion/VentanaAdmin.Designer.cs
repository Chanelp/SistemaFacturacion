namespace SistemaFacturacion
{
    partial class VentanaAdmin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            lblNomAdmin = new Label();
            lblUsAdmin = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(379, 203);
            btnSalir.Size = new Size(134, 23);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Admin:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 87);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 145);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Código:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(379, 30);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 6;
            button1.Text = "Contenedor Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(379, 73);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 7;
            button2.Text = "Administrar Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(379, 117);
            button3.Name = "button3";
            button3.Size = new Size(134, 23);
            button3.TabIndex = 8;
            button3.Text = "Cambiar Contraseña";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(379, 159);
            button4.Name = "button4";
            button4.Size = new Size(134, 23);
            button4.TabIndex = 9;
            button4.Text = "Cerrar Sesión";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblNomAdmin
            // 
            lblNomAdmin.AutoSize = true;
            lblNomAdmin.Location = new Point(127, 39);
            lblNomAdmin.Name = "lblNomAdmin";
            lblNomAdmin.Size = new Size(38, 15);
            lblNomAdmin.TabIndex = 12;
            lblNomAdmin.Text = "label4";
            lblNomAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsAdmin
            // 
            lblUsAdmin.AutoSize = true;
            lblUsAdmin.Location = new Point(127, 92);
            lblUsAdmin.Name = "lblUsAdmin";
            lblUsAdmin.Size = new Size(38, 15);
            lblUsAdmin.TabIndex = 13;
            lblUsAdmin.Text = "label5";
            lblUsAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(127, 149);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(38, 15);
            lblCodigo.TabIndex = 14;
            lblCodigo.Text = "label6";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VentanaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 444);
            Controls.Add(lblCodigo);
            Controls.Add(lblUsAdmin);
            Controls.Add(lblNomAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaAdmin";
            Text = "VentanaAdmin";
            FormClosed += VentanaAdmin_FormClosed;
            Load += VentanaAdmin_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(lblNomAdmin, 0);
            Controls.SetChildIndex(lblUsAdmin, 0);
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label lblNomAdmin;
        private Label lblUsAdmin;
        private Label lblCodigo;
    }
}