using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace httpserver
{
    public class HttpServer
    {
        public static readonly int DefaultPort = 8888;
        public int Port { get; private set; }

        public HttpServer(int port)
        {
            Port = port;
        }

        public void Run()
        {
            // Start server
            while (true)
            {
                TcpClient clientConnection = 
            }
        }
    }
}
