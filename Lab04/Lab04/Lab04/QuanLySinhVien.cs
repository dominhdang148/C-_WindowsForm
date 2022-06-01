using System.Collections;
using System;
using System.IO;

namespace Lab04
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public ArrayList dssv;
        public QuanLySinhVien()
        {
            dssv = new ArrayList();
        }

        // Thêm 1 sinh viên vào danh sách

        public void Them(SinhVien sv)
        {
            dssv.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return (SinhVien)dssv[index]; }
            set { dssv[index] = value; }
        }

        // Xóa các obj trong danh sách nếu thỏa điều kiện so sánh

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dssv.Count - 1;
            for (; i >= 0; i--)
            {
                if (ss(obj, this[i]) == 0)
                    this.dssv.RemoveAt(i);
            }
        }

        // Tìm một sinh viên trong danh sách thỏa điều kiện so sánh

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in dssv)
            {
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }

        // Tìm một sinh viênn trong danh sách thảo điều kiện so sánh, gán lại thông tin cho sinh viên này thành svsua

        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.dssv.Count - 1;
            for (i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }

        // Hàm đọc danh sách sinh viên từ tập tin .txt

        public void DocTuFile()
        {
            string filename = "SinhVien.txt",t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.maSo = s[0];
                sv.hoTen = s[1];
                sv.email = s[2];
                sv.gioiTinh = false;
                if (s[3] == "1")
                    sv.gioiTinh = true;
                sv.diaChi = s[4];
                sv.ngaySinh = DateTime.Parse(s[5]);
                sv.hinh = s[6];
                sv.lop = s[7];
                sv.soDT = s[8];
                this.Them(sv);
            }
        }
    }
}
