using System;
namespace SingletonDesignPattern
{
	public class TableServers
	{
        private static readonly TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("Hassan");
            servers.Add("Raza");
            servers.Add("Ali");
            servers.Add("Ahmad");
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string getNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;
            if (nextServer >= servers.Count)
                nextServer = 0;
            return output;
        }
    }
}

