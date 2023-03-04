using MySql.Data.MySqlClient;

namespace Ucheb_5
{
    class DBUtils
    {
        public static MySqlConnection GetDbConnection()
        {
            string host = "localhost";  // Имя хоста.
            int port = 3306;  // Имя пользователя.
            string database = "ucheb_5"; // Вводим название базы данных, имеющейся в программе MySQL.
            string user = "root"; // Логин в MySQL.
            string password = "root"; // Пароль в MySQL.

            return DBMySQLUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}
