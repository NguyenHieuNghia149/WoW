using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheGioiViecLam.model;
using System.Windows.Forms;
namespace TheGioiViecLam.DAO
{
    public class Dao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();

        public void DeletePost(Post post)
        {
            string sql = string.Format("DELETE from Post where IDP = '{0}'", post.idp);
            db.Execute(sql);
        }

        public void GetDataPostWorker(string account, List<Post> postlist)
        {

        }

      /*  public void LoadCusomerInformation(Customer customer) 
        {
            string sql = string.Format("select CEmail,Fullname, Gender, CBirthday, City, District, PhoneNum, CAddress From Customer Where CEmail = '{0}', Fullname = '{1}', " +
                "Gender = '{2}', CBirthday = '{3}', City = '{4}', District = '{5}',PhoneNum = '{6}', CAddress = '{7}'", 
                customer.email, customer.fullname, customer.gender, customer.birthday, customer.city, customer.district, customer.phoneNumber, customer.address);
           db.Execute(sql);
        }*/
    }
}
