using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace BT_QLSV
{
    public class SinhVien
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public int LopID { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(DataRow row)
        {
            this.ID = Convert.ToInt32(row["Id"]);
            this.HoTen = row["HoTen"].ToString();
            this.LopID = Convert.ToInt32(row["MaLop"]);
        }
    }
}
