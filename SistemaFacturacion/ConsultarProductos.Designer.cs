namespace SistemaFacturacion
{
    partial class ConsultarProductos
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
            SuspendLayout();
            // 
            // button3
            // 
            button3.Click += button3_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(580, 397);
            btnSalir.Size = new Size(148, 23);
            // 
            // ConsultarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "ConsultarProductos";
            Text = "ConsultarProductos";
            Load += ConsultarProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}