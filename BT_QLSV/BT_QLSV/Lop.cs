using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BT_QLSV
{
    public class Lop
    {
        public int ID { get; set; }
        public string tenLop { get; set; }
        public Lop()
        {

        }
        public Lop(DataRow row)
        {
            this.ID = Convert.ToInt32(row["Id"]);
            this.tenLop = row["TenLop"].ToString();
        }
    }
}
