using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

/* Robert */
namespace La_Vita_e_Bella.utils
{
    public class Connection
    {
        public static readonly Encoding encoding = Encoding.UTF32;
        private TcpClient client;

        public Connection(string ip, int port)
        {
            client = new TcpClient(ip, port);
            Console.WriteLine("Connected client to {0}:{1}", ip, port);
        }

        public Connection(TcpClient client)
        {
            this.client = client;
        }

        ~Connection()
        {
            Disconnect();
        }

        /* Reads a message from the server */
        public string Read()
        {
            if (!IsConnected()) return "";
            byte[] bytes = new byte[1024];

            int received = client.GetStream().Read(bytes, 0, bytes.Length);
            return encoding.GetString(bytes, 0, received);
        }

        /* Sends a message to the server */
        public bool Write(string msg)
        {
            if (!IsConnected()) return false;
            byte[] bytes = encoding.GetBytes(msg);

            client.GetStream().Write(bytes, 0, bytes.Length);
            return true;
        }

        /* Gets the remote connections ip and port */
        public string GetName()
        {
            IPEndPoint point = ((IPEndPoint)client.Client.RemoteEndPoint);
            return point.Address + ":" + point.Port;
        }

        /* Disconnects the socket from the server */
        public void Disconnect()
        {
            if (!IsConnected()) return;
            client.Close();
        }

        /* Checks if the connection is still open */
        public bool IsConnected()
        {
            try
            {
                return !(client.Client.Poll(50, SelectMode.SelectRead) && client.Client.Available == 0);
            }
            catch
            {
                return false;
            }
        }
    }

    public class Server
    {
        private TcpListener server;

        public Server(int port)
        {
            IPEndPoint point = new IPEndPoint(IPAddress.Any, port);
            server = new TcpListener(point);
            server.Start();

            Console.WriteLine("Hosting server on port {0}", point.Port);
        }

        ~Server()
        {
            Shutdown();
        }

        /* On connect event */
        public event EventHandler OnConnect;

        public void Run()
        {
            while (IsOpen())
            {
                if (!server.Pending())
                {
                    Thread.Sleep(500);
                    continue;
                }

                new Thread(() =>
                {
                    Connection connection = new Connection(server.AcceptTcpClient());
                    OnConnect(this, new ConnectArgs(connection));
                }).Start();
            }
        }

        /* Shuts down the server */
        public void Shutdown()
        {
            if (!IsOpen()) return;
            server.Stop();
        }

        /* Gets if the server is open */
        public bool IsOpen()
        {
            return server.Server.Available == 0;
        }
    }

    public class ConnectArgs : EventArgs
    {
        public readonly Connection connection;

        public ConnectArgs(Connection connection)
        {
            this.connection = connection;
        }
    }
}