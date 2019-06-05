using La_Vita_e_Bella.gui;
using La_Vita_e_Bella.gui.guis;
using System;
//using System.Windows.Forms;

namespace La_Vita_e_Bella
{
    /* Main application class */
    public static class Program
    {
        /* Guis */
        public static readonly Kassa kassa;
        public static readonly Login login;
        public static readonly Keuken keuken;
        public static Gui current;

        [STAThread]
        public static void Main(string[] args)
        {
            /* Start application */
            //Application.Run(current = kassa);

            Server server = new Server(1337);
            server.OnConnect += OnConnect;
            server.Run();
        }

        private static void OnConnect(object sender, EventArgs args)
        {
            if (!(args is ConnectArgs))
            {
                Console.WriteLine("Invalid args");
                return;
            }

            ConnectArgs connectArgs = (ConnectArgs) args;
            Console.WriteLine("New connection: " + sender);
            Connection connection = connectArgs.connection;

            while (connection.IsConnected())
            {
                Console.WriteLine("MSG: " + connection.Read());
            }
        }

        static Program()
        {
            kassa = new Kassa();
            login = new Login();
            keuken = new Keuken();
        }
        
        /* Shows a gui and hides the current gui */
        public static void Show(Gui showed)
        {
            showed.Visible = true;
            current.Visible = false;
            showed = current;
        }
    }
}
