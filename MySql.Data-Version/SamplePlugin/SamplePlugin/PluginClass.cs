using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MySql.Data.MySqlClient;

namespace SamplePlugin
{
    [Plugin(PluginName = "Sample Plugin MySql.Data", Description = "Using MySql.Data 8.0.22", Author = "")]
    public class Class1 : Plugin
    {
        protected override void OnEnable()
        {
            string server = "127.0.0.1";
            string database = "database";
            string uid = "user";
            string password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
        }
    }
}
