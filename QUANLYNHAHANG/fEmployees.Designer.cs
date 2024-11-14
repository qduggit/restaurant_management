namespace QUANLYNHAHANG
{
    partial class fEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEmployees));
            btnAddE = new Button();
            btnDeleteE = new Button();
            btnFixE = new Button();
            panel1 = new Panel();
            label11 = new Label();
            dataGridViewEmployees = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Namee = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtPositionE = new TextBox();
            txtSDTE = new TextBox();
            txtAddressE = new TextBox();
            txtNameE = new TextBox();
            txtIDE = new TextBox();
            txtSearchE = new TextBox();
            btnFindE = new Button();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label10 = new Label();
            label4 = new Label();
            label12 = new Label();
            label5 = new Label();
            label6 = new Label();
            label13 = new Label();
            label14 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddE
            // 
            btnAddE.Anchor = AnchorStyles.None;
            btnAddE.BackColor = Color.FromArgb(31, 30, 68);
            btnAddE.Cursor = Cursors.Hand;
            btnAddE.FlatStyle = FlatStyle.Popup;
            btnAddE.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddE.ForeColor = Color.White;
            btnAddE.Location = new Point(48, 598);
            btnAddE.Name = "btnAddE";
            btnAddE.Size = new Size(113, 49);
            btnAddE.TabIndex = 15;
            btnAddE.Text = "Thêm";
            btnAddE.UseVisualStyleBackColor = false;
            btnAddE.Click += btnAddE_Click;
            // 
            // btnDeleteE
            // 
            btnDeleteE.Anchor = AnchorStyles.None;
            btnDeleteE.BackColor = Color.FromArgb(31, 30, 68);
            btnDeleteE.Cursor = Cursors.Hand;
            btnDeleteE.FlatStyle = FlatStyle.Popup;
            btnDeleteE.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteE.ForeColor = Color.White;
            btnDeleteE.Location = new Point(236, 598);
            btnDeleteE.Name = "btnDeleteE";
            btnDeleteE.Size = new Size(102, 49);
            btnDeleteE.TabIndex = 16;
            btnDeleteE.Text = "Xoá";
            btnDeleteE.UseVisualStyleBackColor = false;
            btnDeleteE.Click += btnDeleteE_Click;
            // 
            // btnFixE
            // 
            btnFixE.Anchor = AnchorStyles.None;
            btnFixE.BackColor = Color.FromArgb(31, 30, 68);
            btnFixE.Cursor = Cursors.Hand;
            btnFixE.FlatStyle = FlatStyle.Popup;
            btnFixE.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFixE.ForeColor = Color.White;
            btnFixE.Location = new Point(413, 598);
            btnFixE.Name = "btnFixE";
            btnFixE.Size = new Size(103, 49);
            btnFixE.TabIndex = 17;
            btnFixE.Text = "Sửa";
            btnFixE.UseVisualStyleBackColor = false;
            btnFixE.Click += btnFixE_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dataGridViewEmployees);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(txtPositionE);
            panel1.Controls.Add(txtSDTE);
            panel1.Controls.Add(txtAddressE);
            panel1.Controls.Add(txtNameE);
            panel1.Controls.Add(txtIDE);
            panel1.Controls.Add(txtSearchE);
            panel1.Controls.Add(btnFindE);
            panel1.Controls.Add(btnDeleteE);
            panel1.Controls.Add(btnFixE);
            panel1.Controls.Add(btnAddE);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 680);
            panel1.TabIndex = 18;
            // 
            // label11
            // 
            label11.BackColor = Color.Black;
            label11.Location = new Point(671, 20);
            label11.Name = "label11";
            label11.Size = new Size(3, 640);
            label11.TabIndex = 51;
            label11.Text = "label11";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { ID, Namee, Address, Sex, SDT, Position });
            dataGridViewEmployees.Location = new Point(12, 9);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 29;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(616, 549);
            dataGridViewEmployees.TabIndex = 50;
            dataGridViewEmployees.CellClick += dataGridViewEmployees_CellClick;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Namee
            // 
            Namee.DataPropertyName = "Name";
            Namee.HeaderText = "Name";
            Namee.MinimumWidth = 6;
            Namee.Name = "Namee";
            Namee.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Sex
            // 
            Sex.DataPropertyName = "Sex";
            Sex.HeaderText = "Sex";
            Sex.MinimumWidth = 6;
            Sex.Name = "Sex";
            Sex.Width = 125;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "SDT";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 125;
            // 
            // Position
            // 
            Position.DataPropertyName = "Position";
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(906, 384);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 49;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(789, 384);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 48;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtPositionE
            // 
            txtPositionE.BackColor = Color.AliceBlue;
            txtPositionE.BorderStyle = BorderStyle.None;
            txtPositionE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPositionE.Location = new Point(789, 493);
            txtPositionE.Name = "txtPositionE";
            txtPositionE.Size = new Size(208, 31);
            txtPositionE.TabIndex = 47;
            // 
            // txtSDTE
            // 
            txtSDTE.BackColor = Color.AliceBlue;
            txtSDTE.BorderStyle = BorderStyle.None;
            txtSDTE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDTE.Location = new Point(780, 433);
            txtSDTE.Name = "txtSDTE";
            txtSDTE.Size = new Size(217, 31);
            txtSDTE.TabIndex = 46;
            // 
            // txtAddressE
            // 
            txtAddressE.BackColor = Color.AliceBlue;
            txtAddressE.BorderStyle = BorderStyle.None;
            txtAddressE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddressE.Location = new Point(780, 317);
            txtAddressE.Name = "txtAddressE";
            txtAddressE.Size = new Size(217, 31);
            txtAddressE.TabIndex = 44;
            // 
            // txtNameE
            // 
            txtNameE.BackColor = Color.AliceBlue;
            txtNameE.BorderStyle = BorderStyle.None;
            txtNameE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameE.Location = new Point(780, 256);
            txtNameE.Name = "txtNameE";
            txtNameE.Size = new Size(217, 31);
            txtNameE.TabIndex = 43;
            // 
            // txtIDE
            // 
            txtIDE.BackColor = Color.AliceBlue;
            txtIDE.BorderStyle = BorderStyle.None;
            txtIDE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDE.Location = new Point(780, 190);
            txtIDE.Name = "txtIDE";
            txtIDE.Size = new Size(217, 31);
            txtIDE.TabIndex = 42;
            // 
            // txtSearchE
            // 
            txtSearchE.Anchor = AnchorStyles.None;
            txtSearchE.BackColor = Color.AliceBlue;
            txtSearchE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchE.Location = new Point(697, 89);
            txtSearchE.Multiline = true;
            txtSearchE.Name = "txtSearchE";
            txtSearchE.Size = new Size(173, 37);
            txtSearchE.TabIndex = 41;
            txtSearchE.TextChanged += txtSearchE_TextChanged;
            // 
            // btnFindE
            // 
            btnFindE.BackColor = Color.FromArgb(31, 30, 68);
            btnFindE.Cursor = Cursors.Hand;
            btnFindE.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindE.ForeColor = Color.White;
            btnFindE.Location = new Point(876, 72);
            btnFindE.Name = "btnFindE";
            btnFindE.Size = new Size(130, 54);
            btnFindE.TabIndex = 40;
            btnFindE.Text = "Tìm kiếm";
            btnFindE.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = Color.AliceBlue;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(697, 184);
            label8.Name = "label8";
            label8.Size = new Size(77, 37);
            label8.TabIndex = 34;
            label8.Text = "ID";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(697, 221);
            label1.Name = "label1";
            label1.Size = new Size(300, 3);
            label1.TabIndex = 53;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(697, 290);
            label2.Name = "label2";
            label2.Size = new Size(300, 3);
            label2.TabIndex = 54;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(697, 351);
            label3.Name = "label3";
            label3.Size = new Size(300, 3);
            label3.TabIndex = 55;
            label3.Text = "label3";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.BackColor = Color.AliceBlue;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(697, 253);
            label10.Name = "label10";
            label10.Size = new Size(77, 37);
            label10.TabIndex = 56;
            label10.Text = "Name";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.AliceBlue;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(697, 314);
            label4.Name = "label4";
            label4.Size = new Size(77, 37);
            label4.TabIndex = 57;
            label4.Text = "Address";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.BackColor = Color.AliceBlue;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(697, 371);
            label12.Name = "label12";
            label12.Size = new Size(77, 37);
            label12.TabIndex = 58;
            label12.Text = "Sex";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Location = new Point(697, 461);
            label5.Name = "label5";
            label5.Size = new Size(300, 3);
            label5.TabIndex = 59;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.BackColor = Color.Black;
            label6.Location = new Point(697, 527);
            label6.Name = "label6";
            label6.Size = new Size(300, 3);
            label6.TabIndex = 60;
            label6.Text = "label6";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.BackColor = Color.AliceBlue;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(697, 424);
            label13.Name = "label13";
            label13.Size = new Size(77, 37);
            label13.TabIndex = 61;
            label13.Text = "SDT";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.BackColor = Color.AliceBlue;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(697, 490);
            label14.Name = "label14";
            label14.Size = new Size(77, 37);
            label14.TabIndex = 62;
            label14.Text = "Position";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.AliceBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(798, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.AliceBlue;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(697, 9);
            label7.Name = "label7";
            label7.Size = new Size(85, 37);
            label7.TabIndex = 64;
            label7.Text = "Employee";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 680);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fEmployees";
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddE;
        private Button btnDeleteE;
        private Button btnFixE;
        private Panel panel1;
        private TextBox txtIDE;
        private TextBox txtSearchE;
        private Button btnFindE;
        private TextBox txtAddressE;
        private TextBox txtNameE;
        private TextBox txtPositionE;
        private TextBox txtSDTE;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Namee;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn Position;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label4;
        private Label label10;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
    }
}