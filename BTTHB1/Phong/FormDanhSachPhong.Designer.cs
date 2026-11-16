namespace HotelManagement.Phong
{
    partial class FormDanhSachPhong
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
            txtTimKiem = new TextBox();
            btnXuatExcel = new Button();
            btnThemMoiPhong = new Button();
            dtgDanhSachPhong = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(55, 22);
            txtTimKiem.Margin = new Padding(3, 5, 3, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(433, 32);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DeepSkyBlue;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(538, 15);
            btnXuatExcel.Margin = new Padding(3, 5, 3, 5);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 46);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThemMoiPhong
            // 
            btnThemMoiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoiPhong.BackColor = Color.SeaGreen;
            btnThemMoiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoiPhong.Location = new Point(791, 15);
            btnThemMoiPhong.Margin = new Padding(3, 5, 3, 5);
            btnThemMoiPhong.Name = "btnThemMoiPhong";
            btnThemMoiPhong.Size = new Size(188, 46);
            btnThemMoiPhong.TabIndex = 3;
            btnThemMoiPhong.Text = "Thêm mới phòng";
            btnThemMoiPhong.UseVisualStyleBackColor = false;
            btnThemMoiPhong.Click += btnThemMoiPhong_Click;
            // 
            // dtgDanhSachPhong
            // 
            dtgDanhSachPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachPhong.BackgroundColor = Color.White;
            dtgDanhSachPhong.BorderStyle = BorderStyle.None;
            dtgDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhong.Location = new Point(0, 75);
            dtgDanhSachPhong.Margin = new Padding(3, 5, 3, 5);
            dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            dtgDanhSachPhong.RowHeadersWidth = 51;
            dtgDanhSachPhong.RowTemplate.Height = 24;
            dtgDanhSachPhong.Size = new Size(1039, 799);
            dtgDanhSachPhong.TabIndex = 4;
            dtgDanhSachPhong.CellClick += dtgDanhSachPhong_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 874);
            Controls.Add(dtgDanhSachPhong);
            Controls.Add(btnThemMoiPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormDanhSachPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin phòng";
            Load += FormDanhSachPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThemMoiPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhong;
    }
}
