using System;
using System.Drawing;
using System.Windows.Forms;


/* wenhao */
namespace La_Vita_e_Bella.gui
{
    public class Keuken : Gui

    {
        private Button button1;
        private CheckBox checkBox1;
        private ListView listView9;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private ListView listView5;
        private ListView listView6;
        private ListView listView7;
        private ListView listView8;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Button button9;
        private ListView listView1;

     

        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView9 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.listView7 = new System.Windows.Forms.ListView();
            this.listView8 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(206, 298);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(110, -1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listView9
            // 
            this.listView9.HideSelection = false;
            this.listView9.Location = new System.Drawing.Point(850, 23);
            this.listView9.Name = "listView9";
            this.listView9.Size = new System.Drawing.Size(356, 578);
            this.listView9.TabIndex = 20;
            this.listView9.UseCompatibleStateImageBehavior = false;
            this.listView9.SelectedIndexChanged += new System.EventHandler(this.listView9_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(214, -1);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(206, 298);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(426, -1);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(206, 298);
            this.listView3.TabIndex = 22;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(638, -1);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(206, 298);
            this.listView4.TabIndex = 23;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // listView5
            // 
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(2, 303);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(206, 298);
            this.listView5.TabIndex = 24;
            this.listView5.UseCompatibleStateImageBehavior = false;
            // 
            // listView6
            // 
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(214, 303);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(206, 298);
            this.listView6.TabIndex = 25;
            this.listView6.UseCompatibleStateImageBehavior = false;
            // 
            // listView7
            // 
            this.listView7.HideSelection = false;
            this.listView7.Location = new System.Drawing.Point(426, 303);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(206, 298);
            this.listView7.TabIndex = 26;
            this.listView7.UseCompatibleStateImageBehavior = false;
            // 
            // listView8
            // 
            this.listView8.HideSelection = false;
            this.listView8.Location = new System.Drawing.Point(638, 303);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(206, 298);
            this.listView8.TabIndex = 27;
            this.listView8.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 31);
            this.button2.TabIndex = 28;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 31);
            this.button3.TabIndex = 29;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 31);
            this.button4.TabIndex = 30;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 31);
            this.button5.TabIndex = 31;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(261, 523);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 31);
            this.button6.TabIndex = 32;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(468, 523);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 31);
            this.button7.TabIndex = 33;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(681, 523);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 31);
            this.button8.TabIndex = 34;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(322, -1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(534, -1);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(746, -1);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(98, 21);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(110, 303);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(98, 21);
            this.checkBox5.TabIndex = 38;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(322, 303);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(98, 21);
            this.checkBox6.TabIndex = 39;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(534, 303);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(98, 21);
            this.checkBox7.TabIndex = 40;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(746, 303);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(98, 21);
            this.checkBox8.TabIndex = 41;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1080, 523);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 65);
            this.button9.TabIndex = 43;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Keuken
            // 
            this.ClientSize = new System.Drawing.Size(1929, 630);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView8);
            this.Controls.Add(this.listView7);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Keuken";
            this.Load += new System.EventHandler(this.Keuken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Keuken_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void listView9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

