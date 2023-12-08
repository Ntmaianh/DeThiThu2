using DeThiThu2.DAL;
using DeThiThu2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThiThu2.BUS
{
    internal class Service
    {
        Respository _res = new Respository();

        public List<ChucVu> GetChucVuService()
        {
            return _res.GetAllChucVu();
        }

        public List<NhanVien> GetAllNhanVienService(string? name)
        {
            return _res.GetAllNhanVien(name);
        }

        public void AddNhanVienServie(NhanVien nhanvien)
        {
            if (_res.AddNhanVien(nhanvien))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }

        }

        public void UpdateNhanVien(Guid? id, NhanVien nhanvien)
        {
            if (_res.UpdateNhanVien(id, nhanvien))
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
    }
}
