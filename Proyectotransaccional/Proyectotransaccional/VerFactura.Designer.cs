namespace Proyectotransaccional
{
    partial class VerFactura
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(549, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 23);
            textBox3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(7, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 124);
            panel1.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(542, 14);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 3;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(105, 85);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(108, 51);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 14);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 23);
            textBox4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(8, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 235);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Producto, Cantidad, Precio, Total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(7, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(765, 222);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 75;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 380;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 75;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 75;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(443, 19);
            label8.Name = "label8";
            label8.Size = new Size(84, 18);
            label8.TabIndex = 8;
            label8.Text = "Cédula/Ruc:";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(485, 16);
            label7.Name = "label7";
            label7.Size = new Size(49, 18);
            label7.TabIndex = 9;
            label7.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 10;
            label2.Text = "N° de Factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 11;
            label1.Text = "Empresa:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 86);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 12;
            label3.Text = "Teléfono:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 56);
            label9.Name = "label9";
            label9.Size = new Size(73, 18);
            label9.TabIndex = 13;
            label9.Text = "Dirección:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(46, 20);
            label10.Name = "label10";
            label10.Size = new Size(56, 18);
            label10.TabIndex = 14;
            label10.Text = "Cliente:";
            // 
            // VerFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "VerFactura";
            Text = "VerFactura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Label label8;
        private Label label2;
        private Label label7;
        private Label label1;
        private Label label3;
        private Label label9;
        private Label label10;
    }
}