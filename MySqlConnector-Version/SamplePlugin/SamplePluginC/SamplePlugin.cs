using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MySqlConnector;

namespace SamplePlugin
{
    [Plugin(PluginName = "Sample Plugin MySqlConnector", Description = "Using MySqlConnector 1.2.0", Author = "")]
    public class PluginClass : Plugin
    {
        //When starting the plugin, it asks you to use the Version 1.0.0. 
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
