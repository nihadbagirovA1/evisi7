namespace evisi7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colCount = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            btnSatis = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblGelir = new Label();
            btnCixis = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colCount, colPrice, colTotal });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1113, 400);
            dataGridView1.TabIndex = 4;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 160F;
            colName.HeaderText = "Gül növü (gül adı)";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCount
            // 
            colCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCount.HeaderText = "Satış sayı";
            colCount.MinimumWidth = 6;
            colCount.Name = "colCount";
            colCount.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrice.HeaderText = "Qiyməti";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotal.HeaderText = "Yekun qiyməti";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(btnSatis);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(17, 440);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(503, 360);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gül məlumatları";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 73);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Gül növü";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox1.Location = new Point(46, 120);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 32);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 187);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 1;
            label2.Text = "Say";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox2.Location = new Point(46, 233);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 32);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 187);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "Qiymət";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBox3.Location = new Point(194, 233);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(91, 32);
            textBox3.TabIndex = 2;
            // 
            // btnSatis
            // 
            btnSatis.BackColor = Color.Maroon;
            btnSatis.FlatStyle = FlatStyle.Flat;
            btnSatis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSatis.ForeColor = Color.White;
            btnSatis.Location = new Point(331, 207);
            btnSatis.Margin = new Padding(3, 4, 3, 4);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(126, 73);
            btnSatis.TabIndex = 3;
            btnSatis.Text = "Satış et";
            btnSatis.UseVisualStyleBackColor = false;
            btnSatis.Click += btnSatis_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(640, 453);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 8;
            label4.Text = "Toplam gəlir:";
            // 
            // lblGelir
            // 
            lblGelir.AutoSize = true;
            lblGelir.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblGelir.ForeColor = Color.White;
            lblGelir.Location = new Point(800, 453);
            lblGelir.Name = "lblGelir";
            lblGelir.Size = new Size(58, 30);
            lblGelir.TabIndex = 7;
            lblGelir.Text = "0.00";
            // 
            // btnCixis
            // 
            btnCixis.BackColor = Color.Bisque;
            btnCixis.FlatStyle = FlatStyle.Flat;
            btnCixis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCixis.Location = new Point(829, 707);
            btnCixis.Margin = new Padding(3, 4, 3, 4);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(86, 37);
            btnCixis.TabIndex = 5;
            btnCixis.Text = "Çıxış";
            btnCixis.UseVisualStyleBackColor = false;
            btnCixis.Click += btnCixis_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(766, 533);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 267);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1113, 875);
            Controls.Add(btnCixis);
            Controls.Add(pictureBox2);
            Controls.Add(lblGelir);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gül satışı";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Button btnCixis;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}