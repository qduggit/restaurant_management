namespace QUANLYNHAHANG
{
    partial class fCategory
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
            dgvCategory = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            btnAddC = new Button();
            btnDeleteC = new Button();
            btnFixC = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label10 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtC = new TextBox();
            txtIDC = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            dgvCategory.Location = new Point(21, 22);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 29;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(552, 510);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "DanhMuc";
            Column2.HeaderText = "Category";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // btnAddC
            // 
            btnAddC.Anchor = AnchorStyles.None;
            btnAddC.BackColor = Color.FromArgb(31, 30, 68);
            btnAddC.Cursor = Cursors.Hand;
            btnAddC.FlatStyle = FlatStyle.Popup;
            btnAddC.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddC.ForeColor = Color.White;
            btnAddC.Location = new Point(50, 583);
            btnAddC.Name = "btnAddC";
            btnAddC.Size = new Size(113, 49);
            btnAddC.TabIndex = 16;
            btnAddC.Text = "Thêm";
            btnAddC.UseVisualStyleBackColor = false;
            btnAddC.Click += btnAddC_Click;
            // 
            // btnDeleteC
            // 
            btnDeleteC.Anchor = AnchorStyles.None;
            btnDeleteC.BackColor = Color.FromArgb(31, 30, 68);
            btnDeleteC.Cursor = Cursors.Hand;
            btnDeleteC.FlatStyle = FlatStyle.Popup;
            btnDeleteC.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteC.ForeColor = Color.White;
            btnDeleteC.Location = new Point(235, 583);
            btnDeleteC.Name = "btnDeleteC";
            btnDeleteC.Size = new Size(102, 49);
            btnDeleteC.TabIndex = 17;
            btnDeleteC.Text = "Xoá";
            btnDeleteC.UseVisualStyleBackColor = false;
            btnDeleteC.Click += btnDeleteC_Click;
            // 
            // btnFixC
            // 
            btnFixC.Anchor = AnchorStyles.None;
            btnFixC.BackColor = Color.FromArgb(31, 30, 68);
            btnFixC.Cursor = Cursors.Hand;
            btnFixC.FlatStyle = FlatStyle.Popup;
            btnFixC.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFixC.ForeColor = Color.White;
            btnFixC.Location = new Point(412, 583);
            btnFixC.Name = "btnFixC";
            btnFixC.Size = new Size(103, 49);
            btnFixC.TabIndex = 18;
            btnFixC.Text = "Sửa";
            btnFixC.UseVisualStyleBackColor = false;
            btnFixC.Click += btnFixC_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtC);
            panel1.Controls.Add(txtIDC);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnFixC);
            panel1.Controls.Add(dgvCategory);
            panel1.Controls.Add(btnAddC);
            panel1.Controls.Add(btnDeleteC);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 680);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(665, 219);
            label1.Name = "label1";
            label1.Size = new Size(290, 3);
            label1.TabIndex = 57;
            label1.Text = "label1";
            // 
            // label10
            // 
            label10.BackColor = Color.Black;
            label10.Location = new Point(665, 315);
            label10.Name = "label10";
            label10.Size = new Size(290, 3);
            label10.TabIndex = 56;
            label10.Text = "label10";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.AliceBlue;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(665, 275);
            label3.Name = "label3";
            label3.Size = new Size(82, 37);
            label3.TabIndex = 55;
            label3.Text = "Category";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.AliceBlue;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(654, 179);
            label2.Name = "label2";
            label2.Size = new Size(64, 37);
            label2.TabIndex = 47;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtC
            // 
            txtC.Anchor = AnchorStyles.None;
            txtC.BackColor = Color.AliceBlue;
            txtC.BorderStyle = BorderStyle.None;
            txtC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtC.Location = new Point(753, 275);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(217, 37);
            txtC.TabIndex = 54;
            // 
            // txtIDC
            // 
            txtIDC.Anchor = AnchorStyles.None;
            txtIDC.BackColor = Color.AliceBlue;
            txtIDC.BorderStyle = BorderStyle.None;
            txtIDC.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDC.Location = new Point(738, 179);
            txtIDC.Multiline = true;
            txtIDC.Name = "txtIDC";
            txtIDC.Size = new Size(217, 37);
            txtIDC.TabIndex = 53;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(610, 12);
            label11.Name = "label11";
            label11.Size = new Size(3, 640);
            label11.TabIndex = 52;
            label11.Text = "label11";
            // 
            // fCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 680);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fCategory";
            Text = "Category";
            Load += fCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategory;
        private Button btnAddC;
        private Button btnDeleteC;
        private Button btnFixC;
        private Panel panel1;
        private Label label11;
        private TextBox txtIDC;
        private TextBox txtC;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label10;
    }
}