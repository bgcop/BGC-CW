﻿namespace UV_DLP_3D_Printer.GUI.Controls
{
    partial class ctl3DView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlInfoItemZLev = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.scrollLayer = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlVScroll();
            this.buttRedo = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttUndo = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.numLayer = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.glControl1 = new UV_DLP_3D_Printer.GUI.Controls.ctlGL();
            this.ctlToolTip1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlToolTip();
            this.mainViewSplitContainer.Panel2.SuspendLayout();
            this.mainViewSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainViewSplitContainer
            // 
            this.mainViewSplitContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainViewSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainViewSplitContainer.Name = "mainViewSplitContainer";
            // 
            // mainViewSplitContainer.Panel2
            // 
            this.mainViewSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.mainViewSplitContainer.Panel2.Controls.Add(this.button4);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.button3);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.button2);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.button1);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlInfoItemZLev);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.scrollLayer);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttRedo);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttUndo);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.numLayer);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.glControl1);
            this.mainViewSplitContainer.Panel2.SizeChanged += new System.EventHandler(this.mainViewSplitContainer_Panel2_SizeChanged);
            this.mainViewSplitContainer.Size = new System.Drawing.Size(1200, 700);
            this.mainViewSplitContainer.SplitterDistance = 77;
            this.mainViewSplitContainer.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::UV_DLP_3D_Printer.Properties.Resources._3d;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(2, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 39);
            this.button4.TabIndex = 37;
            this.ctlToolTip1.SetToolTip(this.button4, "Vista Isométrica");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::UV_DLP_3D_Printer.Properties.Resources._3dRIGHT;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(2, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 39);
            this.button3.TabIndex = 36;
            this.ctlToolTip1.SetToolTip(this.button3, "Vista Lateral");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::UV_DLP_3D_Printer.Properties.Resources._3dUP;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(2, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 39);
            this.button2.TabIndex = 35;
            this.ctlToolTip1.SetToolTip(this.button2, "Vista Superior");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttGLTop_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::UV_DLP_3D_Printer.Properties.Resources._3dHome;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 34;
            this.ctlToolTip1.SetToolTip(this.button1, "Vista por Defecto");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttGlHome_Click);
            // 
            // ctlInfoItemZLev
            // 
            this.ctlInfoItemZLev.BackColor = System.Drawing.Color.Navy;
            this.ctlInfoItemZLev.DataBackColor = System.Drawing.Color.RoyalBlue;
            this.ctlInfoItemZLev.DataColor = System.Drawing.Color.White;
            this.ctlInfoItemZLev.DataText = "0";
            this.ctlInfoItemZLev.Gapx = 0;
            this.ctlInfoItemZLev.Gapy = 0;
            this.ctlInfoItemZLev.GLBackgroundImage = null;
            this.ctlInfoItemZLev.GLVisible = false;
            this.ctlInfoItemZLev.GuiAnchor = null;
            this.ctlInfoItemZLev.Location = new System.Drawing.Point(511, 506);
            this.ctlInfoItemZLev.Name = "ctlInfoItemZLev";
            this.ctlInfoItemZLev.Size = new System.Drawing.Size(96, 22);
            this.ctlInfoItemZLev.StyleName = null;
            this.ctlInfoItemZLev.TabIndex = 33;
            this.ctlInfoItemZLev.TitleBackColor = System.Drawing.Color.Navy;
            this.ctlInfoItemZLev.TitleColor = System.Drawing.Color.White;
            this.ctlInfoItemZLev.TitleText = "ZLev";
            this.ctlInfoItemZLev.Visible = false;
            // 
            // scrollLayer
            // 
            this.scrollLayer.Checked = false;
            this.scrollLayer.Gapx = 5;
            this.scrollLayer.Gapy = 5;
            this.scrollLayer.GLBackgroundImage = null;
            this.scrollLayer.GLVisible = false;
            this.scrollLayer.GuiAnchor = null;
            this.scrollLayer.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.scrollLayer.Increment = 10;
            this.scrollLayer.Location = new System.Drawing.Point(928, 153);
            this.scrollLayer.Margin = new System.Windows.Forms.Padding(4);
            this.scrollLayer.Minimum = 1;
            this.scrollLayer.Name = "scrollLayer";
            this.scrollLayer.Size = new System.Drawing.Size(25, 320);
            this.scrollLayer.StyleName = null;
            this.scrollLayer.TabIndex = 32;
            this.scrollLayer.Value = 1;
            this.scrollLayer.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.scrollLayer.Visible = false;
            this.scrollLayer.ValueChanged += new System.EventHandler(this.scrollLayer_ValueChanged);
            // 
            // buttRedo
            // 
            this.buttRedo.BackColor = System.Drawing.Color.Navy;
            this.buttRedo.Checked = false;
            this.buttRedo.CheckImage = null;
            this.buttRedo.Gapx = 60;
            this.buttRedo.Gapy = 10;
            this.buttRedo.GLBackgroundImage = null;
            this.buttRedo.GLImage = null;
            this.buttRedo.GLVisible = false;
            this.buttRedo.GuiAnchor = null;
            this.buttRedo.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttRedo.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRedo;
            this.buttRedo.Location = new System.Drawing.Point(3, 288);
            this.buttRedo.Name = "buttRedo";
            this.buttRedo.Size = new System.Drawing.Size(48, 48);
            this.buttRedo.StyleName = null;
            this.buttRedo.TabIndex = 30;
            this.ctlToolTip1.SetToolTip(this.buttRedo, "Undo");
            this.buttRedo.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttUndo
            // 
            this.buttUndo.BackColor = System.Drawing.Color.Navy;
            this.buttUndo.Checked = false;
            this.buttUndo.CheckImage = null;
            this.buttUndo.Gapx = 10;
            this.buttUndo.Gapy = 10;
            this.buttUndo.GLBackgroundImage = null;
            this.buttUndo.GLImage = null;
            this.buttUndo.GLVisible = false;
            this.buttUndo.GuiAnchor = null;
            this.buttUndo.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttUndo.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttUndo;
            this.buttUndo.Location = new System.Drawing.Point(3, 234);
            this.buttUndo.Name = "buttUndo";
            this.buttUndo.Size = new System.Drawing.Size(48, 48);
            this.buttUndo.StyleName = null;
            this.buttUndo.TabIndex = 29;
            this.ctlToolTip1.SetToolTip(this.buttUndo, "Undo");
            this.buttUndo.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // numLayer
            // 
            this.numLayer.BackColor = System.Drawing.Color.RoyalBlue;
            this.numLayer.ButtonsColor = System.Drawing.Color.Navy;
            this.numLayer.Checked = false;
            this.numLayer.ErrorColor = System.Drawing.Color.Red;
            this.numLayer.FloatVal = 10F;
            this.numLayer.Gapx = 0;
            this.numLayer.Gapy = 200;
            this.numLayer.GLBackgroundImage = null;
            this.numLayer.GLVisible = false;
            this.numLayer.GuiAnchor = null;
            this.numLayer.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Center;
            this.numLayer.Increment = 1F;
            this.numLayer.IntVal = 99999;
            this.numLayer.Location = new System.Drawing.Point(511, 476);
            this.numLayer.MaxFloat = 500F;
            this.numLayer.MaxInt = 99999;
            this.numLayer.MinFloat = -500F;
            this.numLayer.MinimumSize = new System.Drawing.Size(20, 5);
            this.numLayer.MinInt = 1;
            this.numLayer.Name = "numLayer";
            this.numLayer.Size = new System.Drawing.Size(96, 24);
            this.numLayer.StyleName = null;
            this.numLayer.TabIndex = 27;
            this.numLayer.TextFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numLayer.ValidColor = System.Drawing.Color.White;
            this.numLayer.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.numLayer.Visible = false;
            this.numLayer.ValueChanged += new System.EventHandler(this.numLayer_ValueChanged);
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Enabled = false;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1119, 700);
            this.glControl1.TabIndex = 15;
            this.glControl1.Visible = false;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Click += new System.EventHandler(this.glControl1_Click);
            this.glControl1.DoubleClick += new System.EventHandler(this.glControl1_DoubleClick);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyDown);
            this.glControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyUp);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseLeave += new System.EventHandler(this.glControl1_MouseLeave);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // ctlToolTip1
            // 
            this.ctlToolTip1.AutoPopDelay = 5000;
            this.ctlToolTip1.BackColor = System.Drawing.Color.Turquoise;
            this.ctlToolTip1.ForeColor = System.Drawing.Color.Navy;
            this.ctlToolTip1.InitialDelay = 1500;
            this.ctlToolTip1.ReshowDelay = 100;
            this.ctlToolTip1.UseAnimation = false;
            this.ctlToolTip1.UseFading = false;
            // 
            // ctl3DView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainViewSplitContainer);
            this.Name = "ctl3DView";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ctl3DView_Load);
            this.mainViewSplitContainer.Panel2.ResumeLayout(false);
            this.mainViewSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainViewSplitContainer;
        private CustomGUI.ctlNumber numLayer;
        private CustomGUI.ctlImageButton buttUndo;
        private CustomGUI.ctlToolTip ctlToolTip1;
        private CustomGUI.ctlImageButton buttRedo;
        private ctlGL glControl1;
        private CustomGUI.ctlVScroll scrollLayer;
        private CustomGUI.ctlInfoItem ctlInfoItemZLev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
