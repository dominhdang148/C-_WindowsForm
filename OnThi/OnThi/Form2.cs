using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThi
{
    public partial class frmQuanLy : Form
    {
        public string connectionString = "";
        public frmQuanLy()
        {
            InitializeComponent();
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLMonAn;Integrated Security=True";
        }

        private void cbbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ma = Convert.ToInt32(cbbNhom.SelectedValue);
            HienThiMonAnTheoMa(ma);
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            HienThiNhomMonAn();
        }
        private void HienThiNhomMonAn()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM NhomMonAn";
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("NhomMonAn");

            conn.Open();
            adapter.Fill(table);
            conn.Close();

            cbbNhom.DisplayMember = "TenNhom"; //Tên hiển thị
            cbbNhom.ValueMember = "MaNhom"; // Tham chiếu
            cbbNhom.DataSource = table; // Nguồn dữ liệu
        }

        private void HienThiMonAnTheoMa(int ma)
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT ma.*,TenNhom " +
                "FROM MonAn ma, NhomMonAn nma " +
                "WHERE ma.Nhom=nma.MaNhom and ma.Nhom = " + ma;
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("MonAn");

            conn.Open();
            adapter.Fill(table);
            conn.Close();

            dgvDanhsach.DataSource = table;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var vanBanTim = txtSearch.Text;
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT ma.*,TenNhom " +
                "FROM MonAn ma, NhomMonAn nma " +
                "WHERE ma.Nhom=nma.MaNhom and ma.TenMonAn Like '% " + vanBanTim + "+ %'";
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("MonAn");

            conn.Open();
            adapter.Fill(table);
            conn.Close();

            dgvDanhsach.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new frmThongTin();
            if (form.DialogResult == DialogResult.OK)
            {
                var nhom = form.NhomMA;
                HienThiMonAnTheoMa(nhom);
            }
        }


        private void dgvDanhsach_DoubleClick(object sender, EventArgs e)
        {
            if(dgvDanhsach.SelectedRows.Count>0)
            {
                var maMonAn=Convert.ToInt32(dgvDanhsach.SelectedRows[0].)
            }
        }
    }
}
