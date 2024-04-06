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
    public class Customer
    {
        private string CID;
        private string Email;
        private string Password;
        private string Fullname;
        private string Gender;
        private string Birthday;
        private string City;
        private string District;
        private string PhoneNumber;
        private string Address;
        private Image Image;

        public Customer()
        {

        }
        public Customer( string email, string password)
        {
            Email = email;
            Password = password;
         
        }
        public Customer(string cID, string email, string password, string fullname, string gender, string birthday, string city, string district, string phoneNumber, string address,Image image)
        {
            CID = cID;
            Email = email;
            Password = password;
            Fullname = fullname;
            Gender = gender;
            Birthday = birthday;
            City = city;
            District = district;
            PhoneNumber = phoneNumber;
            Address = address;
            Image = image;
        }
       
        public string Cid { get => CID; set => CID = value; }
        public string email { get => Email; set => Email = value; }
        public string password { get => Password; set => Password = value; }
        public string fullname { get => Fullname; set => Fullname = value; }
        public string gender { get => Gender; set => Gender = value; }
        public string birthday { get => Birthday; set => Birthday = value; }
        public string city { get => City; set => City = value; }
        public string district { get => District; set => District = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string address { get => Address; set => Address = value; }
        public Image image { get => Image; set => image = value; }
    }

}
