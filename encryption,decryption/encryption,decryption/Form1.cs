using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace encryption_decryption
{
    public partial class Sha256 : Form
    {
        public Sha256()
        {
            InitializeComponent();
        }
        public static string SHA256(string data)
        {
            byte[] array = Encoding.Default.GetBytes(data);
            byte[] hashValue;
            string result = string.Empty;


            using (SHA256 SHA256 = SHA256.Create())
            {
                hashValue = SHA256.ComputeHash(array);
            }

            for (int i = 0; i < hashValue.Length; i++)
            {
                result += hashValue[i].ToString("x2");
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string EC256 = textBox1.Text;
            string result = SHA256(EC256);
            textBox2.Text = result;
            MessageBox.Show("암호화가 성공적으로 되었습니다!","완료!");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
