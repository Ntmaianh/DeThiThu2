using DeThiThu2.BUS;
using DeThiThu2.DomainClass;

namespace DeThiThu2
{
    public partial class Form1 : Form
    {
        Service service = new Service();
        Guid? _idWhenClick;
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadConboBox()
        {
            cbChucVu.DataSource = service.GetChucVuService();
            cbChucVu.DisplayMember = "Ten";
            cbChucVu.ValueMember = "Id";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConboBox();
        }

        public void LoadData(string? name)
        {
            try
            {
                int stt = 1;
                dgvNv.ColumnCount = 6;
                dgvNv.Rows.Clear();
                dgvNv.Columns[0].Name = "Id";
                dgvNv.Columns[1].Name = "STT";
                dgvNv.Columns[2].Name = "Tên";
                dgvNv.Columns[3].Name = "Giới tính";
                dgvNv.Columns[4].Name = "Chức vụ";
                dgvNv.Columns[5].Name = "Số điện thoại";
                dgvNv.Columns[0].Visible = false;
                foreach (var item in service.GetAllNhanVienService(name))
                {
                    var chucVu = service.GetChucVuService().First(x => x.Id == item.IdCv);
                    dgvNv.Rows.Add(item.Id, stt++, item.Ten, item.GioiTinh, chucVu.Ten, item.Sdt);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        // đây làf nút hiển thị 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void dgvNv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _idWhenClick = Guid.Parse(dgvNv.Rows[e.RowIndex].Cells[0].Value.ToString());
            var result = service.GetAllNhanVienService(null).First(x => x.Id == _idWhenClick);
            txtName.Text = result.Ten;
            txtSdt.Text = result.Sdt;
            if (result.GioiTinh == "Nam")
            {
                radbtnNam.Checked = true;
                radntnNu.Checked = false;
            }
            else
            {
                radbtnNam.Checked = false;
                radntnNu.Checked = true;
            }

            cbChucVu.SelectedValue = result.IdCv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanvien = new NhanVien();
                int ma = 1000;
                if (service.GetAllNhanVienService(null).Any(x => x.Ma == ma.ToString()))
                {
                    ma++;
                }
                nhanvien.Ma = ma.ToString();
                nhanvien.Ten = txtName.Text;
                nhanvien.Sdt = txtSdt.Text;
                if (radbtnNam.Checked)
                {
                    nhanvien.GioiTinh = "Nam";
                }
                else
                {
                    nhanvien.GioiTinh = "Nữ";
                }
                nhanvien.IdCv = Guid.Parse(cbChucVu.SelectedValue.ToString());
                service.AddNhanVienServie(nhanvien);
                LoadData(null);
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm thât bại!");
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.Ten = txtName.Text;
                nhanvien.Sdt = txtSdt.Text;
                if (radbtnNam.Checked)
                {
                    nhanvien.GioiTinh = "Nam";
                }
                else
                {
                    nhanvien.GioiTinh = "Nữ";
                }
                nhanvien.IdCv = Guid.Parse(cbChucVu.SelectedValue.ToString());
                service.UpdateNhanVien(_idWhenClick, nhanvien);
                LoadData(null);
            }
            catch (Exception)
            {

                MessageBox.Show("Sửa thât bại!");
            }
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSdt.Text = "";
            cbChucVu.Text = "";
            radbtnNam.Checked = false;
            radntnNu.Checked = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length == 0 || txtTimKiem.Text == null)
            {
                LoadData(null);
            }
            else
            {
                LoadData(txtTimKiem.Text);
            }
        }
    }
}