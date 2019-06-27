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
            BackColor = Color.FromArgb(25, 25, 25);
            line.SetBounds(0, 20, 300, 3);

            Panel border = new Panel();
            BackColor = Color.FromArgb(25, 25, 25);
            border.SetBounds(1, 1, 436, 868);

            Panel bon = new Panel();
            bon.SetBounds(0, 0, 434, 865);
            bon.BackColor = Color.FromArgb(105, 105, 105);

            this.Controls.Add(bon);
            bon.Controls.Add(line);
            

            Panel select = new Panel();
            select.SetBounds(440, 92, 1000, 770);
            select.BackColor = Color.White;
            this.Controls.Add(select);

            Button pizza = new Button();
            pizza.SetBounds(480, 50, 120, 40);
            pizza.BackColor = Color.White;
            pizza.ForeColor = Color.Black;
            pizza.Font = new Font("", 18);
            pizza.Text = "pizza";
            this.Controls.Add(pizza);

            Button drinken = new Button();
            drinken.SetBounds(640, 50, 120, 40);
            drinken.BackColor = Color.White;
            drinken.ForeColor = Color.Black;
            drinken.Font = new Font("", 18);
            drinken.Text = "drinken";
            this.Controls.Add(drinken);

           
        }
    }
}
