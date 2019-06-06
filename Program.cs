using La_Vita_e_Bella.gui;
using La_Vita_e_Bella.gui.guis;
using La_Vita_e_Bella.utils;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace La_Vita_e_Bella
{
    /* Main application class */
    public class Program
    {
        public static Program instance;
        private static List<Connection> connections = new List<Connection>();
        
        /* Guis */
        public readonly Kassa kassa;
        public readonly Login login;
        public readonly Keuken keuken;
        public Gui current;

        [STAThread]
        public static void Main(string[] args)
        {
            /* Start application */
            // new Program();
            Server server = new Server(1337);
            server.OnConnect += OnConnect;

            while (true)
            {
                string msg = Console.ReadLine();

                foreach(Connection connection in connections)
                {
                    connection.Write(msg);
                }
            }
        }
        
        public static void OnConnect(object sender, EventArgs args)
        {
            if (!(args is ConnectArgs)) return;
            Connection connection = ((ConnectArgs) args).connection;
            connections.Add(connection);

            foreach (Connection conn in connections)
            {
                Console.WriteLine("{0} connected", connection.GetName());
                conn.Write(connection.GetName() + " connected");
            }
            
            while (connection.IsConnected())
            {
                string read = connection.Read();
                if (read.Equals(""))
                {
                    connections.Remove(connection);

                    foreach (Connection conn in connections)
                    {
                        Console.WriteLine("{0} disconnected", connection.GetName());
                        conn.Write(conn.GetName() + " disconnected");
                    }

                    break;
                }

                foreach (Connection conn in connections)
                {
                    if (conn == connection) continue;
                    Console.WriteLine("[{0}] {1}", connection.GetName(), read);
                    conn.Write("[" + connection.GetName() + "] " + read);
                }
            }
        }

        private Program()
        {
            kassa = new Kassa();
            login = new Login();
            keuken = new Keuken();

            current = login;
            Application.Run(login);
        }
        
        /* Shows a gui and hides the current gui */
        public void Show(Gui showed)
        {
            showed.Visible = true;
            current.Visible = false;
            showed = current;
        }
    }
}
