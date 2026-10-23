using Microsoft.EntityFrameworkCore;
using QuanLyBenhNhan.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhan.DAL
{
   public class BenhNhanDAL
    {
  
            private readonly Covid19DbContext _context = new Covid19DbContext();

            public List<BenhNhan> GetAll()
            {
                return _context.BenhNhans.Include(b => b.TinhTrang).ToList();
            }

            public BenhNhan? GetById(string maBN)
            {
                return _context.BenhNhans.FirstOrDefault(b => b.MaBN == maBN);
            }

            public void Add(BenhNhan bn)
            {
                _context.BenhNhans.Add(bn);
                _context.SaveChanges();
            }

            public void Update(BenhNhan bn)
            {
                _context.SaveChanges();
            }
        }
    }

