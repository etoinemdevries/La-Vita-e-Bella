using System;
using System.Drawing;
using System.Windows.Forms;

/* Étoine */
namespace La_Vita_e_Bella.gui.guis
{
    public class Login : Gui
    {
        public Login()
        {
            Name = Text = "Hallo";
            hi();
        }

        public void hi()
        {
            Button next = AddButton("->", Color.White, Width - 61, 0, 20, 20);
            Label hallo = AddLabel("Hallo", Color.Red, 50, 10, 20, 20);
            next.Click += volgende;
        }

        private void volgende(object butt, EventArgs args)
        {
            Hide();
            Show();
        }
    }
}
