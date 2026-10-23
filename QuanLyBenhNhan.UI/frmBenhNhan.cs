using Microsoft.EntityFrameworkCore;
using QuanLyBenhNhan.DAL.Entites;

namespace QuanLyBenhNhan.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maBN = dataGridView1.Rows[e.RowIndex].Cells["MaBN"].Value?.ToString();
                if (!string.IsNullOrEmpty(maBN))
                {
                    var bn = _context.BenhNhans.FirstOrDefault(x => x.MaBN == maBN);

                    if (bn != null)
                    {
                        txtMaBN.Text = bn.MaBN;
                        txtTenBN.Text = bn.TenBN;
                        rtxtGhiChu.Text = bn.GhiChu ?? "";
                        comboBox1.SelectedValue = bn.MaTT;
                        if (string.IsNullOrEmpty(bn.BNTXG))
                        {
                            comboBox2.SelectedIndex = -1;
                        }
                        else
                        {
                            comboBox2.SelectedValue = bn.BNTXG;
                        }
                    }
                }
            }
        }
        private Covid19DbContext _context = new Covid19DbContext();
        private void LoadDataGridViewData()
        {
            List<BenhNhan> allPatients = _context.BenhNhans
                .Include(b => b.TinhTrang)
                .ToList();
            var listBN = allPatients.Select(b => new
            {
                MaBN = b.MaBN,
                TenBN = b.TenBN,
                TenTT = b.TinhTrang != null ? b.TinhTrang.TenTT : "",
                F = "F" + GetFN(b.MaBN, allPatients)
            })
                .ToList();

            dataGridView1.DataSource = listBN;
            if (dataGridView1.Columns["MaBN"] != null) dataGridView1.Columns["MaBN"].HeaderText = "Mã BN";
            if (dataGridView1.Columns["TenBN"] != null) dataGridView1.Columns["TenBN"].HeaderText = "Tên BN";
            if (dataGridView1.Columns["TenTT"] != null) dataGridView1.Columns["TenTT"].HeaderText = "Tình trạng";
            if (dataGridView1.Columns["GhiChu"] != null) dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            if (dataGridView1.Columns["BNTXG"] != null) dataGridView1.Columns["BNTXG"].HeaderText = "Lây nhiễm từ";
            if (dataGridView1.Columns["F"] != null) dataGridView1.Columns["F"].HeaderText = "F";
        }


        private void LoadComboBoxData()
        {
            var listTT = _context.TinhTrangs.ToList();
            comboBox1.DataSource = listTT;
            comboBox1.DisplayMember = "TenTT";
            comboBox1.ValueMember = "MaTT";
            var listBN = _context.BenhNhans.ToList();
            comboBox2.DataSource = listBN;
            comboBox2.DisplayMember = "MaBN";
            comboBox2.ValueMember = "MaBN";
            comboBox2.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadDataGridViewData();
        }
        private int GetFN(string maBN, List<BenhNhan> allPatients)
        {
            var bn = allPatients.FirstOrDefault(x => x.MaBN == maBN);
            if (bn == null || string.IsNullOrEmpty(bn.BNTXG))
            {
                return 0;
            }
            return GetFN(bn.BNTXG, allPatients) + 1;
        }
        private void ResetForm()
        {
            txtMaBN.Clear();
            txtTenBN.Clear();
            rtxtGhiChu.Clear();
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = -1;
            txtMaBN.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text.Trim(), tenBN = txtTenBN.Text.Trim();
            if (string.IsNullOrEmpty(maBN) || string.IsNullOrEmpty(tenBN))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân!");
                return;
            }
            if (maBN.Length != 6)
            {
                MessageBox.Show("Mã bệnh nhân phải có 6 kí tự!");
                return;
            }
            var bn = _context.BenhNhans.FirstOrDefault(b => b.MaBN == maBN);
            if (bn == null)
            {
                bn = new BenhNhan { MaBN = maBN };
                _context.BenhNhans.Add(bn);
            }

            bn.TenBN = tenBN;
            bn.MaTT = Convert.ToInt32(comboBox1.SelectedValue);
            bn.GhiChu = string.IsNullOrWhiteSpace(rtxtGhiChu.Text) ? null : rtxtGhiChu.Text.Trim();
            bn.BNTXG = comboBox2.SelectedValue?.ToString();

            _context.SaveChanges();
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
            LoadComboBoxData();
            LoadDataGridViewData();
            txtMaBN.Clear();
            txtTenBN.Clear();
            rtxtGhiChu.Clear();
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = -1;
        }
    }
}
