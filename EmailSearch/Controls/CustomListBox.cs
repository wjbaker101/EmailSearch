using System;
using System.Drawing;
using System.Windows.Forms;

namespace Email_Search
{
    public class CustomListBox : Control
    {
        // The listbox the controls uses
        private ListBox Listbox;

        /*
         * Sets the position, size and style of the listbox.
         */
        public CustomListBox()
        {
            this.Listbox = new ListBox();
            this.Listbox.BorderStyle = BorderStyle.None;
            this.Listbox.IntegralHeight = false;
            this.Listbox.Location = new Point(1, 1);
            this.Listbox.Size = new Size(this.Width - 2, this.Height - 2);
            this.Controls.Add(this.Listbox);
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
         * Whenever this control's font is changed, changes the listbox font to match it.
         */
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.Listbox.Font = this.Font;
        }

        /*
         * Whenever this control's size is changed, changes the listbox size.
         */
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Listbox.Size = new Size(this.Width - 2, this.Height - 2);
        }

        /*
         * Public getter to find the listbox.
         */
        public ListBox getListBox()
        {
            return this.Listbox;
        }
    }
}
