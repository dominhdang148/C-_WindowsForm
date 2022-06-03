using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BT_QLSV
{
    public partial class Form1 : Form
    {
        public List<SinhVien> _dsSinhVien = new List<SinhVien>();
        public List<Lop> _dsLop = new List<Lop>();
        public string connectionString;
        public string DefaultSearchText = "Nhập họ tên của sinh viên";
        public Form1()
        {
            InitializeComponent();
        }
        private void GetAllLop()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "Select * from Lop";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("Lop");
            conn.Open();
            adapter.Fill(table);

            conn.Close();

            foreach (DataRow row in table.Rows)
            {
                _dsLop.Add(new Lop(row));
            }

            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "ID";
            cbLop.DataSource = _dsLop;
        }
        private void GetAllSinhVien()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "Select * from SinhVien";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("SinhVien");

            conn.Open();
            adapter.Fill(table);

            conn.Close();
            _dsSinhVien = new List<SinhVien>();
            foreach (DataRow row in table.Rows)
            {
                _dsSinhVien.Add(new SinhVien(row));
            }
        }
        private void AddSVToLV(SinhVien sv)
        {
            string[] row = { sv.ID.ToString(), sv.HoTen, sv.LopID.ToString() };
            var item = new ListViewItem(row);
            lvSV.Items.Add(item);
        }
        private void LoadListView(List<SinhVien> ds)
        {
            lvSV.Items.Clear();
            foreach (var sinhvien in ds)
            {
                AddSVToLV(sinhvien);
            }
        }
        private SinhVien GetSinhVien()
        {
            var sv = new SinhVien() ;
            if (!string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                sv.HoTen = txtHoTen.Text;
                sv.ID = string.IsNullOrWhiteSpace(txtID.Text) ? -1 : int.Parse(txtID.Text);
                sv.LopID = Convert.ToInt32(cbLop.SelectedValue);
            }
            else
            {
                sv = null;
            }
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            txtHoTen.Text = sv.HoTen;
            txtID.Text = sv.ID.ToString();
            cbLop.SelectedValue = sv.LopID;
        }
        private void SetSearchText()
        {
            txtSearch.Text = DefaultSearchText;
            txtSearch.LostFocus += TxtSearchOnLostFocus;
            txtSearch.GotFocus += TxtSearchOnGotFocus;

        }
        private void TxtSearchOnLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = DefaultSearchText;
                btnTaiLai.PerformClick();
            }
        }
        private void TxtSearchOnGotFocus(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this._dsLop = new List<Lop>();
            this._dsSinhVien = new List<SinhVien>();
            this.connectionString = @"Data Source=DESKTOP-D79P76S\DOMINHDANG;Initial Catalog=QLSinhVien;Integrated Security=True";
            SetSearchText();
            GetAllLop();
            GetAllSinhVien();
            LoadListView(_dsSinhVien);
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            GetAllSinhVien();
            LoadListView(_dsSinhVien);
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count > 0)
            {
                var id = int.Parse(lvSV.SelectedItems[0].Text);
                var sinhvien = _dsSinhVien.FirstOrDefault(sv => sv.ID == id);
                ThietLapThongTin(sinhvien);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var list = _dsSinhVien.Where(sv => sv.HoTen.IndexOf(txtSearch.Text, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();
            LoadListView(list);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtHoTen.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var sv = GetSinhVien();
            if (sv == null)
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();

            if (sv.ID < 0)
                command.CommandText = "exec InsertStudent @HoTen, @MaLop";
            else
            {
                command.CommandText = "Update SinhVien Set HoTen = @HoTen, MaLop=@MaLop Where id=@ID";
            }
            command.Parameters.AddWithValue("@HoTen", sv.HoTen);
            command.Parameters.AddWithValue("@MaLop", sv.LopID);
            command.Parameters.AddWithValue("@Id", sv.ID);

            conn.Open();
            var num = command.ExecuteNonQuery();
            if(num>0)
            {
                btnTaiLai.PerformClick();
            }
            conn.Close();
        }
    }
}
