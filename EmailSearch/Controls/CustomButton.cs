using System;
using System.Drawing;
using System.Windows.Forms;

namespace Email_Search
{
    public class CustomButton : Control
    {
        // Stores whether the mouse is over the control
        private Boolean IsMouseOver;

        /*
         * Initially sets the variable "IsMouseOver" to false.
         */
        public CustomButton()
        {
            this.IsMouseOver = false;
        }

        /*
         * Paints the control, adding a blue border and a grey background,
         * if the mouse is over the background will be a darker grey.
         */
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen BorderPen = new Pen(Color.Blue);
            SolidBrush TextPen = new SolidBrush(Color.Black);
            SolidBrush FillBrush = new SolidBrush(Color.White);

            if (this.IsMouseOver) FillBrush = new SolidBrush(Color.FromArgb(240, 240, 240));

            e.Graphics.DrawRectangle(BorderPen, 0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.FillRectangle(FillBrush, 1, 1, this.Width - 2, this.Height - 2);

            int TextWidth = (int)e.Graphics.MeasureString(this.Text, this.Font).Width / 2;
            int TextHeight = (int)e.Graphics.MeasureString(this.Text, this.Font).Height / 2;
            e.Graphics.DrawString(this.Text, this.Font, TextPen, (this.Width / 2) - TextWidth, (this.Height / 2) - TextHeight);
        }

        /*
         * Sets the variable "IsMouseOver" to true and refreshes the control.
         */
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.IsMouseOver = true;
            this.Invalidate();
        }

        /*
         * Sets the variable "IsMouseOver" to false and refreshes the control.
         */
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.IsMouseOver = false;
            this.Invalidate();
        }
    }
}
