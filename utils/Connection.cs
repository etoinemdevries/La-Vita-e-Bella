using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

/* Robert */
namespace La_Vita_e_Bella
{
    public class Client
    {
        public static readonly Encoding encoding = Encoding.UTF8;
        private Socket socket;

        public Client(IPEndPoint point)
        {
            socket = new Socket(point.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(point);

            Console.WriteLine("Connected client to {0}:{1}", point.Address, point.Port);
        }

        public Client(Socket socket)
        {
            this.socket = socket;
        }

        ~Client()
        {
            Disconnect();
        }

        /* Reads a message from the server */
        public string Read()
        {
            if (!IsConnected()) return "";

            byte[] bytes = new byte[1024];
            int result = socket.Receive(bytes);

            return encoding.GetString(bytes, 0, result);
        }

        /* Sends a message to the server */
        public bool Write(string msg)
        {
            if (!IsConnected()) return false;

            socket.Send(encoding.GetBytes(msg));
            return true;
        }

        /* Disconnects the socket from the server */
        public void Disconnect()
        {
            if (!IsConnected()) return;
            socket.Disconnect(false);
        }

        /* Gets if the socket is still connected to the server */
        public bool IsConnected()
        {
            return socket.Connected;
        }
    }

    public class Server
    {
        private Socket socket;

        public Server(int port, int limit)
        {
            IPAddress address = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];
            IPEndPoint point = new IPEndPoint(address, port);

            socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(point);
            socket.Listen(limit);

            Console.WriteLine("Hosting server on {0}:{1}", point.Address, point.Port);
        }

        ~Server()
        {
            Shutdown();
        }

        /* On connect event */
        public event EventHandler OnConnect;

        /* Runs server */
        public void Run()
        {
            while (true)
            {
                Socket socket = this.socket.Accept();
                new Thread(() => OnConnect(this, new ConnectArgs(new Client(socket)))).Start();
            }
        }

        /* Shuts down the server */
        public void Shutdown()
        {
            if (!IsOpen()) return;
            socket.Disconnect(false);
        }

        /* Gets if the server is open */
        public bool IsOpen()
        {
            return socket.Connected;
        }
    }

    public class ConnectArgs : EventArgs
    {
        private readonly Client client;

        public ConnectArgs(Client client)
        {
            this.client = client;
        }

        public Client GetClient()
        {
            return client;
        }
    }
}
