using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapOnThi
{
    public partial class frm_ThongTin : Form
    {
        public int nhomMonAn = 0;
        private int idMonAn;
        private string connectionString = "";
        public frm_ThongTin(int maMonAn = 0)
        {
            this.idMonAn = maMonAn;
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        private void frm_ThongTin_Load(object sender, EventArgs e)
        {
            HienThiNhomMonAn();
            if(this.idMonAn>0)
            {
                HienThiMonAnTheoMa(idMonAn);
            }
        }
        private void HienThiNhomMonAn()
        {
            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();
            command.CommandText = "Select * from NhomMonAn";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("NhomMonAn");

            connection.Open();
            adapter.Fill(table);
            connection.Close();

            cbbCategory.DisplayMember = "TenNhom";
            cbbCategory.ValueMember = "MaNhom";
            cbbCategory.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text);
            var name = txtName.Text;
            var unit = txtUnit.Text;
            var price = Convert.ToInt32(nudPrice.Value);
            var category = Convert.ToInt32(cbbCategory.SelectedValue);

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin cần thiết", "Thông báo");
                return;
            }

            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();
            if (id == 0)
            {
                //INSERT [dbo].[MonAn] ([MaMonAn], [TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (1, N'Gỏi thập cẩm', N'Dĩa', 120000, 1)
                command.CommandText = "INSERT [dbo].[MonAn] ([TenMonAn], [DonViTinh], [DonGia], [Nhom]) VALUES (@name, @unit, @price, @category)";
            }
            else
            {
                // UPDATE MonAn SET TenMonAn = @name, DonViTinh = @unit, DonGia = @price, Nhom = @category WHERE MaMonAn = @id
                command.CommandText = " UPDATE MonAn SET TenMonAn = @name, DonViTinh = @unit, DonGia = @price, Nhom = @category WHERE MaMonAn = @id";
            }
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@unit", unit);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@category", category);

            connection.Open();

            var numberOfLine = command.ExecuteNonQuery();
            if (numberOfLine > 0)
            {
                MessageBox.Show("Thành công", "Thông báo");
                nhomMonAn = category;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo");
            }
            connection.Close();
        }
        private void HienThiMonAnTheoMa(int ma)
        {
            var connection = new SqlConnection(connectionString);
            var command = connection.CreateCommand();
            command.CommandText = "Select * from MonAn where MaMonAn="+ma;
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtID.Text = this.idMonAn.ToString();
                txtName.Text = reader["TenMonAn"].ToString();
                txtUnit.Text = reader["DonViTinh"].ToString();
                nudPrice.Value = Convert.ToInt32(reader["DonGia"]);
                cbbCategory.SelectedValue = Convert.ToInt32(reader["Nhom"]);
            }
        }
    }
}
