using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    public class Worker
    {
        private string WID;
        private string Email;
        private string Password;
        private string Fullname;
        private string Gender;
        private string Birthday;
        private string City;
        private string District;
        private string PhoneNumber;
        private string Address;

        public Worker(string email, string password)
        {
            Email = email;
            Password = password;

        }
        public Worker(string wID, string email, string password, string fullname, string gender, string birthday, string city, string district, string phoneNumber, string address)
        {
            WID = wID;
            Email = email;
            Password = password;
            Fullname = fullname;
            Gender = gender;
            Birthday = birthday;
            City = city;
            District = district;
            PhoneNumber = phoneNumber;
            Address = address;

        }

        public string wID { get => WID; set => WID = value; }
        public string email { get => Email; set => Email = value; }
        public string password { get => Password; set => Password = value; }
        public string fullname { get => Fullname; set => Fullname = value; }
        public string gender { get => Gender; set => Gender = value; }
        public string birthday { get => Birthday; set => Birthday = value; }
        public string city { get => City; set => City = value; }
        public string district { get => District; set => District = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string address { get => Address; set => Address = value; }
    }
}
