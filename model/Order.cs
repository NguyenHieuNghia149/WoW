using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    public class Order
    {
        private string workername; // lay tu class Worker
        private string customername;// lay tu class jobField
        private string jobname;  // lay tu class Job
        private string cost;
        private string phonenumber;
        private DateTime date;
        private string fromHours;
        private string fromMinutes;
        private string status;
        private string cEmail;
        private string address;

        public Order()
        {

        }
        public Order(string workername, string customername, string jobname, string cost, string phonenumber, DateTime date, string fromHours, string fromMinutes, string status, string cEmail, string address)
        {
            this.workername = workername;
            this.customername = customername;
            this.jobname = jobname;
            this.cost = cost;
            this.phonenumber = phonenumber;
            this.date = date;
            this.fromHours = fromHours;
            this.fromMinutes = fromMinutes;
            this.status = status;
            this.cEmail = cEmail;
            this.Address = address;
        }

        public string Workername { get => workername; set => workername = value; }
        public string Customername { get => customername; set => customername = value; }

        public string Jobname { get => jobname; set => jobname = value; }
        public string Cost { get => cost; set => cost = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public DateTime Date { get => date; set => date = value; }
        public string FromHours { get => fromHours; set => fromHours = value; }
        public string FromMinutes { get => fromMinutes; set => fromMinutes = value; }
        public string Status { get => status; set => status = value; }
        public string CEmail { get => cEmail; set => cEmail = value; }
        public string Address { get => address; set => address = value; }
    }
}
