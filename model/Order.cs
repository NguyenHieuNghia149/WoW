using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    internal class Order
    {
        private string WorkerName; // lay tu class Worker
        private string CustomerName;
        private string FieldName; // lay tu class jobField
        private string JobName;  // lay tu class Job
        private string Cost;
        private string PhoneNumber;
        private string Detail;
        private string City;
        private string District;
        private DateTime TimeStart;
        private DateTime TimeEnd;
        private string Status;

        public Order(string workerName, string customerName, string fieldName, string jobName, string cost, string phoneNumber, string detail, string city, string district, DateTime timeStart, DateTime timeEnd, string status)
        {
            WorkerName = workerName;
            CustomerName = customerName;
            FieldName = fieldName;
            JobName = jobName;
            Cost = cost;
            PhoneNumber = phoneNumber;
            Detail = detail;
            City = city;
            District = district;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Status = status;
        }

        public string workername { get => WorkerName; set => WorkerName = value; }
        public string customername { get => CustomerName; set => CustomerName = value; }
        public string fieldname { get => FieldName; set => FieldName = value; }
        public string jobname { get => JobName; set => JobName = value; }
        public string cost { get => Cost; set => Cost = value; }
        public string phonenumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string detail { get => Detail; set => Detail = value; }
        public string city { get => City; set => City = value; }
        public string district { get => District; set => District = value; }
        public DateTime timestart { get => TimeStart; set => TimeStart = value; }
        public DateTime timeend { get => TimeEnd; set => TimeEnd = value; }
        public string status { get => status; set => status = value; }
    }
}
