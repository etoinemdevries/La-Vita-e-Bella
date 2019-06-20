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
            //NewImage("boorbanner.jpg");
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

            /* When there is a connection, repeat to the server console what room you logged into */
            //connection.Write("Room: " + Name);

        }

        private void NewImage(string filename)
        {
            Image newImage = Image.FromFile(filename);
            Point ulCorner = new Point((Width - newImage.Width) / 2, (Height - newImage.Height) / 2);

            AddAsset(ulCorner, newImage);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
