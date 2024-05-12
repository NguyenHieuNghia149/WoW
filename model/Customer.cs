using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents.Serialization;

namespace TheGioiViecLam.model
{
    public class Customer : Human
    {
        public Image Image;

        public Customer(string ID, string email, string password, string fullname, string gender, DateTime birthday, string city, string district, string phoneNumber, string address,Image image) : base(ID, email, password, fullname, gender, birthday, city, district, phoneNumber, address)
        {
            Image = image;
        }
        public Image image { get => Image; set => image = value; }
    }

}
