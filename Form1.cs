using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMTT
{
    public partial class Form1 : Form
    {
        string inputfilePath = string.Empty;
        string folderOutputPath = string.Empty;
        string salt = "";
        string password;

        byte[] fileToEncypt = null;
        byte[] encryptFile = null;

        byte[] fileToDecrypt = null;
        byte[] decryptFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        //Chọn file để mã hóa
        private void btPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if(od.ShowDialog() == DialogResult.OK)
            {
                inputfilePath = od.FileName;
                tbPath.Text = inputfilePath;
            }
        }

        //Giải mã
        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            inputfilePath = tbPath.Text;
            folderOutputPath = tbResultPath.Text;
            password = tbPassword.Text;

            //Kiểm tra file đàu vào và vị trí lưu có trống hay không
            if(string.IsNullOrEmpty(inputfilePath) || string.IsNullOrEmpty(folderOutputPath))
            {
                MessageBox.Show("Hãy nhập đầy đủ dư liệu đầu vào!"); return;
            }

            // Đọc file cần giải mã
            fileToDecrypt = File.ReadAllBytes(inputfilePath);
            decryptFile = Crypt.Decrypt(password, fileToDecrypt, salt);

            // Kiểm tra kết quả giải mã
            if (decryptFile != null)
            {
                // Nếu người dùng nhập tên file, sử dụng tên đó, nếu không thì dùng tên mặc định
                string outputFileName = string.IsNullOrEmpty(tbFileName.Text) ? "decrypt.dat" : tbFileName.Text;
                string outputPath = Path.Combine(folderOutputPath, outputFileName);
                File.WriteAllBytes(outputPath, decryptFile);
                tbPassword.Clear();
                MessageBox.Show("Giải mã thành công.");
            }
            else
            {
                MessageBox.Show("Giải mã thất bại.");
            }
        }

        private void btOutputPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog od = new FolderBrowserDialog())
            {
                if(od.ShowDialog()==DialogResult.OK) 
                {
                    folderOutputPath = od.SelectedPath;
                    tbResultPath.Text = folderOutputPath;
                }
            }
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            inputfilePath = tbPath.Text;
            folderOutputPath = tbResultPath.Text;
            password = tbPassword.Text;

            if (string.IsNullOrEmpty(inputfilePath) || string.IsNullOrEmpty(folderOutputPath))
            {
                MessageBox.Show("Hãy nhập đầy đủ dư liệu đầu vào!"); return;
            }

            // Đọc file cần mã hóa
            fileToEncypt = File.ReadAllBytes(inputfilePath);
            encryptFile = Crypt.Encrypt(password, fileToEncypt, salt);

            // Kiểm tra kết quả mã hóa
            if (encryptFile != null)
            {
                // Nếu người dùng nhập tên file, sử dụng tên đó, nếu không thì dùng tên mặc định
                string outputFileName = string.IsNullOrEmpty(tbFileName.Text) ? "encrypt.dat" : tbFileName.Text;
                string outputPath = Path.Combine(folderOutputPath, outputFileName);
                File.WriteAllBytes(outputPath, encryptFile);
                tbPassword.Clear();
                MessageBox.Show("Mã hóa thành công.");
            }
            else
            {
                MessageBox.Show("Mã hóa thất bại.");
            }
        }
    }
}
