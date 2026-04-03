using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07QLHS
{
    public partial class FrmQLLop : Form
    {
        public FrmQLLop()
        {
            InitializeComponent();
        }

        private void FrmQLLop_Load(object sender, EventArgs e)
        {
            loadDsLop();
        }
        private void loadDsLop()
        {
            var dtLop = DataProvider.TruyVan_LayDuLieu("SELECT MaLop, TenLop, SiSo FROM LOP");
            lvLop.Items.Clear();//xóa dữ liệu cũ
            foreach (DataRow dr in dtLop.Rows)
            {
                var item = new ListViewItem(dr["MaLop"].ToString());
                item.Tag = dr["MaLop"].ToString();
                item.SubItems.Add(dr["TenLop"].ToString());
                item.SubItems.Add(dr["SiSo"].ToString());
                lvLop.Items.Add(item);
            }
        }
        private void cboListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLop.View = (View) cboListType.SelectedIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sql = $"INSERT INTO Lop(MaLop, TenLop, SiSo) VALUES('{txtMaLop.Text}', N'{txtTenLop.Text}', '{txtSiSo.Text}')";
            MessageBox.Show(sql);
        }
    }
}
