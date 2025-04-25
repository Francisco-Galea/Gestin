namespace Gestin.UI.Custom
{
    class BigCheckBox : CheckBox
    {
        public BigCheckBox()
        {
            Text = "Approved";
            TextAlign = ContentAlignment.MiddleRight;
        }

        public override bool AutoSize
        {
            set { base.AutoSize = false; }
            get { return base.AutoSize; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Height = 31;
            Width = 31;
            int squareSide = 31;

            Rectangle rect = new Rectangle(new Point(0, 1), new Size(squareSide, squareSide));

            ControlPaint.DrawCheckBox(e.Graphics, rect, Checked ? ButtonState.Checked : ButtonState.Normal);
        }
    }
}
