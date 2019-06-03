using System;
using System.Drawing;
using System.Windows.Forms;

/* Étoine */
namespace La_Vita_e_Bella.gui.guis
{
    public class Login : Gui
    {
        public Login() : base(false)
        {
            Name = Text = "Login";
            LoginCheck();
        }

        public void LoginCheck()
        {
            string Hallo = "9999";

            switch(Hallo)
            {
                case "0000":
                    Name = Text = "Kassa";
                    break;
                case "9999":
                    Name = Text = "Keuken";
                    break;
                case "5555":
                    Name = Text = "Boekhouding";
                    break;
                default:
                    Name = Text = "FOUT";
                    break;
            }

        }
    }
}
