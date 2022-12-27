using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj_Shopping.Models
{
    public class Sanpham
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string hinhanh { get; set; }
        public int giatien { get; set; }
        public Sanpham()
        {

        }
        public Sanpham(string masp)
        {
            this.masp = masp;
        }
        public Sanpham(string masp,string tensp,string hinhanh,int giatien)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.hinhanh = hinhanh;
            this.giatien = giatien;
        }
        public override bool Equals(object obj)
        {
            Sanpham s = (Sanpham)obj;
            return (this.masp==s.masp);
        }
    }
}