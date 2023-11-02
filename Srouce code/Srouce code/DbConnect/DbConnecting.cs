using System.Data.SqlClient;

namespace Srouce_code.DbConnect
{
    public class DbConnecting
    {
        SqlConnection _connection;
        readonly string _connectStr = @"Data Source=.;Initial Catalog=CSharp_project;Integrated Security=True";

        public void OpenConnect()
        {
            _connection = new SqlConnection(_connectStr);
            _connection.Open();
        }
        public void CloseConnect()
        {
            _connection.Close();
        }
        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
