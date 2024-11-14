namespace QUANLYNHAHANG
{
    partial class fOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrder));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnThanhToan = new Button();
            txtTongTien = new TextBox();
            label11 = new Label();
            btnThemmon = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            numericUpDown1 = new NumericUpDown();
            cbxOrder1 = new ComboBox();
            comboBoxFooodd = new ComboBox();
            flowLayoutPanelTables = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnThanhToan);
            panel1.Controls.Add(txtTongTien);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnThemmon);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(cbxOrder1);
            panel1.Controls.Add(comboBoxFooodd);
            panel1.Controls.Add(flowLayoutPanelTables);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 680);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.AliceBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(688, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 44);
            label1.TabIndex = 46;
            label1.Text = "Order";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.AliceBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(616, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(31, 30, 68);
            btnThanhToan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(875, 571);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(122, 82);
            btnThanhToan.TabIndex = 23;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.ForeColor = Color.Red;
            txtTongTien.Location = new Point(738, 598);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(131, 30);
            txtTongTien.TabIndex = 22;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(517, 6);
            label11.Name = "label11";
            label11.Size = new Size(3, 620);
            label11.TabIndex = 21;
            label11.Text = "label11";
            // 
            // btnThemmon
            // 
            btnThemmon.BackColor = Color.FromArgb(31, 30, 68);
            btnThemmon.FlatStyle = FlatStyle.Flat;
            btnThemmon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemmon.ForeColor = Color.White;
            btnThemmon.Location = new Point(871, 87);
            btnThemmon.Name = "btnThemmon";
            btnThemmon.Size = new Size(108, 59);
            btnThemmon.TabIndex = 5;
            btnThemmon.Text = "Thêm món";
            btnThemmon.UseVisualStyleBackColor = false;
            btnThemmon.Click += btnThemmon_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Location = new Point(526, 152);
            listView1.Name = "listView1";
            listView1.Size = new Size(471, 396);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "FoodName";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Count";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 120;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(777, 87);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxOrder1
            // 
            cbxOrder1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrder1.FormattingEnabled = true;
            cbxOrder1.Location = new Point(571, 599);
            cbxOrder1.Name = "cbxOrder1";
            cbxOrder1.Size = new Size(120, 28);
            cbxOrder1.TabIndex = 2;
            // 
            // comboBoxFooodd
            // 
            comboBoxFooodd.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFooodd.FormattingEnabled = true;
            comboBoxFooodd.Location = new Point(550, 87);
            comboBoxFooodd.Name = "comboBoxFooodd";
            comboBoxFooodd.Size = new Size(202, 28);
            comboBoxFooodd.TabIndex = 1;
            // 
            // flowLayoutPanelTables
            // 
            flowLayoutPanelTables.AutoScroll = true;
            flowLayoutPanelTables.Dock = DockStyle.Fill;
            flowLayoutPanelTables.Location = new Point(0, 0);
            flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            flowLayoutPanelTables.Size = new Size(1009, 680);
            flowLayoutPanelTables.TabIndex = 0;
            // 
            // fOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 680);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fOrder";
            Text = "fOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanelTables;
        private ComboBox cbxOrder1;
        private ComboBox comboBoxFooodd;
        private NumericUpDown numericUpDown1;
        private ListView listView1;
        private Button btnThemmon;
        private Label label11;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnThanhToan;
        private TextBox txtTongTien;
        private PictureBox pictureBox2;
        private Label label1;
    }
}