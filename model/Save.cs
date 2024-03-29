using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    internal class Save
    {
        private string CustomerName;
        private string WorkerName; // lay tu class Worker
        private string FieldName; // lay tu class jobField
        private string JobName;  // lay tu class Job
        private string Cost;
        private string PhoneNumber;
        private string Detail;
        private string City;
        private string District;

        public Save(string workerName, string fieldName, string jobName, string cost, string phoneNumber, string detail, string city, string district)
        {
            WorkerName = workerName;
            FieldName = fieldName;
            JobName = jobName;
            Cost = cost;
            PhoneNumber = phoneNumber;
            Detail = detail;
            City = city;
            District = district;
        }

        public string workerName { get => WorkerName; set => WorkerName = value; }
        public string fieldname { get => FieldName; set => FieldName = value; }
        public string jobName { get => JobName; set => JobName = value; }
        public string cost1 { get => Cost; set => Cost = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string detail { get => Detail; set => Detail = value; }
        public string city { get => City; set => City = value; }
        public string district { get => District; set => District = value; }
    }
}
