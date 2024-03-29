using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiViecLam.model
{
    internal class JobField
    {
        private string IDJFl;
        private string FieldName;

        public JobField(string iDJFl, string fieldName)
        {
            IDJFl = iDJFl;
            FieldName = fieldName;
        }

        public string idjf { get => IDJFl; set => IDJFl = value; }
        public string fieldname { get => FieldName; set => FieldName = value; }
    }
}
