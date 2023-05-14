namespace SistemaFacturacion
{
    partial class Mantenimiento
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(645, 244);
            btnSalir.Size = new Size(129, 23);
            // 
            // button1
            // 
            button1.Location = new Point(645, 60);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 1;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(645, 105);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 2;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(645, 152);
            button3.Name = "button3";
            button3.Size = new Size(129, 23);
            button3.TabIndex = 3;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(645, 198);
            button4.Name = "button4";
            button4.Size = new Size(129, 23);
            button4.TabIndex = 4;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 392);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public ErrorProvider errorProvider1;
    }
}