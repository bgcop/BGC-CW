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
    public partial class ctlTitle : ctlUserPanel
    {
        public ctlTitle()
        {
            InitializeComponent();
        }
        public override void ApplyStyle(GuiControlStyle ct)
        {
            base.ApplyStyle(ct);
            //Button.ApplyStyle(ct);
            if (ct.ForeColor.IsValid())
            {
                ForeColor = ct.ForeColor;
                lblTitle.ForeColor = ct.ForeColor;
            }
            if (ct.BackColor.IsValid())
            {
                BackColor = ct.BackColor;
                lblTitle.BackColor = ct.BackColor;
            }
        }

        public ctlImageButton Button 
        {
            get { return ctlImageButton1; }
        }
        [Description("Image composesed of all 4 button states"), Category("Data")]
        public Image Image
        {
            get { return ctlImageButton1.Image; }
            set
            {
                ctlImageButton1.Image = value;
            }
        }
        [Description("Image of check/uncheck mark"), Category("Data")]
        public Image CheckImage
        {
            get { return ctlImageButton1.CheckImage; }
            set { ctlImageButton1.CheckImage = value; }
        }

        [DefaultValue(null)]
        [Description("On Click callback command name"), Category("Data")]
        public String OnClickCallback
        {
            get { return ctlImageButton1.OnClickCallback; }
            set { ctlImageButton1.OnClickCallback = value; }
        }
        /*[DefaultValue("")] */
        [Description("Display text"), Category("Data")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override String Text
        {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
                Invalidate();
            }
        }
        [Description("Status of check/uncheck"), Category("Data")]
        public bool Checked 
        {
            get { return ctlImageButton1.Checked; }
            set { ctlImageButton1.Checked = value; }
        }
        /*
        [DefaultValue("")]
        [Description("GL font name"), Category("Data")]
        public String GLFont
        {
            get { return mGLFont; }
            set { mGLFont = value; mGLFontCache = null; }
        }
        */
        [DefaultValue(ContentAlignment.MiddleCenter)]
        [Description("GL font name"), Category("Data")]
        public ContentAlignment TextAlign
        {
            get { return lblTitle.TextAlign; }
            set { lblTitle.TextAlign = value; Invalidate(); }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            //ctlImageButton1.Click(sender, e);
            ctlImageButton1.DoClick(e);
            base.OnClick(e);
        }

        private void ctlImageButton1_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        private void lblTitle_MouseEnter(object sender, EventArgs e)
        {
            lblTitle.ForeColor = Style.HoverColor;
        }

        private void lblTitle_MouseLeave(object sender, EventArgs e)
        {
            lblTitle.ForeColor = Style.ForeColor;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lblTitle.ForeColor = Style.PressedColor;
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            lblTitle.ForeColor = Style.HoverColor;
        }
    }
}
