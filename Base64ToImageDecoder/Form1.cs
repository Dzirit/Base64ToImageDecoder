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

namespace Base64ToImageDecoder
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        
      
        public static Bitmap ByteToImage(byte[] imageBytes)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = imageBytes;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            
            var inputArray = Convert.FromBase64String(richTextBox1.Text);
            pictureBox1.Image = ByteToImage(inputArray);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
