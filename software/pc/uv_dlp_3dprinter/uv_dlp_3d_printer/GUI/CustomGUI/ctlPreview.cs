using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    public partial class ctlPreview : ctlUserPanel
    {
        public ctlPreview()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen p = new Pen(Style.ForeColor, 4);
            g.DrawRectangle(p, 0, 0, Width, Height);
            if (Text != null)
            {
                SizeF texts = g.MeasureString(Text, Font);
                float posx = ((float)Width - texts.Width) / 2;
                float posy = ((float)Height - texts.Height) / 2;
                g.DrawString(Text, Font, new SolidBrush(Style.ForeColor), posx, posy);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
    }
}
