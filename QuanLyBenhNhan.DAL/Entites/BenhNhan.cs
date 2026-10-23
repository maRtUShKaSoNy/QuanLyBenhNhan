using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyBenhNhan.DAL.Entites
{
    public class BenhNhan
    {
        [Key]
        public string MaBN { get; set; }
        [Required]
        public string TenBN { get; set; }
        [Required]
        public int MaTT { get; set; }
        public string? GhiChu { get; set; }
        public string? BNTXG { get; set; }
        [ForeignKey(nameof(MaTT))]
        public virtual TinhTrang? TinhTrang { get; set; }
    }
}
