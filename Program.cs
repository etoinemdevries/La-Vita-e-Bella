using La_Vita_e_Bella.gui;
using La_Vita_e_Bella.gui.guis;
using La_Vita_e_Bella.utils;
using System;
using System.Data;
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
        public readonly Boekhouding boekhouding;
        public readonly Kassa kassa;
        public readonly Login login;
        public readonly Keuken keuken;
        public readonly BonPagina bonpagina;
        public Gui current;


        [STAThread]
        public static void Main(string[] args)
        {

            //Console.WriteLine(result.Rows.Find(result.PrimaryKey));
            
            /* Start application */
            new Program();

            
            /*
            Connection connection = new Connection("192.168.43.21", 1337);
            new Thread(() =>
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
            instance = this;
            boekhouding = new Boekhouding();
            kassa = new Kassa();
            login = new Login();
            keuken = new Keuken();
            bonpagina = new BonPagina();

            current = bonpagina;
            Application.Run(current);
        }
        
        /* Shows a gui and hides the current gui */
        public void Show(Gui showed)
        {
            showed.Visible = true;
            current.Visible = false;
            current = showed;
        }
    }
}
