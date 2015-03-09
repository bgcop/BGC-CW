using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UV_DLP_3D_Printer._3DEngine;
using UV_DLP_3D_Printer.Util.Sequence;
namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    public partial class ctlImageButton : ctlAnchorable
    { 
        Image mImage;
        Image mCheckImage;
        Rectangle mDstrc;
        Rectangle mSrcrc;
        Rectangle mCheckrc;
        //int nSubImages = 4;
        int mSubImgWidth, mSubChkImgWidth;
        String mGLImage;
        C2DImage mGLImageCach;
        //ButtonStyle mButtStyle;
        String mOnClickCallback = null;


        [Description("Image composesed of all 4 button states"), Category("Data")]
        public Image Image
        {
            get { return mImage; }
            set
            {
                mImage = value;
                if (mImage != null)
                {
                    mSubImgWidth = mImage.Width / Style.SubImgCount;
                    mSrcrc = new Rectangle(0, 0, mSubImgWidth, mImage.Height);
                    ScaleImage();
                }
            }
        }

        [Description("Image of check/uncheck mark"), Category("Data")]
        public Image CheckImage
        {
            get { return mCheckImage; }
            set
            {
                mCheckImage = value;
                if (mCheckImage != null)
                {
                    mSubChkImgWidth = mCheckImage.Width / 2;
                    mCheckrc = new Rectangle(0, 0, mSubChkImgWidth, mCheckImage.Height);
                }
            }
        }

        [Description("GL image name"), Category("Data")]
        public String GLImage
        {
            get { return mGLImage; }
            set
            {
                mGLImage = value;
                mGLImageCach = null;
            }
        }

        [DefaultValue(null)]
        [Description("On Click callback command name"), Category("Data")]
        public String OnClickCallback
        {
            get { return mOnClickCallback; }
            set { mOnClickCallback = value; }
        }

        public ctlImageButton()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            InitializeComponent();
        }

        void ScaleImage()
        {
            if (mImage == null)
                return;
            if ((Height == 0) || (Width == 0))
                return;
            float iratio = (float)mSubImgWidth / (float)Image.Height;
            float cratio = (float)Width / (float)Height;
            if (iratio > cratio)
            {
                int h = (int)((float)Width / iratio);
                mDstrc = new Rectangle(0, (Height - h) / 2, Width, h);
            }
            else
            {
                int w = (int)((float)Height * iratio);
                mDstrc = new Rectangle((Width - w) / 2, 0, w, Height);
            }
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ScaleImage();
        }

        void OnPaint4(Graphics gr, Image img)
        {
            int index = (int)mCtlState;
            if (Enabled == false)
                index = 3;
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            mSrcrc.X = mSubImgWidth * index;
            gr.DrawImage(img, mDstrc, mSrcrc, GraphicsUnit.Pixel);
        }

        void OnPaint1(Graphics gr, Image inimg)
        {
            Image img = C2DGraphics.ColorizeBitmap((Bitmap)inimg, GetPaintColor(Style));
            //Rectangle srcrc = new Rectangle(0, 0, img.Width, img.Height);
            float scale = 1;
            if (mCtlState == CtlState.Hover)
                scale = Style.HoverSize / 100;
            if (mCtlState == CtlState.Pressed)
                scale = Style.PressedSize / 100;

            RectangleF dstrc;
            if ((scale < 0.999f) || (scale > 1.001f))
            {
                float w = (float)mDstrc.Width * scale;
                float h = (float)mDstrc.Height * scale;
                float scx = ((float)mDstrc.Width - w) / 2f;
                float scy = ((float)mDstrc.Height - h) / 2f;
                dstrc = new RectangleF(mDstrc.X + scx, mDstrc.Y + scy, w, h);
            }
            else
            {
                dstrc = mDstrc;
            }
            gr.DrawImage(img, dstrc);
        }
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (GLDisplay)
            {
                base.OnPaint(pevent);
                return;
            }
            Image img = mImage;
            if (img == null)
                img = UVDLPApp.Instance().m_2d_graphics.GetBitmap(mGLImage);
            if (img == null)
                return;
            Graphics gr = pevent.Graphics;
            if (Style.SubImgCount == 4)
                OnPaint4(gr, img);
            if (Style.SubImgCount == 1)
                OnPaint1(gr, img);

            if (mImage != null)
            {
                if (Enabled && (mCheckImage != null))
                {
                    mCheckrc.X = Checked ? mSubChkImgWidth : 0;
                    gr.DrawImage(mCheckImage, mDstrc, mCheckrc, GraphicsUnit.Pixel);
                }
            }
            //base.OnPaint(pevent);
        }

        //public override void ApplyStyle(ControlStyle ct) { } // dummy fuction to eliminate compilation errors 
        public override void ApplyStyle(GuiControlStyle ct)
        {
            base.ApplyStyle(ct);

            if (ct.ForeColor.IsValid())
                ForeColor = ct.ForeColor;
            if (ct.BackColor.IsValid())
                BackColor = ct.BackColor;
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            OnClick(e);
        }

        public void DoClick(EventArgs e) 
        {
            OnClick(e);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (mOnClickCallback == null)
                return;
            Object retobj = UVDLPApp.Instance().m_callbackhandler.Activate(mOnClickCallback, this);
            if(retobj != null)
            {
                //if the return object is null, then this was probably a successful call
                //if the return object type is boolean, and the value is false,
                //then this could be a sequence to execute
                // I'm debating whether this code should get put into the CallbackHandler code
                // as-is, only buttons can trigger sequences, this may change in the future.
                try
                {
                    Boolean val = (System.Boolean)retobj;
                    if (val == false) 
                    {
                        // try to execute it as a sequence
                        SequenceManager.Instance().ExecuteSequence(mOnClickCallback); 
                    }
                }
                catch (Exception) { }
            }
            
        }

        private void InitializeComponent()
        {
        }

        void GLPaint4(C2DGraphics gr)
        {
            int index = (int)mCtlState;
            if (Enabled == false)
                index = 3;
            if (mGLImageCach != null)
            {
                gr.SetColor(Color.White);
                mSrcrc.X = mSubImgWidth * index;
                gr.Image(mGLImageCach, mSubImgWidth * index, 0, mSubImgWidth, mGLImageCach.h, 0, 0, Width, Height);
                /*if (Enabled && (mCheckImage != null))
                {
                    mCheckrc.X = Checked ? mSubChkImgWidth : 0;
                    gr.DrawImage(mCheckImage, mDstrc, mCheckrc, GraphicsUnit.Pixel);
                }*/
            }
        }

        Color GetPaintColor(GuiControlStyle stl)
        {
            if (Enabled == false)
                return stl.DisabledColor;
            Color col = stl.ForeColor;
            switch (mCtlState)
            {
                case CtlState.Hover:
                    /*if (Checked)
                        col = stl.CheckedColor;
                    else*/
                        col = stl.HoverColor;
                    break;

                case CtlState.Normal:
                    if (Checked)
                        col = stl.CheckedColor;
                    break;

                case CtlState.Pressed:
                    col = stl.PressedColor;
                    break;
            }
            return col;
        }

        void GLPaint1(C2DGraphics gr, GuiControlStyle stl)
        {
            gr.SetColor(GetPaintColor(stl));

            float scale = 1;
            if (mCtlState == CtlState.Hover)
                scale = (float)stl.HoverSize / 100f;
            if (mCtlState == CtlState.Pressed)
                scale = (float)stl.PressedSize / 100f;


            if ((scale < 0.999f) || (scale > 1.001f))
            {
                float w = (float)Width * scale;
                float h = (float)Height * scale;
                float scx = ((float)Width - w) / 2f;
                float scy = ((float)Height - h) / 2f;
                gr.Image(mGLImageCach, 0, 0, mGLImageCach.w, mGLImageCach.h, scx, scy, w, h);
            }
            else
            {
                gr.Image(mGLImageCach, 0, 0, mGLImageCach.w, mGLImageCach.h, 0, 0, Width, Height);
            }
        }

        public override void OnGLPaint(C2DGraphics gr)
        {
            base.OnGLPaint(gr);
            if (mGLImageCach == null)
            {
                mGLImageCach = gr.GetImage(mGLImage);
                if (mGLImageCach == null)
                    return;
                mSubImgWidth = mGLImageCach.w / Style.SubImgCount;
            }
            GuiControlStyle stl = Style;
            if (stl.SubImgCount == 4)
                GLPaint4(gr);
            if (stl.SubImgCount == 1)
                GLPaint1(gr, stl);
            C2DImage cimg = stl.CheckedImageCach;
            if (Enabled && (cimg != null))
            {
                int chimgw = cimg.w / 2;
                int posx = Checked ? chimgw : 0;
                gr.SetColor(stl.CheckedColor);
                gr.Image(cimg, posx, 0, chimgw, cimg.h, 0, 0, Width, Height);
            }
        }
    }
}
