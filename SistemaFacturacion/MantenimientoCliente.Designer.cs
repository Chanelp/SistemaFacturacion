namespace SistemaFacturacion
{
    partial class MantenimientoCliente
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
            txtApeCli = new TextBox();
            txtNomCli = new TextBox();
            txtIdCli = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(434, 30);
            // 
            // button2
            // 
            button2.Location = new Point(434, 75);
            // 
            // button3
            // 
            button3.Location = new Point(434, 122);
            // 
            // button4
            // 
            button4.Location = new Point(434, 168);
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(434, 214);
            // 
            // txtApeCli
            // 
            txtApeCli.Location = new Point(161, 186);
            txtApeCli.Name = "txtApeCli";
            txtApeCli.Size = new Size(162, 23);
            txtApeCli.TabIndex = 16;
            // 
            // txtNomCli
            // 
            txtNomCli.Location = new Point(161, 126);
            txtNomCli.Name = "txtNomCli";
            txtNomCli.Size = new Size(162, 23);
            txtNomCli.TabIndex = 15;
            // 
            // txtIdCli
            // 
            txtIdCli.Location = new Point(161, 67);
            txtIdCli.Name = "txtIdCli";
            txtIdCli.Size = new Size(162, 23);
            txtIdCli.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 188);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 13;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 128);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 11;
            label1.Text = "ID_Cliente:";
            // 
            // MantenimientoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 276);
            Controls.Add(txtApeCli);
            Controls.Add(txtNomCli);
            Controls.Add(txtIdCli);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MantenimientoCliente";
            Text = "MantenimientoCliente";
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtIdCli, 0);
            Controls.SetChildIndex(txtNomCli, 0);
            Controls.SetChildIndex(txtApeCli, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApeCli;
        private TextBox txtNomCli;
        private TextBox txtIdCli;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}