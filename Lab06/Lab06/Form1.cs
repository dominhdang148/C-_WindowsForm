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

namespace Lab06
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-D79P76S\DOMINHDANG;Initial Catalog=RestaurantManagement;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            string query = "exec LoadCategoryList";
            command.CommandText = query;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            this.DisplayCategory(reader);
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = conn.CreateCommand();
            string temp = txtType.Text == "Đồ ăn" ? "1" : "0";
            command.CommandText = "Insert into Category(Name, [Type])" + "Values(N'" + txtName.Text + "', " + temp + ")";
            conn.Open();
            int numOfRowEffected = command.ExecuteNonQuery();
            conn.Close();
            if(numOfRowEffected==1)
            {
                MessageBox.Show("Thêm món ăn thành công");
                btnLoad.PerformClick();

                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lôi xảy ra. Vui lòng thử lại");

            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

        }
    }
}
