namespace SistemaFacturacion
{
    partial class MantenimientoProducto
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
            txtIdPro = new Contolesusuario.ErrorTxtBox();
            txtNomPro = new Contolesusuario.ErrorTxtBox();
            txtPrecio = new Contolesusuario.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(439, 41);
            // 
            // button2
            // 
            button2.Location = new Point(439, 86);
            // 
            // button3
            // 
            button3.Location = new Point(439, 133);
            // 
            // button4
            // 
            button4.Location = new Point(439, 179);
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(439, 225);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 69);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 5;
            label1.Text = "ID_producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 130);
            label2.Name = "label2";
            label2.Size = new Size(94, 16);
            label2.TabIndex = 6;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 190);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            // 
            // txtIdPro
            // 
            txtIdPro.Location = new Point(164, 62);
            txtIdPro.Name = "txtIdPro";
            txtIdPro.Size = new Size(162, 23);
            txtIdPro.SoloNumeros = true;
            txtIdPro.TabIndex = 11;
            txtIdPro.Validar = true;
            // 
            // txtNomPro
            // 
            txtNomPro.Location = new Point(164, 123);
            txtNomPro.Name = "txtNomPro";
            txtNomPro.Size = new Size(162, 23);
            txtNomPro.SoloNumeros = false;
            txtNomPro.TabIndex = 12;
            txtNomPro.Validar = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(164, 188);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(162, 23);
            txtPrecio.SoloNumeros = true;
            txtPrecio.TabIndex = 13;
            txtPrecio.Validar = true;
            // 
            // MantenimientoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 292);
            Controls.Add(txtPrecio);
            Controls.Add(txtNomPro);
            Controls.Add(txtIdPro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MantenimientoProducto";
            Text = "MantenimientoProducto";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtIdPro, 0);
            Controls.SetChildIndex(txtNomPro, 0);
            Controls.SetChildIndex(txtPrecio, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Contolesusuario.ErrorTxtBox txtIdPro;
        private Contolesusuario.ErrorTxtBox txtNomPro;
        private Contolesusuario.ErrorTxtBox txtPrecio;
    }
}