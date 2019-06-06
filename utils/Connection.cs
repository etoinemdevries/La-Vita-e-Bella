﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace La_Vita_e_Bella.utils
{
    public class Connection
    {
        public readonly Encoding encoding = Encoding.UTF32;
        private Socket socket;

        public Connection(string ip, int port)
        {
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(ip), port);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(point);

            Console.WriteLine("Connected to {0}:{1}", ip, port);
        }

        public Connection(Socket socket)
        {
            this.socket = socket;
        }

        ~Connection()
        {
            if (IsConnected()) Disconnect();
        }

        /* Reads from the connected pc */
        public string Read()
        {
            if (!IsConnected()) return null;
            byte[] bytes = new byte[1024];

            try
            {
                socket.Receive(bytes);
                string msg = encoding.GetString(bytes);

                if(msg == "Disconnect") Disconnect();
                return msg;
            }
            catch
            {
                return null;
            }
        }

        /* Writes to the connected pc */
        public bool Write(string msg)
        {
            try
            {
                if (!IsConnected()) return false;
                socket.Send(encoding.GetBytes(msg));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /* Disconnects this connection */
        public void Disconnect()
        {
            if (!IsConnected()) return;
            Console.WriteLine("Disconnect");
            socket.Disconnect(false);
        }

        /* Gets if this connection is still opened */
        public bool IsConnected()
        {
            try
            {
                return socket.Poll(50, SelectMode.SelectRead);
            }
            catch
            {
                return false;
            }
        }
    }

    public class Server
    {
        private Socket socket;
        private Thread thread;

        public Server(int port)
        {
            IPEndPoint point = new IPEndPoint(IPAddress.Any, port);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(point);

            Console.WriteLine("Hosting server on port {0}", point.Port);
            new Thread(() => Run()).Start();
        }

        ~Server()
        {
            Shutdown();
        }

        /* Runs the server */
        private void Run()
        {
            while (Opened())
            {
                Thread.Sleep(500);
                if (socket.Blocking || !socket.Connected) continue;

                Connection connection = new Connection(socket.Accept());
                OnConnect(this, new ConnectArgs(connection));
            }
        }

        /* Called on new connection */
        public EventHandler OnConnect;
        
        /* Shuts down this server */
        public void Shutdown()
        {
            thread.Abort();
            socket.Disconnect(false);
        }

        /* Gets wether the server is running */
        public bool Opened()
        {
            return socket.Connected;
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
