namespace Proyectotransaccional
{
    partial class Anulación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anulación));
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(154, 16);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE DEL CLIENTE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(163, 16);
            label2.TabIndex = 1;
            label2.Text = "CÉDULA DE IDENTIDAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poor Richard", 9.75F, FontStyle.Bold);
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(154, 16);
            label6.TabIndex = 5;
            label6.Text = "NÚMERO DE FACTURA:";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(181, 201);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 6;
            button1.Text = "PROCESAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 27);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 7;
            label3.Text = "ANULACIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(181, 76);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 8;
            label4.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(181, 120);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 9;
            label5.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(181, 161);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 10;
            label7.Text = "-";
            // 
            // Anulación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(493, 251);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Anulación";
            Text = "Anulación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
    }
}