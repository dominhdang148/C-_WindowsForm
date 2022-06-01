using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab3_Demo
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        // Thêm một sinh viên vào danh sách

        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }

        // Xoá các obj trong danh sách nếu thỏa mãn điều kiện so sánh

        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }

        // Tìm một sinh viện trong danh sách thỏa điều kiện so sánh

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
            {
                if(ss(obj,sv)==0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }

        // Tìm lại mọt sinh viên trong danh sách thỏa điều kiện so sánh, gán lại thông tin cho sinh viên này thành svsua

        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            bool kq = false;
            int count = this.DanhSach.Count - 1;
            for (int i = 0; i < count; i++)
            {
                if(ss(obj, this[i])==0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        public void DocTuFile()
        {
            string filename = "DanhSachSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)); 
            while((t=sr.ReadLine())!=null)
            {

                s = t.Split('*');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[5];
                sv.GioiTinh = false;
                if (s[6] == "1")
                    sv.GioiTinh = true;
                string[] cn = s[7].Split(',');
                foreach (var c in cn)
                {
                    sv.ChuyenNganh.Add(c);
                }
                this.Them(sv);
            }
        }
    }
}
