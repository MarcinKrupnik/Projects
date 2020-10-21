using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace MarcinKrupnikLab3Zadanie
{
    class SignIn
    {
        private readonly Func<SqlConnection> AppContext = () => new SqlConnection(ConfigurationManager.ConnectionStrings["AppContext"].ConnectionString);

        public SqlCommand QuerySql { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public SignIn(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool SignInMain()
        {
            int valueResault;
            bool isTrue = false;
            string query = "SELECT COUNT(UserLogin.UserName) From UserLogin WHERE UserName = @Username AND Password = @Password";
            using (var connection = AppContext())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResault = (int)QuerySql.ExecuteScalar();
                if (valueResault >= 1)
                {
                    isTrue = true;
                }
                return isTrue;
            }
        }
    }
}

