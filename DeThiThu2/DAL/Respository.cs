using DeThiThu2.Context;
using DeThiThu2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThiThu2.DAL
{
    internal class Respository
    {
        DBContext _dBContext = new DBContext();

        public List<NhanVien> GetAllNhanVien(string? name)
        {
            if (name == null)
            {
               return _dBContext.NhanViens.ToList();
            }
            return _dBContext.NhanViens.Where(x => x.Ten.Trim().ToLower().Contains(name.Trim().ToLower())).ToList();
        }

        public List<ChucVu> GetAllChucVu()
        {
            return _dBContext.ChucVus.ToList();
        }

        public bool AddNhanVien(NhanVien nhanVien)
        {
            if (nhanVien == null)
            {
                return false;
            }
            nhanVien.Id = Guid.NewGuid();
            _dBContext.NhanViens.Add(nhanVien);
            _dBContext.SaveChanges();
            return true;
        }
        public bool UpdateNhanVien(Guid? id, NhanVien nhanVien)
        {
            var nhanVienUpdate = _dBContext.NhanViens.FirstOrDefault(x => x.Id == id);
            if (nhanVienUpdate == null || nhanVien == null)
            {
                return false;
            }
            nhanVienUpdate.Ten = nhanVien.Ten;
            nhanVienUpdate.Sdt = nhanVien.Sdt;
            nhanVienUpdate.GioiTinh = nhanVien.GioiTinh;
            nhanVienUpdate.IdCv = nhanVien.IdCv;
            _dBContext.NhanViens.Update(nhanVienUpdate);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
