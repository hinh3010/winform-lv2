using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinDown.ChildForms.Categories
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int Gia = int.Parse(price.Text);
            int SL = int.Parse(soluong.Text);
            int Giamgia = int.Parse(giamgia.Text);
            int Tien = (Gia - Giamgia )*SL;

            if(SL < 1)
            {
                MessageBox.Show(
                $"Vui long chon so luong > 1 de mua san pham",
                $"Thong bao",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
            }
            MessageBox.Show(
                $"Hoa don mua hang cua ban \n" +
                $"San pham : {name.Text}\n" +
                $"Gia : {Gia}\n" +
                $"So luong : {SL}\n" +
                $"Thanh tien : {Tien}\n" ,
                $"Thong bao",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }

        private void soluong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int Gia = int.Parse(price2.Text);
            int SL = int.Parse(soluong2.Text);
            int KhuyenMai = int.Parse(khuyenmai.Text);
            float Tien = (float)(Gia - (KhuyenMai * Gia / 100)) * SL;

            if (SL < 1)
            {
                MessageBox.Show(
                $"Vui long chon so luong > 1 de mua san pham",
                $"Thong bao",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
            }
            MessageBox.Show(
                $"Hoa don mua hang cua ban \n" +
                $"San pham : {name2.Text}\n" +
                $"Gia : {Gia}\n" +
                $"So luong : {SL}\n" +
                $"Thanh tien : {Tien}\n",
                $"Thong bao",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int Gia = int.Parse(gia3.Text);
            int SL = int.Parse(soluong3.Text);
            int uudai1 = int.Parse(UuDai1.Text);
            int uudai2 = int.Parse(UuDai1.Text);
            float Tien = (float)(Gia - (uudai1 * Gia / 100) - uudai2) * SL;

            if (SL < 1)
            {
                MessageBox.Show(
                $"Vui long chon so luong > 1 de mua san pham",
                $"Thong bao",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
            }
            MessageBox.Show(
                $"Hoa don mua hang cua ban \n" +
                $"San pham : {name3.Text}\n" +
                $"Gia : {Gia}\n" +
                $"So luong : {SL}\n" +
                $"Thanh tien : {Tien}\n",
                $"Thong bao",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }

    }
}
