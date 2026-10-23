using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyBenhNhan.DAL.Entites
{
    public class TinhTrang
    {
        [Key]
        public int MaTT { get; set; }
        public string TenTT { get; set; }
        public virtual ICollection<BenhNhan> BenhNhans { get; set; } = new List<BenhNhan>();
    }
}
