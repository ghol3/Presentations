using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationClient
{
    class AddComponentsToHeadPanel
    {
        // Reference types
        private Panel panel;
        private Form form;
        // Value types
        private int index;
        // Delegate for methods to add buttons
        delegate void Methods();
        private Methods methods;
        /// <summary>
        /// The class constructor for add a header to form.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="formName"></param>
        /// <param name="form1"></param>
        public AddComponentsToHeadPanel(Panel panel, Form form)
        {
            this.form = form;
            this.panel = panel;
            this.index = 1;
        }
        /// <summary>
        /// Adding buttons for minimalization, maximalization and shuts down application.
        /// </summary>
        /// <param name="exit">Value 'bool' for button to shut down application.</param>
        /// <param name="maximize">Value 'bool' for button to maximalize application.</param>
        /// <param name="minimize">Value 'bool' for button to minimalize application.</param>
        public void addButtons(bool exit = true, bool maximize = false, bool minimize = true)
        {
            if (exit) { methods += this.addExit; }
            if (maximize) { methods += this.addMaximize; }
            if (minimize) { methods += this.addMinimize; }
            this.methods();
            this.form.Controls.Add(this.panel);
        }
        private void addExit() { createButton('x'); }
        private void addMaximize() { createButton('M'); }
        private void addMinimize() { createButton('_'); }
        /// <summary>
        /// Creating button.
        /// </summary>
        /// <param name="name">Name and function for the button.</param>
        private void createButton(char name)
        {
            Button button = new Button();
            button.Name = name.ToString();
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = this.panel.BackColor;
            button.Size = new Size(20, 20);
            button.Location = new Point(this.panel.Width - (index * 19) - 1, 0);
            button.Paint += new PaintEventHandler(paint_Button);
            button.Click += new EventHandler(click_Button);
            this.index++;
            panel.Controls.Add(button);
        }
        /// <summary>
        /// Add character to the button.
        /// </summary>
        /// <param name="o">Sending information about objects.</param>
        /// <param name="e">sending information about event.</param>
        private void paint_Button(object o, PaintEventArgs e)
        {
            Button b = (Button)o;
            e.Graphics.DrawString(b.Name, new Font("Microsoft Sans Serif", 10f), new SolidBrush(Color.FromKnownColor(KnownColor.Control)), new PointF(5, 0));
        }
        private void click_Button(object o, EventArgs e)
        {
            Button b = (Button)o;
            switch (b.Name)
            {
                case "x": Application.Exit(); break;
                case "M": this.form.WindowState = FormWindowState.Maximized; break;
                case "_": this.form.WindowState = FormWindowState.Minimized; break;
            }
        }
    }
}
