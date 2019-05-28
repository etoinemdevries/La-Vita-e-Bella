using System;
using System.Drawing;
using System.Windows.Forms;

namespace La_Vita_e_Bella.gui
{
    public class Gui : Form
    {
        public readonly bool logout;

        protected Gui(bool logout)
        {
            /* Set window properties */
            Name = Text = "La Vita e Bella II";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            /* Get screen bounds and set window bounds */
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            SetBounds(0, 0, bounds.Width, bounds.Height);

            /* Set background color */
            BackColor = Color.FromArgb(75, 75, 75);

            /* Create top bar and button */
            Button close = AddButton("x", Color.FromArgb(250, 80, 80), Width - 20, 0, 20, 20);
            Button minimize = AddButton("_", Color.FromArgb(80, 250, 80), Width - 41, 0, 20, 20);

            /* Register click events for buttons */
            close.Click += OnClick;
            minimize.Click += OnClick;
            this.logout = logout;

            if (logout)
            {
                Button button = AddButton("Logout", Color.FromArgb(80, 80, 250), Width - 102, 0, 60, 20);
                button.Click += OnClick;
            }
            
            /* Bring window to front as focussed */
            TopMost = true;
            BringToFront();
            Focus();
        }

        /* Called on window click */
        private void OnClick(object sender, EventArgs args)
        {
            if (!(sender is Control)) return;
            Control control = (Control) sender;

            switch (control.Text)
            {
                case "x":
                    Console.WriteLine("Exitting...");
                    Application.Exit();
                    break;

                case "_":
                    WindowState = FormWindowState.Minimized;
                    break;

                case "Logout":
                    if (!logout) break;
                    Program.Show(Program.login, this);

                    GC.Collect();
                    break;
            }
        }

        /* Creates a new label */
        protected Label AddLabel(string text, Rectangle rectangle)
        {
            return AddLabel(text, Color.Black, rectangle);
        }

        /* Creates a new label */
        protected Label AddLabel(string text, Color color, Rectangle rectangle)
        {
            return AddLabel(text, color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /* Creates a new label */
        protected Label AddLabel(string text, int x, int y, int width, int height)
        {
            return AddLabel(text, Color.Black, x, y, width, height);
        }

        /* Creates a new label */
        protected Label AddLabel(string text, Color color, int x, int y, int width, int height)
        {
            Label label = new Label
            {
                Text = text,
                ForeColor = color
            };

            label.SetBounds(x, y, width, height);
            Controls.Add(label);
            return label;
        }

        /* Creates a new button */
        protected Button AddButton(string text, Color color, Rectangle rectangle)
        {
            return AddButton(text, color, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /* Creates a new button */
        protected Button AddButton(string text, Color color, int x, int y, int width, int height)
        {
            Button button = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Bounds = new Rectangle(x, y, width, height),
                BackColor = color,
                Text = text
            };

            button.FlatAppearance.BorderSize = 0;
            Controls.Add(button);
            return button;
        }
    }
}
