using System;
using System.Drawing;
using System.Windows.Forms;


/* wenhao */
namespace La_Vita_e_Bella.gui
{
    public class Keuken : Gui

    {

        public Keuken() : base(true)

        {
            
            Button verstuur = new Button();
            verstuur.Text = "verstuur";
            verstuur.Location = new Point(1310, 765);
            verstuur.Size = new Size(120, 60);
            this.Controls.Add(verstuur);
            verstuur.ForeColor = System.Drawing.Color.White;
            verstuur.Font = new Font("", 18);

           for(int i = 0; i<8; i++) {
                Panel bon2 = new Panel();
                bon2.SetBounds(10 + (295 * (i % 4)), (i < 4 ? 25 : 450), 285, 400);
                bon2.BackColor = Color.White;
                this.Controls.Add(bon2);

                Button verstuur2 = new Button();
                verstuur2.Text = "verstuur";
                verstuur2.SetBounds(82, 350, 120, 60);
                verstuur2.Font = new Font("", 18);
                verstuur2.BackColor = Color.Gray;
                verstuur2.ForeColor = Color.White;
                bon2.Controls.Add(verstuur2);
                
                
            }

            Panel bon = new Panel();
            bon.Location = new Point(1200, 25);
            bon.Size = new Size(334, 800);
            bon.BackColor = Color.White;
            this.Controls.Add(bon);


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Keuken
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Keuken";
            this.Load += new System.EventHandler(this.Keuken_Load);
            this.ResumeLayout(false);

        }

        private void Keuken_Load(object sender, EventArgs e)
        {

        }
    }
}

