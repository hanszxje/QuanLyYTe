namespace QuanLyYTe
{
    partial class FrmChiSoYTe
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
            this.dgvChiSoYTe = new System.Windows.Forms.DataGridView();
            this.MaChiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChieuCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuyetAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhipTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtNgayDo = new System.Windows.Forms.TextBox();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.txtNhipTim = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblMaBenhNhan = new System.Windows.Forms.Label();
            this.lblNgayDo = new System.Windows.Forms.Label();
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.lblHuyetAp = new System.Windows.Forms.Label();
            this.lblNhipTim = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoYTe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiSoYTe
            // 
            this.dgvChiSoYTe.AllowUserToAddRows = false;
            this.dgvChiSoYTe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiSoYTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiSoYTe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiSo,
            this.MaBenhNhan,
            this.NgayDo,
            this.ChieuCao,
            this.CanNang,
            this.HuyetAp,
            this.NhipTim,
            this.GhiChu});
            this.dgvChiSoYTe.Location = new System.Drawing.Point(12, 12);
            this.dgvChiSoYTe.Name = "dgvChiSoYTe";
            this.dgvChiSoYTe.ReadOnly = true;
            this.dgvChiSoYTe.RowHeadersWidth = 51;
            this.dgvChiSoYTe.Size = new System.Drawing.Size(800, 250);
            this.dgvChiSoYTe.TabIndex = 0;
            // 
            // MaChiSo
            // 
            this.MaChiSo.HeaderText = "Mã Chỉ Số";
            this.MaChiSo.MinimumWidth = 6;
            this.MaChiSo.Name = "MaChiSo";
            this.MaChiSo.ReadOnly = true;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.HeaderText = "Mã Bệnh Nhân";
            this.MaBenhNhan.MinimumWidth = 6;
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.ReadOnly = true;
            // 
            // NgayDo
            // 
            this.NgayDo.HeaderText = "Ngày Đo";
            this.NgayDo.MinimumWidth = 6;
            this.NgayDo.Name = "NgayDo";
            this.NgayDo.ReadOnly = true;
            // 
            // ChieuCao
            // 
            this.ChieuCao.HeaderText = "Chiều Cao (cm)";
            this.ChieuCao.MinimumWidth = 6;
            this.ChieuCao.Name = "ChieuCao";
            this.ChieuCao.ReadOnly = true;
            // 
            // CanNang
            // 
            this.CanNang.HeaderText = "Cân Nặng (kg)";
            this.CanNang.MinimumWidth = 6;
            this.CanNang.Name = "CanNang";
            this.CanNang.ReadOnly = true;
            // 
            // HuyetAp
            // 
            this.HuyetAp.HeaderText = "Huyết Áp";
            this.HuyetAp.MinimumWidth = 6;
            this.HuyetAp.Name = "HuyetAp";
            this.HuyetAp.ReadOnly = true;
            // 
            // NhipTim
            // 
            this.NhipTim.HeaderText = "Nhịp Tim";
            this.NhipTim.MinimumWidth = 6;
            this.NhipTim.Name = "NhipTim";
            this.NhipTim.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Location = new System.Drawing.Point(100, 280);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(200, 22);
            this.txtMaBenhNhan.TabIndex = 1;
            // 
            // txtNgayDo
            // 
            this.txtNgayDo.Location = new System.Drawing.Point(100, 310);
            this.txtNgayDo.Name = "txtNgayDo";
            this.txtNgayDo.Size = new System.Drawing.Size(200, 22);
            this.txtNgayDo.TabIndex = 2;
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(100, 340);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(200, 22);
            this.txtChieuCao.TabIndex = 3;
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(100, 370);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(200, 22);
            this.txtCanNang.TabIndex = 4;
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Location = new System.Drawing.Point(100, 400);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(200, 22);
            this.txtHuyetAp.TabIndex = 5;
            // 
            // txtNhipTim
            // 
            this.txtNhipTim.Location = new System.Drawing.Point(100, 430);
            this.txtNhipTim.Name = "txtNhipTim";
            this.txtNhipTim.Size = new System.Drawing.Size(200, 22);
            this.txtNhipTim.TabIndex = 6;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(100, 460);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 22);
            this.txtGhiChu.TabIndex = 7;
            // 
            // lblMaBenhNhan
            // 
            this.lblMaBenhNhan.AutoSize = true;
            this.lblMaBenhNhan.Location = new System.Drawing.Point(20, 283);
            this.lblMaBenhNhan.Name = "lblMaBenhNhan";
            this.lblMaBenhNhan.Size = new System.Drawing.Size(95, 16);
            this.lblMaBenhNhan.TabIndex = 8;
            this.lblMaBenhNhan.Text = "Mã Bệnh Nhân";
            // 
            // lblNgayDo
            // 
            this.lblNgayDo.AutoSize = true;
            this.lblNgayDo.Location = new System.Drawing.Point(20, 313);
            this.lblNgayDo.Name = "lblNgayDo";
            this.lblNgayDo.Size = new System.Drawing.Size(60, 16);
            this.lblNgayDo.TabIndex = 9;
            this.lblNgayDo.Text = "Ngày Đo";
            // 
            // lblChieuCao
            // 
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location = new System.Drawing.Point(20, 343);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Size = new System.Drawing.Size(69, 16);
            this.lblChieuCao.TabIndex = 10;
            this.lblChieuCao.Text = "Chiều Cao";
            // 
            // lblCanNang
            // 
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location = new System.Drawing.Point(20, 373);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Size = new System.Drawing.Size(67, 16);
            this.lblCanNang.TabIndex = 11;
            this.lblCanNang.Text = "Cân Nặng";
            // 
            // lblHuyetAp
            // 
            this.lblHuyetAp.AutoSize = true;
            this.lblHuyetAp.Location = new System.Drawing.Point(20, 403);
            this.lblHuyetAp.Name = "lblHuyetAp";
            this.lblHuyetAp.Size = new System.Drawing.Size(62, 16);
            this.lblHuyetAp.TabIndex = 12;
            this.lblHuyetAp.Text = "Huyết Áp";
            // 
            // lblNhipTim
            // 
            this.lblNhipTim.AutoSize = true;
            this.lblNhipTim.Location = new System.Drawing.Point(20, 433);
            this.lblNhipTim.Name = "lblNhipTim";
            this.lblNhipTim.Size = new System.Drawing.Size(61, 16);
            this.lblNhipTim.TabIndex = 13;
            this.lblNhipTim.Text = "Nhịp Tim";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 463);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(53, 16);
            this.lblGhiChu.TabIndex = 14;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(320, 280);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(320, 310);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(320, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(320, 370);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // FrmChiSoYTe
            // 
            this.ClientSize = new System.Drawing.Size(820, 499);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblNhipTim);
            this.Controls.Add(this.lblHuyetAp);
            this.Controls.Add(this.lblCanNang);
            this.Controls.Add(this.lblChieuCao);
            this.Controls.Add(this.lblNgayDo);
            this.Controls.Add(this.lblMaBenhNhan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtNhipTim);
            this.Controls.Add(this.txtHuyetAp);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.txtChieuCao);
            this.Controls.Add(this.txtNgayDo);
            this.Controls.Add(this.txtMaBenhNhan);
            this.Controls.Add(this.dgvChiSoYTe);
            this.Name = "FrmChiSoYTe";
            this.Text = "Quản Lý Chỉ Số Y Tế Bệnh Nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoYTe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiSoYTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChieuCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuyetAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhipTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.TextBox txtNgayDo;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.TextBox txtNhipTim;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblMaBenhNhan;
        private System.Windows.Forms.Label lblNgayDo;
        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.Label lblHuyetAp;
        private System.Windows.Forms.Label lblNhipTim;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
