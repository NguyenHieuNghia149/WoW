using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    internal class Job
    {
        private string IDJ;
        private string JobName;
        private string FieldName;

        public Job()
        {
        }

        public Job(string iDJ, string jobName, string fieldName)
        {
            IDJ = iDJ;
            JobName = jobName;
            FieldName = fieldName;
    }

        public string idj { get => IDJ; set => IDJ = value; }
        public string jobname { get => JobName; set => JobName = value; }
        public string fieldname { get => FieldName; set => FieldName = value; }
    }
}
