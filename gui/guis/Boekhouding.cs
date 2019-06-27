using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using La_Vita_e_Bella.utils;

/* kevin */
namespace La_Vita_e_Bella.gui.guis
{
    public class Boekhouding : Gui
    {
        public string[] stuff = {"123","12455","8887","98653"};
        public int Textposition;
        public Boekhouding() : base(true)
        {
            
            DataTable result = DBConnection.Query("SELECT * FROM `bonnen`");
             


            DataGridView Bonnen = new DataGridView();
            Bonnen.SetBounds(40, 60, 600, 250);
            Bonnen.DataSource = result;
            Controls.Add(Bonnen);

           //DataGridView.Auto column = Bonnen.Columns[0];
            //column.Width = 60;

            //Bonnen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Bonnen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Bonnen.Columns[2].Width = 60;

            AddLabel("Boekhouding La vite e bella", Color.LightGray,40,10,400,25).Font = new Font("Arial",16);
            // AddLabel("Even more bullshit", Color.LightGray, 40, 80, 200, 25).Font = new Font("Arial", 16);

            /*
            foreach (string s in stuff)
            {
                AddLabel(s, Color.LightGray, 40, Textposition, 200, 25).Font = new Font("Arial", 16);
                Textposition += 40;
            }
            */
        }
        

        

        public void Table()
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
