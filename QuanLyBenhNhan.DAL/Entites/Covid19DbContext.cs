using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhan.DAL.Entites
{
    public class Covid19DbContext : DbContext
    {
        public DbSet<TinhTrang> TinhTrangs { get; set; }
        public DbSet<BenhNhan> BenhNhans {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Server=.\\SQLEXPRESS01;" +
                                            "Database=QuanLyBenhNhan;" +
                                            "Trusted_Connection=True;" +
                                            "TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    }
}
