using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    public class Human
    {
        public string ID;
        public string Email;
        public string Password;
        public string Fullname;
        public string Gender;
        public DateTime Birthday;
        public string City;
        public string District;
        public string PhoneNumber;
        public string Address;
        public Human(string wID, string email, string password, string fullname, string gender, DateTime birthday, string city, string district, string phoneNumber, string address)
        {
            ID = wID;
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

        public string wID { get => ID; set => ID = value; }
        public string email { get => Email; set => Email = value; }
        public string password { get => Password; set => Password = value; }
        public string fullname { get => Fullname; set => Fullname = value; }
        public string gender { get => Gender; set => Gender = value; }
        public DateTime birthday { get => Birthday; set => Birthday = value; }
        public string city { get => City; set => City = value; }
        public string district { get => District; set => District = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string address { get => Address; set => Address = value; }
    }
}

