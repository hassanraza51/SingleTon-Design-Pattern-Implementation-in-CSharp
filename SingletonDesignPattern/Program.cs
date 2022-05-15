// See https://aka.ms/new-console-template for more information
using System;
namespace SingletonDesignPattern
{
    public class Program
    {
        static TableServers host1List = TableServers.GetTableServers();
        static TableServers host2List = TableServers.GetTableServers();
        static TableServers host3List = TableServers.GetTableServers();

        public static void Main(string[] args)
        {
            //TableServers servers = TableServers.GetTableServers();
            for (int i = 0; i < 6; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
                Host3GetNextServer();
            }
            Console.ReadLine();
        }
        private static void Host1GetNextServer()
        {
            Console.WriteLine("Next Server is: " + host1List.getNextServer());
        }
        private static void Host2GetNextServer()
        {
            Console.WriteLine("Next Server is: " + host2List.getNextServer());
        }
        private static void Host3GetNextServer()
        {
            Console.WriteLine("Next Server is: " + host3List.getNextServer());
        }
    }
}