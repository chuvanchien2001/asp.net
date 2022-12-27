﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj_Shopping.Models
{
    public class SanphamMua
    {
        public string masp { get; set; }
        public int soluong { get; set; }
        public override bool Equals(object obj)
        {
            SanphamMua spm = (SanphamMua)obj;
            return (spm.masp.Equals(this.masp));
        }
    }
}