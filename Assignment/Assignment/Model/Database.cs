using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connetionString = "Server=LAPTOP-EJQAL96P;Database=BookManagement;User Id=sa;Password=123;";
            SqlConnection conn = new SqlConnection(connetionString);
            Books = new Books(conn);
        }
    }
}
