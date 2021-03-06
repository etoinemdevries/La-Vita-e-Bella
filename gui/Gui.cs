﻿using La_Vita_e_Bella.ticket;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

/* Robert */
namespace La_Vita_e_Bella.gui
{
    public class Gui : Form
    {
        public readonly bool logout;
        private List<Asset> assets = new List<Asset>();

        protected Gui(bool logout)
        {
            /* Set window title and fullscreen */
            Name = Text = "La Vita e Bella";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            /* Get screen bounds and set window bounds */
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            SetBounds(0, 0, bounds.Width, bounds.Height);

            /* Registers paint event */
            Paint += OnPaint;

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
                /* Adds logout button if it should be added */
                Button button = AddButton("Logout", Color.FromArgb(80, 80, 250), Width - 102, 0, 60, 20);
                button.Click += OnClick;
            }
            
            /* Bring window to front as focussed */
            TopMost = true;
            BringToFront();
            Focus();
        }

        private void OnPaint(object sender, EventArgs args)
        {
            if (!(args is PaintEventArgs)) return;
            PaintEventArgs eventArgs = (PaintEventArgs)args;

            foreach(Asset asset in assets)
            {
                eventArgs.Graphics.DrawImage(asset.img, asset.point);
            }
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
                    Program.instance.Show(Program.instance.login);

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

        /* Adds a new image */
        protected Asset AddAsset(Point point, Image img)
        {
            Asset asset = new Asset(point, img);
            assets.Add(asset);
            return asset;
        }

        /* Adds a ticket to the gui */
        protected Panel AddTicket(Ticket ticket, int x, int y)
        {
            Panel border = new Panel
            {
                BackColor = Color.FromArgb(25, 25, 25)
            };

            Panel panel = new Panel
            {
                BackColor = Color.FromArgb(105, 105, 105)
            };

            Panel line = new Panel
            {
                BackColor = Color.FromArgb(25, 25, 25)
            };

            Label table = new Label
            {
                Text = ticket.table.ToString(),
                Font = new Font("Arial", 15)
            };
            
            border.SetBounds(x - 1, y - 1, 302, 402);
            line.SetBounds(0, 20, 300, 1);
            panel.SetBounds(1, 1, 300, 400);

            panel.Controls.Add(line);
            panel.Controls.Add(table);
            border.Controls.Add(panel);
            Controls.Add(border);
            return panel;
        }
    }

    public class Asset
    {
        public readonly Point point;
        public readonly Image img;

        public Asset(Point point, Image img)
        {
            this.point = point;
            this.img = img;
        }
    }
}
