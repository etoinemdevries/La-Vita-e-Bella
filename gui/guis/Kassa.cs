using La_Vita_e_Bella.ticket;
using System.Collections.Generic;

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

            AddTicket(new Ticket(dishes, 4), 25, 20);
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

        private void Kassa_Load(object sender, System.EventArgs e)
        {

        }
    }
}
