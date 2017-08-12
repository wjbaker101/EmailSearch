using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Email_Search.EmailSearch.Controls
{
    public class CustomTextbox : Control
    {
        // The textbox the control uses
        private TextBox Textbox;

        /*
         * Sets the size, location and style of the textbox.
         */
        public CustomTextbox()
        {
            this.Textbox = new TextBox();
            this.Textbox.BorderStyle = BorderStyle.None;
            this.Textbox.Location = new Point(2, 2);
            this.Textbox.Font = this.Font;
            this.Controls.Add(this.Textbox);

            this.Textbox.SizeChanged += new EventHandler(Textbox_SizeChanged);
        }

        /*
         * Whenever the textbox size is changed, this control will change size to match it.
         */
        private void Textbox_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, this.Textbox.Height + 3);
        }

        /*
         * Paints the control, adding a blue border around it.
         */
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen BorderPen = new Pen(Color.Blue);
            e.Graphics.DrawRectangle(BorderPen, 0, 0, this.Width - 1, this.Height - 1);
        }

        /*
         * Whenever this control's font is changed, changes the textbox font to match it.
         */
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.Textbox.Font = this.Font;
        }

        /*
         * Whenever this control's size is changed, changes the textbox size.
         */
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Textbox.Size = new Size(this.Width - 4, this.Textbox.Height);
        }

        /*
         * Public getter to find the textbox.
         */
        public TextBox getTextbox()
        {
            return this.Textbox;
        }
    }
}
