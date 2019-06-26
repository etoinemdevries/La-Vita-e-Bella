using La_Vita_e_Bella.ticket;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

/* Robert */
namespace La_Vita_e_Bella.gui.guis
{
    public class Kassa : Gui
    {
        public Kassa() : base(true)
        {
            SortedList<int, Dish> dishes = new SortedList<int, Dish>
            {
                { 100, new Dish("dish", 5) }
            };

            AddTicket(new Ticket(dishes, 4), 0, 20);
            AddTicket(new Ticket(dishes, 5), 309, 20);
            AddTicket(new Ticket(dishes, 6), 618, 20);
            AddTicket(new Ticket(dishes, 7), 927, 20);

            Button verstuur = new Button();
            verstuur.Text = "verstuur";
            verstuur.SetBounds(1230, 780, 310, 90);
            verstuur.BackColor = Color.White;
            verstuur.Font = new Font("", 23);
            this.Controls.Add(verstuur);


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Kassa
            // 
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Kassa";
            this.Load += new System.EventHandler(this.Kassa_Load);
            this.ResumeLayout(false);

        }

        private void Kassa_Load(object sender, EventArgs e)
        {

        }
    }
}
