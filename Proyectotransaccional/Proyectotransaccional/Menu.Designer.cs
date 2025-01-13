namespace Proyectotransaccional
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(77, 70);
            label1.Name = "label1";
            label1.Size = new Size(148, 24);
            label1.TabIndex = 5;
            label1.Text = "PRODUCTOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(485, 70);
            label5.Name = "label5";
            label5.Size = new Size(116, 24);
            label5.TabIndex = 16;
            label5.Text = "CLIENTES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(58, 198);
            label3.Name = "label3";
            label3.Size = new Size(176, 24);
            label3.TabIndex = 17;
            label3.Text = "VER FACTURAS";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(476, 198);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 18;
            label2.Text = "REPORTES";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(464, 97);
            button1.Name = "button1";
            button1.Size = new Size(157, 51);
            button1.TabIndex = 19;
            button1.Text = "SELECCIONAR";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 43);
            panel1.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(309, 4);
            label9.Name = "label9";
            label9.Size = new Size(96, 39);
            label9.TabIndex = 23;
            label9.Text = "MENÚ";
            label9.Click += label9_Click_1;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(68, 97);
            button2.Name = "button2";
            button2.Size = new Size(157, 51);
            button2.TabIndex = 23;
            button2.Text = "SELECCIONAR";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(68, 225);
            button3.Name = "button3";
            button3.Size = new Size(157, 51);
            button3.TabIndex = 24;
            button3.Text = "SELECCIONAR";
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Bodoni MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(464, 225);
            button4.Name = "button4";
            button4.Size = new Size(157, 51);
            button4.TabIndex = 25;
            button4.Text = "SELECCIONAR";
            button4.UseMnemonic = false;
            button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 353);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label9;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}