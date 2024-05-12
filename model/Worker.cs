using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    internal class Worker : Human
    {
        public Worker(string wID, string email, string password, string fullname, string gender, DateTime birthday, string city, string district, string phoneNumber, string address): base( wID, email, password, fullname, gender, birthday,city, district, phoneNumber,address)
          {
        }
    }
}
