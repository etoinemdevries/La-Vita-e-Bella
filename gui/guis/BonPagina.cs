using La_Vita_e_Bella.ticket;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;


/* wenhao */
namespace La_Vita_e_Bella.gui
{
    public class BonPagina : Gui

    {

        public BonPagina() : base(true)
        {

            Panel line = new Panel();
            line.BackColor = Color.FromArgb(25, 25, 25);
            line.SetBounds(0, 45, 436, 3);

            Panel border = new Panel();
            border.BackColor = Color.FromArgb(25, 25, 25);
            border.SetBounds(1, 1, 436, 867);

            Panel bon = new Panel();
            bon.SetBounds(1, 1, 434, 865);
            bon.BackColor = Color.FromArgb(105, 105, 105);

            this.Controls.Add(border);
            this.Controls.Add(bon);
            border.Controls.Add(bon);
            bon.Controls.Add(line);
            

            Panel select = new Panel();
            select.SetBounds(440, 92, 1000, 770);
            select.BackColor = Color.White;
            this.Controls.Add(select);
           
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BonPagina
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "BonPagina";
            this.Load += new System.EventHandler(this.BonPagina_Load);
            this.ResumeLayout(false);

        }

        private void BonPagina_Load(object sender, EventArgs e)
        {

        }
    }
}
