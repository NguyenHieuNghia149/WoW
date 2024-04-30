using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Resources;
using System.Windows.Shapes;


namespace TheGioiViecLam.DAO
{
    public class ImageDao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);



        public byte[] imageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        //Chuyen file anh asng byte[]
        public byte[] PathtoByteArray(string path)
        {
            MemoryStream m = new MemoryStream();
            Image img = Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }


        public Image byteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
    }
}
