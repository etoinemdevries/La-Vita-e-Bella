using La_Vita_e_Bella.gui;
using La_Vita_e_Bella.gui.guis;
using System;
using System.Windows.Forms;

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
            /* Start update loop */
            Application.Run(current = login);
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
