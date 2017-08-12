using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Email_Search
{
    public class CustomRichTextbox : Control
    {
        // The textbox the controls uses
        private RichTextBox Textbox;

        /*
         * Sets the size, location and style of the textbox.
         */
        public CustomRichTextbox()
        {
            this.Textbox = new RichTextBox();
            this.Textbox.Size = new Size(this.Width - 2, this.Height - 4);
            this.Textbox.Location = new Point(1, 2);
            this.Textbox.BorderStyle = BorderStyle.None;
            this.Controls.Add(this.Textbox);
        }

        /*
         * Paints the control, adding a blue border around it.
         */
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Color.Blue), 0, 0, this.Width - 1, this.Height - 1);
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
            this.Textbox.Size = new Size(this.Width - 2, this.Height - 4);
        }

        /*
         * Public getter to find the textbox.
         */
        public RichTextBox getTextbox()
        {
            return this.Textbox;
        }
    }
}
