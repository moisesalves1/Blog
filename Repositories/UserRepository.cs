using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories 
{
    public class UserRepository
    {
        public IEnumerable<User> Get()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.GetAll<User>();
                
            }
        }
    }
}