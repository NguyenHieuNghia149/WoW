using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace TheGioiViecLam.model
{
    public class Review
    {
        public int IDP { get; set; }
        public string WID { get; set; }
        public double? Rating { get; set; }
        public string ReviewText { get; set; }
        public byte[] Img { get; set; }
        public string CEmail { get; set; }

        public Review(int idp, string wid, double? rating, string reviewText, byte[] img, string cEmail)
        {
            IDP = idp;
            WID = wid;
            Rating = rating;
            ReviewText = reviewText;
            Img = img;
            CEmail = cEmail;
        }
    }
}
