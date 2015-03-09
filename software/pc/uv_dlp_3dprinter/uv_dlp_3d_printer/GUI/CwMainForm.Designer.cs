namespace UV_DLP_3D_Printer.GUI
{
    partial class CwMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CwMainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctl3DView1 = new UV_DLP_3D_Printer.GUI.Controls.ctl3DView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlSliceGCodePanel1 = new UV_DLP_3D_Printer.GUI.Controls.ctlSliceGCodePanel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ctlMoveExpand1 = new UV_DLP_3D_Printer.GUI.CustomGUI.Expanding.ctlMoveExpand();
            this.ctlObjectInfo1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlObjectInfo();
            this.ctlScene1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlScene();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1165, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.Color.Black;
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbDropDown.Visible = false;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAcessToolbar.Enabled = false;
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ribbon1.Size = new System.Drawing.Size(1165, 109);
            this.ribbon1.TabIndex = 3;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "Menu";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Purple;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Menu Principal";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton4);
            this.ribbonPanel1.Text = "";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = global::UV_DLP_3D_Printer.Properties.Resources.Logo_BGC_SMART_TECHBPQ;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButton1);
            this.ribbonPanel3.Text = null;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = global::UV_DLP_3D_Printer.Properties.Resources.power_icon32;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Conectar";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonButton2);
            this.ribbonPanel2.Items.Add(this.ribbonButton3);
            this.ribbonPanel2.Text = "";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::UV_DLP_3D_Printer.Properties.Resources.Open_Folder_Add_icon__1_;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Abrir";
            this.ribbonButton2.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::UV_DLP_3D_Printer.Properties.Resources.Save_icon__1_;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Guardar";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 109);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 381);
            this.splitContainer1.SplitterDistance = 740;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctl3DView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualización 3d";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctl3DView1
            // 
            this.ctl3DView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl3DView1.Location = new System.Drawing.Point(3, 3);
            this.ctl3DView1.Name = "ctl3DView1";
            this.ctl3DView1.Size = new System.Drawing.Size(728, 349);
            this.ctl3DView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlSliceGCodePanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualización por Cortes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlSliceGCodePanel1
            // 
            this.ctlSliceGCodePanel1.AutoSize = true;
            this.ctlSliceGCodePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSliceGCodePanel1.Gapx = 0;
            this.ctlSliceGCodePanel1.Gapy = 0;
            this.ctlSliceGCodePanel1.GLBackgroundImage = null;
            this.ctlSliceGCodePanel1.GLVisible = false;
            this.ctlSliceGCodePanel1.GuiAnchor = null;
            this.ctlSliceGCodePanel1.Location = new System.Drawing.Point(3, 3);
            this.ctlSliceGCodePanel1.Name = "ctlSliceGCodePanel1";
            this.ctlSliceGCodePanel1.Size = new System.Drawing.Size(728, 349);
            this.ctlSliceGCodePanel1.StyleName = null;
            this.ctlSliceGCodePanel1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(418, 381);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ctlMoveExpand1);
            this.tabPage3.Controls.Add(this.ctlObjectInfo1);
            this.tabPage3.Controls.Add(this.ctlScene1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(410, 355);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ctlMoveExpand1
            // 
            this.ctlMoveExpand1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMoveExpand1.Gapx = 0;
            this.ctlMoveExpand1.Gapy = 0;
            this.ctlMoveExpand1.GLBackgroundImage = null;
            this.ctlMoveExpand1.GLVisible = false;
            this.ctlMoveExpand1.GuiAnchor = null;
            this.ctlMoveExpand1.Location = new System.Drawing.Point(3, 159);
            this.ctlMoveExpand1.Name = "ctlMoveExpand1";
            this.ctlMoveExpand1.Size = new System.Drawing.Size(404, 82);
            this.ctlMoveExpand1.StyleName = null;
            this.ctlMoveExpand1.TabIndex = 7;
            // 
            // ctlObjectInfo1
            // 
            this.ctlObjectInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlObjectInfo1.Checked = false;
            this.ctlObjectInfo1.Gapx = 5;
            this.ctlObjectInfo1.Gapy = 5;
            this.ctlObjectInfo1.GLBackgroundImage = null;
            this.ctlObjectInfo1.GLVisible = false;
            this.ctlObjectInfo1.GuiAnchor = null;
            this.ctlObjectInfo1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlObjectInfo1.Location = new System.Drawing.Point(3, 239);
            this.ctlObjectInfo1.Name = "ctlObjectInfo1";
            this.ctlObjectInfo1.Size = new System.Drawing.Size(404, 110);
            this.ctlObjectInfo1.StyleName = null;
            this.ctlObjectInfo1.TabIndex = 6;
            this.ctlObjectInfo1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // ctlScene1
            // 
            this.ctlScene1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlScene1.BackColor = System.Drawing.Color.White;
            this.ctlScene1.Checked = false;
            this.ctlScene1.Gapx = 5;
            this.ctlScene1.Gapy = 5;
            this.ctlScene1.GLBackgroundImage = null;
            this.ctlScene1.GLVisible = false;
            this.ctlScene1.GuiAnchor = null;
            this.ctlScene1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.ctlScene1.Location = new System.Drawing.Point(2, 1);
            this.ctlScene1.Name = "ctlScene1";
            this.ctlScene1.Size = new System.Drawing.Size(405, 157);
            this.ctlScene1.StyleName = null;
            this.ctlScene1.TabIndex = 5;
            this.ctlScene1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(410, 355);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CwMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 512);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CwMainForm";
            this.ShowIcon = false;
            this.Text = "BGC CW Software (2015)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CwMainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.ctl3DView ctl3DView1;
        private Controls.ctlSliceGCodePanel ctlSliceGCodePanel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private CustomGUI.ctlScene ctlScene1;
        private CustomGUI.ctlObjectInfo ctlObjectInfo1;
        private CustomGUI.Expanding.ctlMoveExpand ctlMoveExpand1;
    }
}