namespace SistemaFacturacion
{
    partial class VentanaUser
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
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNomUs = new Label();
            lblUs = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(395, 180);
            btnSalir.Size = new Size(134, 23);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(395, 138);
            button4.Name = "button4";
            button4.Size = new Size(134, 23);
            button4.TabIndex = 21;
            button4.Text = "Cerrar Sesión";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(395, 94);
            button3.Name = "button3";
            button3.Size = new Size(134, 23);
            button3.TabIndex = 20;
            button3.Text = "Cambiar Contraseña";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(395, 52);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 18;
            button1.Text = "Contenedor Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 155);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 17;
            label3.Text = "Código:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 97);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 16;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // lblNomUs
            // 
            lblNomUs.AutoSize = true;
            lblNomUs.Location = new Point(157, 51);
            lblNomUs.Name = "lblNomUs";
            lblNomUs.Size = new Size(38, 15);
            lblNomUs.TabIndex = 24;
            lblNomUs.Text = "label4";
            lblNomUs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUs
            // 
            lblUs.AutoSize = true;
            lblUs.Location = new Point(157, 101);
            lblUs.Name = "lblUs";
            lblUs.Size = new Size(38, 15);
            lblUs.TabIndex = 25;
            lblUs.Text = "label4";
            lblUs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(157, 160);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(38, 15);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "label4";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VentanaUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 459);
            Controls.Add(lblCodigo);
            Controls.Add(lblUs);
            Controls.Add(lblNomUs);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaUser";
            Text = "VentanaUser";
            FormClosed += VentanaUser_FormClosed;
            Load += VentanaUser_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(lblNomUs, 0);
            Controls.SetChildIndex(lblUs, 0);
            Controls.SetChildIndex(lblCodigo, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNomUs;
        private Label lblUs;
        private Label lblCodigo;
    }
}