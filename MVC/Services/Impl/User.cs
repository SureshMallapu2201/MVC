using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC.Services.Impl
{
    public class User : IUser
    {
        public void SaveUser(user user)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Constr"].ToString());
            try
            {
                string query = "insert into UserDetails(FirstName,LastName) values('" + user.FirstName + "','" + user.LastName + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }

        }
    }
}