using La_Vita_e_Bella.gui;
using La_Vita_e_Bella.gui.guis;
using System;
using System.Threading;
using System.Windows.Forms;

namespace La_Vita_e_Bella
{
    /* Main application class */
    public class Program
    {
        public static Program instance;
        
        /* Guis */
        public readonly Kassa kassa;
        public readonly Login login;
        public readonly Keuken keuken;
        public Gui current;

        [STAThread]
        public static void Main(string[] args)
        {
            /* Start application */
            //Application.Run(current = kassa);
            Connection connection = new Connection("192.168.43.21", 1337);
            Console.WriteLine("From: " + connection.Read());
            new Thread(() => Run(connection)).Start();

            while (true)
            {
                Console.WriteLine(connection.Read());
            }
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
