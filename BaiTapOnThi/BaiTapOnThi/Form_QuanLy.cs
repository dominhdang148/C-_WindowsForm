using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapOnThi
{
    public partial class frm_QuanLy : Form
    {
        private string connectionString = "";
        public frm_QuanLy()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        private void HienThiNhomMonAn()
        {
            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM NhomMonAn";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("NhomMonAn");

            connection.Open();
            adapter.Fill(table);
            connection.Close();

            cbbCategory.DisplayMember = "TenNhom";
            cbbCategory.ValueMember = "MaNhom";
            cbbCategory.DataSource = table;
        }

        private void HienThiMonAnTheoMaNhom(int ma)
        {
            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();

            command.CommandText = "select a.MaMonAn, a.TenMonAn, a.DonViTinh, a.DonGia, TenNhom " +
                "from MonAn a, NhomMonAn b " +
                "where a.Nhom=b.MaNhom and a.Nhom = " + ma;

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("MonAn");

            connection.Open();
            adapter.Fill(table);
            connection.Close();

            dgvDanhSach.DataSource = table;
        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            HienThiNhomMonAn();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cbbCategory.SelectedValue);
            HienThiMonAnTheoMaNhom(id);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search_result = txtSearch.Text;

            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();

            command.CommandText = "select a.MaMonAn, a.TenMonAn, a.DonViTinh, a.DonGia, b.TenNhom from MonAn a, NhomMonAn b where a.Nhom=b.MaNhom and a.TenMonAn like N'%" + search_result + "%'";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("MonAn");

            connection.Open();
            adapter.Fill(table);
            connection.Close();

            dgvDanhSach.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frm_ThongTin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                HienThiMonAnTheoMaNhom(form.nhomMonAn);
            }
        }

        private void dgvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if(dgvDanhSach.SelectedRows.Count>0)
            {
                var maMonAn = Convert.ToInt32(dgvDanhSach.SelectedRows[0].Cells[0].Value);
                var form = new frm_ThongTin(maMonAn);
                if(form.ShowDialog()==DialogResult.OK)
                {
                    var nhom = form.nhomMonAn;
                    HienThiMonAnTheoMaNhom(nhom);
                }
            }
        }
    }
}
