namespace DeThiThu2
{
    partial class Form1
    { /// <summary>
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cbChucVu = new ComboBox();
            radntnNu = new RadioButton();
            radbtnNam = new RadioButton();
            txtSdt = new TextBox();
            txtName = new TextBox();
            groupBox2 = new GroupBox();
            dgvNv = new DataGridView();
            txtTimKiem = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnXoaForm = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNv).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 129);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Giới tính ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 176);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbChucVu);
            groupBox1.Controls.Add(radntnNu);
            groupBox1.Controls.Add(radbtnNam);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 215);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // cbChucVu
            // 
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(88, 168);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(158, 23);
            cbChucVu.TabIndex = 8;
            // 
            // radntnNu
            // 
            radntnNu.AutoSize = true;
            radntnNu.Location = new Point(188, 125);
            radntnNu.Name = "radntnNu";
            radntnNu.Size = new Size(41, 19);
            radntnNu.TabIndex = 7;
            radntnNu.TabStop = true;
            radntnNu.Text = "Nữ";
            radntnNu.UseVisualStyleBackColor = true;
            // 
            // radbtnNam
            // 
            radbtnNam.AutoSize = true;
            radbtnNam.Location = new Point(88, 125);
            radbtnNam.Name = "radbtnNam";
            radbtnNam.Size = new Size(51, 19);
            radbtnNam.TabIndex = 6;
            radbtnNam.TabStop = true;
            radbtnNam.Text = "Nam";
            radbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(88, 72);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(158, 23);
            txtSdt.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 23);
            txtName.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNv);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(650, 243);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dgvNv
            // 
            dgvNv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNv.Location = new Point(6, 68);
            dgvNv.Name = "dgvNv";
            dgvNv.RowTemplate.Height = 25;
            dgvNv.Size = new Size(638, 169);
            dgvNv.TabIndex = 2;
            dgvNv.CellMouseClick += dgvNv_CellMouseClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(174, 28);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(331, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 36);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaForm);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(338, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 215);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng ";
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(64, 163);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(197, 31);
            btnXoaForm.TabIndex = 3;
            btnXoaForm.Text = "Xóa form ";
            btnXoaForm.UseVisualStyleBackColor = true;
            btnXoaForm.Click += btnXoaForm_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(64, 113);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(197, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Hiển thị ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(64, 64);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(197, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(64, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(197, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 518);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "QuanLyNhanVien";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNv).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox cbChucVu;
        private RadioButton radntnNu;
        private RadioButton radbtnNam;
        private TextBox txtSdt;
        private TextBox txtName;
        private GroupBox groupBox2;
        private DataGridView dgvNv;
        private TextBox txtTimKiem;
        private Label label5;
        private GroupBox groupBox3;
        private Button btnXoaForm;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}