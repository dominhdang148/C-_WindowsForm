using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThi
{
    public partial class frmThongTin : Form
    {
        public int NhomMA = 0;
        private int maMonAn = 0;
        private string connectionString = "";
        public frmThongTin()
        {
            InitializeComponent();
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLMonAn;Integrated Security=True";
        }

        private void frmThongTin_Load(object sender, EventArgs e)
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

            cbbCatgory.DisplayMember = "TenNhom"; //Tên hiển thị
            cbbCatgory.ValueMember = "MaNhom"; // Tham chiếu
            cbbCatgory.DataSource = table; // Nguồn dữ liệu
        }

        private void cbbCatgory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ma = int.Parse(txtID.Text);
            var ten = txtName.Text;
            var dvt = txtUnit.Text;
            var donGia = Convert.ToInt32(nudPrice.Value);
            var nhom = cbbCatgory.SelectedValue;

            if(string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Cần đầy đủ thông tin");
                return;
            }
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("NhomMonAn");

            conn.Open();
            if (ma == 0)
            {
                //Thêm
                command.CommandText = "INSERT [dbo].[MonAn] ( [TenMonAn], [DonViTinh], [DonGia], [Nhom]) " +
                    "VALUES (@TenMonAn, @DonViTinh, @DonGia, @Nhom)";
            }
            else
            {
                command.CommandText = "update MonAn set TenMonAn=@TenMonAn, " +
                    "DonViTinh=@DonViTinh, DonGia=@DonGia" +
                    "Nhom=@nhom where MaMonAn=@MaMonAn";
            }
            command.Parameters.AddWithValue("@TenMonAn", ten);
            command.Parameters.AddWithValue("@DonViTinh", dvt);
            command.Parameters.AddWithValue("@DonGia", donGia);
            command.Parameters.AddWithValue("@Nhom", nhom);

            var soDong = command.ExecuteNonQuery();
            if (soDong > 0)
            {
                MessageBox.Show("Thành công", "Thông báo");
                NhomMA = nhom;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Có lỗi", "Thông báo");
            }
            conn.Close();
        }
        private void LayMonAnTheoMa(int ma)
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM MonAn Where MaMonAn = "+ma;
       

            conn.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
                {
                txtID.Text = maMonAn.ToString();
                txtName.Text=reader["TenMonAn"].ToString();
                txtUnit.Text = reader["DonViTinh"].ToString();
                nudPrice.Value = Convert.ToInt32(reader["DonGia"].ToString());
                cbbCatgory.ValueMember =reader["Nhom"].ToString();


            }

        }
    }
}
