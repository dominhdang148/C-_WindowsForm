﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab02_VD2
{
    public class DanhMucMonHoc
    {
        public ArrayList ds;
        public DanhMucMonHoc()
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc; }
            set { ds[index] = value; } 
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s = "Danh sach mon hoc";
            foreach (object mh in ds)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }
    }
}
