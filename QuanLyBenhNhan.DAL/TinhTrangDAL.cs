using QuanLyBenhNhan.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhan.DAL
{
    public class TinhTrangDAL
    {
        private readonly Covid19DbContext _context = new Covid19DbContext();
        public List<TinhTrang> GetAll()
        {
            return _context.TinhTrangs.ToList();
        }
    }
}
