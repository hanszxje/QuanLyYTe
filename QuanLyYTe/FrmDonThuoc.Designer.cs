namespace QuanLyYTe
{
    partial class FrmDonThuoc
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
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.MaDonThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKeDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.txtNgayKeDon = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.lblNgayKeDon = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonThuoc,
            this.MaBenhNhan,
            this.MaBacSi,
            this.NgayKeDon,
            this.GhiChu});
            this.dgvDonThuoc.Location = new System.Drawing.Point(12, 12);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.RowHeadersWidth = 51;
            this.dgvDonThuoc.Size = new System.Drawing.Size(600, 250);
            this.dgvDonThuoc.TabIndex = 0;
            // 
            // MaDonThuoc
            // 
            this.MaDonThuoc.HeaderText = "Mã Đơn Thuốc";
            this.MaDonThuoc.MinimumWidth = 6;
            this.MaDonThuoc.Name = "MaDonThuoc";
            this.MaDonThuoc.ReadOnly = true;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.HeaderText = "Mã Bệnh Nhân";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            // 
            // MaBacSi
            // 
            this.MaBacSi.HeaderText = "Mã Bác Sĩ";
            this.MaBacSi.MinimumWidth = 6;
            this.MaBacSi.Name = "MaBacSi";
            // 
            // NgayKeDon
            // 
            this.NgayKeDon.HeaderText = "Ngày Kê Đơn";
            this.NgayKeDon.MinimumWidth = 6;
            this.NgayKeDon.Name = "NgayKeDon";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Location = new System.Drawing.Point(100, 280);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(200, 22);
            this.txtMaBenhNhan.TabIndex = 1;
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.Location = new System.Drawing.Point(100, 310);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(200, 22);
            this.txtMaBacSi.TabIndex = 2;
            // 
            // txtNgayKeDon
            // 
            this.txtNgayKeDon.Location = new System.Drawing.Point(100, 340);
            this.txtNgayKeDon.Name = "txtNgayKeDon";
            this.txtNgayKeDon.Size = new System.Drawing.Size(200, 22);
            this.txtNgayKeDon.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(100, 370);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 22);
            this.txtGhiChu.TabIndex = 4;
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(20, 283);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(95, 16);
            this.lblMaBenhNhan.TabIndex = 5;
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân";
            // 
            // lblMaBacSi
            // 
            this.lblMaBacSi.AutoSize = true;
            this.lblMaBacSi.Location = new System.Drawing.Point(20, 313);
            this.lblMaBacSi.Name = "lblMaBacSi";
            this.lblMaBacSi.Size = new System.Drawing.Size(70, 16);
            this.lblMaBacSi.TabIndex = 6;
            this.lblMaBacSi.Text = "Mã Bác Sĩ";
            // 
            // lblNgayKeDon
            // 
            this.lblNgayKeDon.AutoSize = true;
            this.lblNgayKeDon.Location = new System.Drawing.Point(20, 343);
            this.lblNgayKeDon.Name = "lblNgayKeDon";
            this.lblNgayKeDon.Size = new System.Drawing.Size(86, 16);
            this.lblNgayKeDon.TabIndex = 7;
            this.lblNgayKeDon.Text = "Ngày Kê Đơn";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 373);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(53, 16);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(320, 280);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(320, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(320, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(320, 370);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // FrmDonThuoc
            // 
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblNgayKeDon);
            this.Controls.Add(this.lblMaBacSi);
            this.Controls.Add(this.lblMaBenhNhan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtNgayKeDon);
            this.Controls.Add(this.txtMaBacSi);
            this.Controls.Add(this.txtMaBenhNhan);
            this.Controls.Add(this.dgvDonThuoc);
            this.Name = "FrmDonThuoc";
            this.Text = "Quản Lý Đơn Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKeDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.TextBox txtNgayKeDon;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.Label lblMaBacSi;
        private System.Windows.Forms.Label lblNgayKeDon;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
