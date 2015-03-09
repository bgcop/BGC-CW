namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlTitle
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
            this.ctlImageButton1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlImageButton1
            // 
            this.ctlImageButton1.Checked = false;
            this.ctlImageButton1.CheckImage = null;
            this.ctlImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctlImageButton1.Gapx = 5;
            this.ctlImageButton1.Gapy = 5;
            this.ctlImageButton1.GLBackgroundImage = null;
            this.ctlImageButton1.GLImage = null;
            this.ctlImageButton1.GLVisible = false;
            this.ctlImageButton1.GuiAnchor = null;
            this.ctlImageButton1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton1.Image = null;
            this.ctlImageButton1.Location = new System.Drawing.Point(0, 0);
            this.ctlImageButton1.Name = "ctlImageButton1";
            this.ctlImageButton1.Size = new System.Drawing.Size(45, 45);
            this.ctlImageButton1.StyleName = null;
            this.ctlImageButton1.TabIndex = 0;
            this.ctlImageButton1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlImageButton1.Click += new System.EventHandler(this.ctlImageButton1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(45, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseEnter += new System.EventHandler(this.lblTitle_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.lblTitle_MouseLeave);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // ctlTitle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctlImageButton1);
            this.Name = "ctlTitle";
            this.Size = new System.Drawing.Size(283, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlImageButton ctlImageButton1;
        private System.Windows.Forms.Label lblTitle;
    }
}
