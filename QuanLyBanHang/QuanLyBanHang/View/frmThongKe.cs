using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Control;
namespace QuanLyBanHang.View
{
    public partial class frmThongKe : Form
    {
        ThongKeControl tk = new ThongKeControl();
        public frmThongKe()
        {
            InitializeComponent();
        }
        void HienThiBangThongKe()
        {
            DataTable tbThongKe = tk.LayBangThongKe();
            for(int i=0;i<tbThongKe.Rows.Count;i++)
            {
                ListViewItem lvi = lsvThongKe.Items.Add(tbThongKe.Rows[i][0].ToString());
                lvi.SubItems.Add(tbThongKe.Rows[i][1].ToString());
            }
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            HienThiBangThongKe();
        }
    }
}
