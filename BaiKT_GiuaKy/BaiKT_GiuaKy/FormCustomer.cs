using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKT_GiuaKy
{
    public partial class FormCustomer : Form
    {
        private string connectionString = "";
        public FormCustomer()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            
            HienThiDanhSachKhachHang();
        }

        private void HienThiDanhSachKhachHang()
        {
            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM KhachHang";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("KhachHang");

            connection.Open();
            adapter.Fill(table);
            connection.Close();

            dgvDanhSachKH.DataSource = table;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            mtxtSDT.Text = "";
            txtDC.Text = "";
        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvDanhSachKH.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvDanhSachKH.SelectedRows[0].Cells[1].Value.ToString();
            mtxtSDT.Text = dgvDanhSachKH.SelectedRows[0].Cells[2].Value.ToString();
            txtDC.Text = dgvDanhSachKH.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var name = txtName.Text;
            var sdt = mtxtSDT.Text;
            var dc = txtDC.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Lỗi! Xin hãy nhập đầy đủ thông tin cần thiết", "Thông báo");
                return;
            }

            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();

            if (id == "")
            {
                //INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Nga', N'0985785745 ', NULL)
                command.CommandText = "INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (@Name,@SDT, @DC)";
            }
            else
            {
                command.CommandText = "UPDATE KhachHang set TenKH=@Name, SoDienThoai=@SDT, DiaChiGH=@DC WHERE MaKH=@id";
            }

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            if (sdt != null)
            {
                command.Parameters.AddWithValue("@SDT", sdt);
            }
            else
            {
                command.Parameters.AddWithValue("@SDT", "NULL");
            }

            if (dc != null)
            {
                command.Parameters.AddWithValue("@DC", dc);
            }
            else
            {
                command.Parameters.AddWithValue("@DC", "NULL");
            }
            connection.Open();
            var numberOfLine = command.ExecuteNonQuery();
            connection.Close();
            if (numberOfLine > 0)
            {
                MessageBox.Show("Thao tác thành công!", "Thông báo");
                btnReset.PerformClick();
                HienThiDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại", "Thông báo");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var search_result = txtSearch.Text;
            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();
            if (rbTen.Checked)
            {
                command.CommandText = "select * from KhachHang where TenKH like N'%" + search_result + "%'";
            }
            else
            {
                command.CommandText= "select * from KhachHang where SoDienThoai like '%" + search_result + "%'";
            }

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("KhachHang");

            connection.Open();
            adapter.Fill(table);
            connection.Close();

            dgvDanhSachKH.DataSource = table;
        }
    }
}
