﻿using La_Vita_e_Bella.gui;
using La_Vita_e_Bella.gui.guis;
using La_Vita_e_Bella.utils;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net.Sockets;

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
            Connection connection = new Connection("192.168.43.21", 1337);
            while (true)
            {
                connection.Write(Console.ReadLine());
            }
        }
        
        public static void OnConnect(object sender, EventArgs args)
        {
            if (!(args is ConnectArgs)) return;
            Connection connection = ((ConnectArgs) args).connection;
            connections.Add(connection);

            Console.WriteLine("New connection -> " + connection.GetName());
            new Thread(() => Run(connection)).Start();

            while (connection.IsConnected())
            {
                string read = connection.Read();
                Console.WriteLine("[{0}] {1}", connection.GetName(), read);
                
                foreach(Connection conn in connections)
                {
                    if (conn == connection) continue;
                    conn.Write("[" + connection.GetName() + "] " + read);
                }
            }
            */
        }

        private static void Run(Connection connection)
        {
            while (connection.IsConnected())
            {
                connection.Write(Console.ReadLine());
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
