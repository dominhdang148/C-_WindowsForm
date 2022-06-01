using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class SinhVien
    {
        public string maSo { get; set;}
        public string hoTen { get; set; }
        public string email { get; set; }
        public bool gioiTinh { get; set; }
        public string diaChi { get; set; }
        public DateTime ngaySinh { get; set; }
        public string hinh { get; set; }
        public string lop { get; set; }
        public string soDT { get; set; }
        
        public SinhVien()
        {
                
        }
        public SinhVien(string id, string name, string em, bool gender, string address, DateTime dateOfBirth, string image, string clss, string phoneNumber)
        {
            this.maSo = id;
            this.hoTen = name;
            this.email = em;
            this.gioiTinh = gender;
            this.diaChi = address;
            this.ngaySinh = dateOfBirth;
            this.hinh = image;
            this.lop = clss;
            this.soDT = phoneNumber;
        }
    }
}
