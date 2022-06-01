using System;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmQuanLySV : Form
    {
        QuanLySinhVien qlsv;
        public frmQuanLySV()
        {
            InitializeComponent();
        }

        #region Phương thức bổ trợ

        // Lấy thông tim từ controls Thông tin sinh viên
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            sv.maSo = this.mtxtMSSV.Text;
            sv.hoTen = this.txtHoTen.Text;
            sv.email = this.txtEmail.Text;
            if (rdNu.Checked)
                gt = false;
            sv.gioiTinh = gt;
            sv.ngaySinh = this.dtpNgSinh.Value;
            sv.hinh = this.txtHinh.Text;
            sv.lop = this.cbLop.Text;
            sv.diaChi = this.txtDiaChi.Text;
            sv.soDT = this.mtxtSDT.Text;
            return sv;
        }

        // Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.maSo = lvitem.SubItems[0].Text;
            sv.hoTen = lvitem.SubItems[1].Text;
            sv.gioiTinh = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.gioiTinh = true;
            sv.ngaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.lop = lvitem.SubItems[4].Text;
            sv.soDT = lvitem.SubItems[5].Text;
            sv.email = lvitem.SubItems[6].Text;
            sv.diaChi = lvitem.SubItems[7].Text;
            sv.hinh = lvitem.SubItems[8].Text;
            return sv;
        }
        // Thiết lập thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.maSo;
            this.txtHoTen.Text = sv.hoTen;
            this.txtEmail.Text = sv.email;
            this.txtDiaChi.Text = sv.diaChi;
            this.txtHinh.Text = sv.hinh;
            this.pbHinh.ImageLocation = sv.hinh;
            this.dtpNgSinh.Value = sv.ngaySinh;
            if (sv.gioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.cbLop.Text = sv.lop;
            this.mtxtSDT.Text = sv.soDT;

        }
        // Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.maSo);
            lvitem.SubItems.Add(sv.hoTen);
            string gt = "Nữ";
            if (sv.gioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.ngaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.lop);
            lvitem.SubItems.Add(sv.soDT);
            lvitem.SubItems.Add(sv.email);
            lvitem.SubItems.Add(sv.diaChi);
            lvitem.SubItems.Add(sv.hinh);
            this.lvDanhSachSV.Items.Add(lvitem);
        }

        // Hiển thị các sinh viên trong qlsv lên ListView
        public void LoadListView()
        {
            this.lvDanhSachSV.Items.Clear();
            foreach (SinhVien sv in qlsv.dssv)
            {
                ThemSV(sv);
            }
        }
        
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.maSo.CompareTo(obj1);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDanhSachSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDanhSachSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = this.txtHinh.Text;
            this.dtpNgSinh.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.cbLop.Text = "";
            this.mtxtSDT.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.maSo, delegate (object obj1, object obj2)
               {
                   return (obj2 as SinhVien).maSo.CompareTo(obj1.ToString());
               });
            if (kq != null)
            {
                bool kqsua;
                kqsua = qlsv.Sua(sv, sv.maSo, SoSanhTheoMa);
                if (kqsua)
                {
                    this.LoadListView();
                }
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvDanhSachSV.Items.Count - 1;
            for(i=count;i>=0;i--)
            {
                lvitem = this.lvDanhSachSV.Items[i];
                if (lvitem.Checked)
                {
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
                }
            }
            this.LoadListView();
            this.btnMacDinh_Click(sender, e);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(this.ofdChonHinh.ShowDialog()==DialogResult.OK)
            {
                this.txtHinh.Text = this.ofdChonHinh.FileName;
            }
        }
    }
}
