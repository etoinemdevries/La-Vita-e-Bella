using System;
using System.Drawing;
using System.Windows.Forms;

/* Étoine */ //wenhao
namespace La_Vita_e_Bella.gui.guis
{
    public class Login : Gui
    {
        private TextBox loginbox;

        public Login() : base(false)
        {
            AddImage("logo.png");

            Button login = new Button();
            login.Text = "login";
            login.Font = new Font("", 18);
            login.SetBounds(855, 400, 80, 40);
            login.BackColor = Color.Gray;
            login.ForeColor = Color.White;
            login.Click += OnLogin;

            this.Controls.Add(login);

            loginbox = new TextBox();
            loginbox.SetBounds(700, 400, 155, 40);
            loginbox.Font = new Font("verdana", 18);
            loginbox.BackColor = Color.White;
            loginbox.ForeColor = Color.Black;
            this.Controls.Add(loginbox);

        }

        public void OnLogin(object sender, EventArgs args)
        {
            switch(loginbox.Text)
            {
                case "0000":
                    Name = Text = "Kassa";
                    Program.instance.Show(Program.instance.kassa);
                    break;
                case "1111":
                    Name = Text = "Keuken";
                    Program.instance.Show(Program.instance.keuken);
                    break;
                case "2222":
                    Name = Text = "Boekhouding";
                    Program.instance.Show(Program.instance.boekhouding);
                    break;
                case "3333":
                    Name = Text = "BonPagina";
                    Program.instance.Show(Program.instance.bonpagina);
                    break;
                default:
                    break;
            }
        }

        private void AddImage(string filename)
        {
            Image image = Image.FromFile(filename);
            Rectangle rectangle = new Rectangle((Width - image.Width) / 2, (Height - image.Height) / 2, image.Width, image.Height);
            
            AddAsset(rectangle, image);
        }

        private void AddImage(string filename, Rectangle rectangle)
        {
            Image image = Image.FromFile(filename);
            AddAsset(rectangle, image);
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
