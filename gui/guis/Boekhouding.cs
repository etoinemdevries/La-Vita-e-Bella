using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Vita_e_Bella.gui.guis
{
    public class Boekhouding : Gui
    {
        public Boekhouding() : base(true)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Boekhouding
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Boekhouding";
            this.Load += new System.EventHandler(this.Boekhouding_Load);
            this.ResumeLayout(false);

        }

        private void Boekhouding_Load(object sender, EventArgs e)
        {

        }
    }
}
