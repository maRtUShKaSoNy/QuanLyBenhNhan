using QuanLyBenhNhan.DAL;
using QuanLyBenhNhan.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhan.BLL
{
   public class TinhTrangBLL
    {
        
        private readonly TinhTrangDAL _tinhTrangDAL = new TinhTrangDAL();
        public List<TinhTrang> GetAllStatuses()
        {
            return _tinhTrangDAL.GetAll();
        }
    }
}

