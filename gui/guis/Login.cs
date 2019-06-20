using System;
using System.Drawing;
using System.Windows.Forms;

/* Étoine */
namespace La_Vita_e_Bella.gui.guis
{
    public class Login : Gui
    {
        private CheckBox checkBox1;

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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(572, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.checkBox1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
