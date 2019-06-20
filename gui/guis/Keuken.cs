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
            verstuur.Location = new Point(1310, 730);
            verstuur.Size = new Size(120, 60);
            this.Controls.Add(verstuur);
            verstuur.ForeColor = System.Drawing.Color.White;
            verstuur.Font = new Font("", 18);

            Panel bon = new Panel();
            bon.Location = new Point(1200, 25);
            bon.Size = new Size(334, 800);
            bon.BackColor = Color.White;
            this.Controls.Add(bon);


        }

  

    }
}

