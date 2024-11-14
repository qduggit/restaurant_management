namespace QUANLYNHAHANG
{
    partial class fTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTables));
            dataGridViewTables = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnAddT = new Button();
            btnDeleteT = new Button();
            btnFixT = new Button();
            txtIDT = new TextBox();
            txtNameT = new TextBox();
            txtStatusT = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewTables.Location = new Point(12, 9);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowHeadersWidth = 51;
            dataGridViewTables.RowTemplate.Height = 29;
            dataGridViewTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTables.Size = new Size(561, 557);
            dataGridViewTables.TabIndex = 39;
            dataGridViewTables.CellClick += dataGridViewTables_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Status";
            Column3.HeaderText = "Trạng Thái";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 170;
            // 
            // btnAddT
            // 
            btnAddT.BackColor = Color.FromArgb(31, 30, 68);
            btnAddT.FlatStyle = FlatStyle.Popup;
            btnAddT.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddT.ForeColor = Color.White;
            btnAddT.Location = new Point(45, 593);
            btnAddT.Name = "btnAddT";
            btnAddT.Size = new Size(109, 47);
            btnAddT.TabIndex = 40;
            btnAddT.Text = "Thêm";
            btnAddT.UseVisualStyleBackColor = false;
            btnAddT.Click += btnAddT_Click;
            // 
            // btnDeleteT
            // 
            btnDeleteT.BackColor = Color.FromArgb(31, 30, 68);
            btnDeleteT.FlatStyle = FlatStyle.Popup;
            btnDeleteT.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteT.ForeColor = Color.White;
            btnDeleteT.Location = new Point(233, 593);
            btnDeleteT.Name = "btnDeleteT";
            btnDeleteT.Size = new Size(108, 47);
            btnDeleteT.TabIndex = 41;
            btnDeleteT.Text = "Xoá";
            btnDeleteT.UseVisualStyleBackColor = false;
            btnDeleteT.Click += btnDeleteT_Click;
            // 
            // btnFixT
            // 
            btnFixT.BackColor = Color.FromArgb(31, 30, 68);
            btnFixT.FlatStyle = FlatStyle.Popup;
            btnFixT.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFixT.ForeColor = Color.White;
            btnFixT.Location = new Point(420, 593);
            btnFixT.Name = "btnFixT";
            btnFixT.Size = new Size(111, 47);
            btnFixT.TabIndex = 42;
            btnFixT.Text = "Sửa";
            btnFixT.UseVisualStyleBackColor = false;
            btnFixT.Click += btnFixT_Click;
            // 
            // txtIDT
            // 
            txtIDT.Anchor = AnchorStyles.None;
            txtIDT.BackColor = Color.AliceBlue;
            txtIDT.BorderStyle = BorderStyle.None;
            txtIDT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDT.Location = new Point(766, 133);
            txtIDT.Multiline = true;
            txtIDT.Name = "txtIDT";
            txtIDT.Size = new Size(220, 41);
            txtIDT.TabIndex = 43;
            // 
            // txtNameT
            // 
            txtNameT.Anchor = AnchorStyles.None;
            txtNameT.BackColor = Color.AliceBlue;
            txtNameT.BorderStyle = BorderStyle.None;
            txtNameT.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameT.Location = new Point(766, 220);
            txtNameT.Multiline = true;
            txtNameT.Name = "txtNameT";
            txtNameT.Size = new Size(220, 34);
            txtNameT.TabIndex = 44;
            // 
            // txtStatusT
            // 
            txtStatusT.Anchor = AnchorStyles.None;
            txtStatusT.BackColor = Color.AliceBlue;
            txtStatusT.BorderStyle = BorderStyle.None;
            txtStatusT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatusT.Location = new Point(766, 295);
            txtStatusT.Multiline = true;
            txtStatusT.Name = "txtStatusT";
            txtStatusT.ReadOnly = true;
            txtStatusT.Size = new Size(220, 41);
            txtStatusT.TabIndex = 45;
            txtStatusT.Text = "Trống";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtNameT);
            panel1.Controls.Add(btnAddT);
            panel1.Controls.Add(btnDeleteT);
            panel1.Controls.Add(btnFixT);
            panel1.Controls.Add(txtIDT);
            panel1.Controls.Add(txtStatusT);
            panel1.Controls.Add(dataGridViewTables);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 680);
            panel1.TabIndex = 46;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(676, 177);
            label2.Name = "label2";
            label2.Size = new Size(330, 3);
            label2.TabIndex = 54;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(676, 256);
            label1.Name = "label1";
            label1.Size = new Size(330, 3);
            label1.TabIndex = 53;
            label1.Text = "label1";
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(679, 333);
            label4.Name = "label4";
            label4.Size = new Size(330, 3);
            label4.TabIndex = 52;
            label4.Text = "label4";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.AliceBlue;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(678, 296);
            label6.Name = "label6";
            label6.Size = new Size(64, 37);
            label6.TabIndex = 51;
            label6.Text = "Status";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = Color.AliceBlue;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(676, 219);
            label5.Name = "label5";
            label5.Size = new Size(64, 37);
            label5.TabIndex = 50;
            label5.Text = "Name";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.AliceBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(676, 140);
            label3.Name = "label3";
            label3.Size = new Size(64, 37);
            label3.TabIndex = 49;
            label3.Text = "ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.AliceBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(748, 12);
            label7.Name = "label7";
            label7.Size = new Size(64, 37);
            label7.TabIndex = 48;
            label7.Text = "Table";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(632, 9);
            label11.Name = "label11";
            label11.Size = new Size(3, 620);
            label11.TabIndex = 46;
            label11.Text = "label11";
            // 
            // fTables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 680);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fTables";
            Text = "Form1";
            Load += Tables_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTables;
        private Button btnAddT;
        private Button btnDeleteT;
        private Button btnFixT;
        private TextBox txtIDT;
        private TextBox txtNameT;
        private TextBox txtStatusT;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label11;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label7;
    }
}