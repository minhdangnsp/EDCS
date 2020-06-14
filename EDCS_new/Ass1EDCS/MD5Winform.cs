using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Ass1EDCS
{
    public partial class MD5Winform : Form
    {
        public MD5Winform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Chọn tập tin";
            openDialog.Multiselect = false;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openDialog.FileName;
                path = new FileInfo(path).FullName;
                txtResourceFile.Text = path;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Chọn tập tin";
            openDialog.Multiselect = false;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openDialog.FileName;
                path = new FileInfo(path).FullName;
                txtDestinationFile.Text = path;

            }
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            byte[] fileEncrypt = File.ReadAllBytes(txtResourceFile.Text);
            byte[] fileDencrypt = File.ReadAllBytes(txtDestinationFile.Text);
            txtOutResource.Text = MD5CheckSum.MD5Check(fileEncrypt); 
            txtOutDestination.Text = MD5CheckSum.MD5Check(fileDencrypt);
            if (MD5CheckSum.MD5Check(fileEncrypt) == MD5CheckSum.MD5Check(fileDencrypt))
            {
                MessageBox.Show("Giải mã và mã hóa thành công, file input và file output là giống nhau");
            }
            else
            {
                MessageBox.Show("Giải mã thất bại");
            }
        }
    }
}
