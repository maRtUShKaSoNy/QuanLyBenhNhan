using QuanLyBenhNhan.DAL;
using QuanLyBenhNhan.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhan.BLL
{
    public class BenhNhanBLL
    {
        private readonly BenhNhanDAL _benhNhanDAL = new BenhNhanDAL();
        private readonly TinhTrangDAL _tinhTrangDAL = new TinhTrangDAL();

        public List<BenhNhan> GetAllPatients() => _benhNhanDAL.GetAll();
        public List<TinhTrang> GetAllStatuses() => _tinhTrangDAL.GetAll();
        public int GetFN(string? maBN, List<BenhNhan> allPatients)
        {
            if (string.IsNullOrEmpty(maBN)) return 0;
            var bn = allPatients.FirstOrDefault(x => x.MaBN == maBN);
            if (bn == null || string.IsNullOrEmpty(bn.BNTXG)) return 0;
            return GetFN(bn.BNTXG, allPatients) + 1;
        }
        public void SaveOrUpdate(string maBN, string tenBN, int maTT, string ghiChu, string? bnTXG)
        {
            if (string.IsNullOrWhiteSpace(maBN) || string.IsNullOrWhiteSpace(tenBN))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin bệnh nhân!");
            }
            if (maBN.Trim().Length != 6)
            {
                throw new Exception("Mã bệnh nhân phải có 6 kí tự!");
            }

            var bnExist = _benhNhanDAL.GetById(maBN.Trim());
            if (bnExist == null)
            {
                var newBN = new BenhNhan
                {
                    MaBN = maBN.Trim(),
                    TenBN = tenBN.Trim(),
                    MaTT = maTT,
                    GhiChu = string.IsNullOrWhiteSpace(ghiChu) ? null : ghiChu.Trim(),
                    BNTXG = string.IsNullOrWhiteSpace(bnTXG) ? null : bnTXG
                };
                _benhNhanDAL.Add(newBN);
            }
            else
            {
                bnExist.TenBN = tenBN.Trim();
                bnExist.MaTT = maTT;
                bnExist.GhiChu = string.IsNullOrWhiteSpace(ghiChu) ? null : ghiChu.Trim();
                bnExist.BNTXG = string.IsNullOrWhiteSpace(bnTXG) ? null : bnTXG;
                _benhNhanDAL.Update(bnExist);
            }
        }
    }
}

