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

        [STAThread]
        public static void Main(string[] args)
        {
            // TODO: Login screen
            Application.Run(kassa);
        }

        static Program()
        {
            kassa = new Kassa();
            login = new Login();
        }

        /* Shows a gui and hides the current gui */
        public static void Show(Gui showed, Gui current)
        {
            showed.Visible = true;
            current.Visible = false;
        }
    }
}
