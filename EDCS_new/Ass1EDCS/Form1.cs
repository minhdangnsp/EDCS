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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonAES.Checked = true;
            txt_url_input.Enabled = false;
            txt_key.Focus();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Chọn tập tin cần mã hóa";
            openDialog.Multiselect = false;
            //openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openDialog.FileName;
                path = new FileInfo(path).FullName;
                txt_url_input.Text = path;
                /*
                txt_url_ciphertext.Text = Path.GetDirectoryName(path) + "\\ciphertext.txt";
                txt_url_plaintext.Text = Path.GetDirectoryName(path) + "\\plaintext.txt";
                StreamReader sr = new StreamReader(openDialog.FileName);
                txt_input.Text = sr.ReadToEnd();
                sr.Close();
                */
            }
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (txt_key.Text.Length != 0 && txt_url_input.Text.Length!=0)
            {
                //Console.Write(txt_ciphertext.Text);
                byte[] filecontent = File.ReadAllBytes(txt_url_input.Text);
                //txt_ciphertext.Text = FileFactory.EncryptAES(txt_input.Text, txt_key.Text);
                //txt_ciphertext.Text = FileFactory.EncryptAES(filecontent, txt_key.Text);
                //StreamWriter sw = new StreamWriter(txt_url_ciphertext.Text, false, Encoding.UTF8);
                //sw.WriteLine(txt_ciphertext.Text);
                //sw.Close();
                string fileExt = Path.GetExtension(txt_url_input.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "File (*" + fileExt + ")|*" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    if (radioButtonAES.Checked==true)
                    {
                        File.WriteAllBytes(sd.FileName, FileFactory.EncryptAES(filecontent, txt_key.Text));
                    }
                    else
                    {
                        File.WriteAllBytes(sd.FileName, FileFactoryDES.EncryptDES(filecontent, txt_key.Text));
                    }
                    txt_key.Enabled = true;
                }
            }
            else if(txt_key.Text.Length==0)
            {
                MessageBox.Show("Mời bạn nhập key");
            }
            else
            {
                MessageBox.Show("Mời bạn chọn file");
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (txt_url_input.Text.Length != 0)
            {
                try
                {
                    byte[] filecontent = File.ReadAllBytes(txt_url_input.Text);
                    //txt_plaintext.Text = FileFactory.DecryptAES(txt_input.Text, txt_key.Text);
                    //txt_plaintext.Text = FileFactory.DecryptAES(txt_input.Text, txt_key.Text);
                    //StreamWriter sw = new StreamWriter(txt_url_plaintext.Text, false, Encoding.UTF8);
                    //sw.WriteLine(txt_plaintext.Text);
                    //sw.Close();


                    string fileExt = Path.GetExtension(txt_url_input.Text);
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.Filter = "File (*" + fileExt + ")|*" + fileExt;
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        if (radioButtonAES.Checked == true)
                        {
                            File.WriteAllBytes(sd.FileName, FileFactory.DecryptAES(filecontent, txt_key.Text));
                        }
                        else
                        {
                            File.WriteAllBytes(sd.FileName, FileFactoryDES.DecryptDES(filecontent, txt_key.Text));
                        }
                        txt_key.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Không giải mã được, hãy kiểm tra lại khóa");
                }
            }
            else
            {
                MessageBox.Show("Mời bạn chọn file");
            }
        }

        private void txt_url_ciphertext_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_url_plaintext_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            txt_key.Enabled = false;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Chọn tập tin chứa key";
            openDialog.Multiselect = false;
            openDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //string path = openDialog.FileName;
                //path = new FileInfo(path).FullName;
                //txt_url_input.Text = path;
                
                //txt_url_ciphertext.Text = Path.GetDirectoryName(path) + "\\ciphertext.txt";
                //txt_url_plaintext.Text = Path.GetDirectoryName(path) + "\\plaintext.txt";
                StreamReader sr = new StreamReader(openDialog.FileName);
                txt_key.Text = sr.ReadToEnd();
                sr.Close();
                
            }
            else
            {
                txt_key.Enabled = true;
            }
        }

        private void btnCheckMD5_Click(object sender, EventArgs e)
        {
            MD5Winform frmNewWindow = new MD5Winform();
            frmNewWindow.FormClosed += new FormClosedEventHandler(frmNewWindow_close);
            frmNewWindow.Show();
            this.Hide();
        }

        private void frmNewWindow_close(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
