namespace SistemaFacturacion
{
    partial class VentanaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            btnIniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNomAcc = new TextBox();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(216, 219);
            btnSalir.Size = new Size(135, 23);
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(45, 219);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(138, 23);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 80);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 2;
            label1.Text = "Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 137);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // txtNomAcc
            // 
            txtNomAcc.Location = new Point(181, 84);
            txtNomAcc.Name = "txtNomAcc";
            txtNomAcc.Size = new Size(170, 23);
            txtNomAcc.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(181, 141);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(170, 23);
            txtPass.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(407, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // VentanaLogin
            // 
            AcceptButton = btnIniciar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 280);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(txtNomAcc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Name = "VentanaLogin";
            Text = "Form1";
            FormClosed += VentanaLogin_FormClosed;
            Load += VentanaLogin_Load;
            Controls.SetChildIndex(btnIniciar, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNomAcc, 0);
            Controls.SetChildIndex(txtPass, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label label1;
        private Label label2;
        private TextBox txtNomAcc;
        private TextBox txtPass;
        private PictureBox pictureBox1;
    }
}