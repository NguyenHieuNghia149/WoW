using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace TheGioiViecLam.model
{
    public class Post
    {
        private string IDP;
        private string WorkerName; // lay tu class Worker
        private string FieldName; // lay tu class jobField
        private string JobName;  // lay tu class Job
        private string Cost;
        private string PhoneNumber;
        private string Detail;
        private string City;
        private string District;
        private string Experience;
        private string Time;

        public Post(string iDP, string workerName, string fieldName, string jobName, string cost, string phoneNumber, string detail, string city, string district, string experience, string time)
        {
            IDP = iDP;
            WorkerName = workerName;
            FieldName = fieldName;
            JobName = jobName;
            Cost = cost;
            PhoneNumber = phoneNumber;
            Detail = detail;
            City = city;
            District = district;
            Experience = experience;
            Time = time;
        }

        public string idp { get => IDP; set => IDP = value; }
        public string Workername { get => WorkerName; set => WorkerName = value; }
        public string fieldname { get => FieldName; set => FieldName = value; }
        public string jobname { get => JobName; set => JobName = value; }
        public string cost { get => Cost; set => Cost = value; }
        public string phonenumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string detail { get => Detail; set => Detail = value; }
        public string city { get => City; set => City = value; }
        public string district { get => District; set => District = value; }
        string experience { get => Experience; set => Experience = value; }
        public string time { get => Time; set => Time = value; }

    }
}
