using System;
using System.Windows.Forms;

namespace La_Vita_e_Bella
{
    /* Main application class */
    public class Program : Form
    {
        [STAThread]
        public static void Main(string[] args)
        {
            /* Show gui */
            new Program().ShowDialog();
        }

        private Program()
        {
            Text = "epic";
        }
    }
}
