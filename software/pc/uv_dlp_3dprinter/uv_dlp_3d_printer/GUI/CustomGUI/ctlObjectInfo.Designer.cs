﻿namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlObjectInfo
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
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttScene = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.tName = new System.Windows.Forms.Label();
            this.tVolume = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tCost = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tPoints = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tPolys = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tMin = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tMax = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.tSize = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlInfoItem();
            this.layoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel.BackColor = System.Drawing.Color.White;
            this.layoutPanel.Controls.Add(this.panel1);
            this.layoutPanel.Controls.Add(this.tVolume);
            this.layoutPanel.Controls.Add(this.tCost);
            this.layoutPanel.Controls.Add(this.tPoints);
            this.layoutPanel.Controls.Add(this.tPolys);
            this.layoutPanel.Controls.Add(this.tMin);
            this.layoutPanel.Controls.Add(this.tMax);
            this.layoutPanel.Controls.Add(this.tSize);
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(232, 175);
            this.layoutPanel.TabIndex = 0;
            this.layoutPanel.Resize += new System.EventHandler(this.layoutPanel_Resize);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttScene);
            this.panel1.Controls.Add(this.tName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 24);
            this.panel1.TabIndex = 4;
            // 
            // buttScene
            // 
            this.buttScene.Checked = false;
            this.buttScene.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttChecked;
            this.buttScene.Gapx = 5;
            this.buttScene.Gapy = 5;
            this.buttScene.GLBackgroundImage = null;
            this.buttScene.GLImage = null;
            this.buttScene.GLVisible = false;
            this.buttScene.GuiAnchor = null;
            this.buttScene.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScene.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttScene;
            this.buttScene.Location = new System.Drawing.Point(194, 2);
            this.buttScene.Name = "buttScene";
            this.buttScene.Size = new System.Drawing.Size(20, 20);
            this.buttScene.StyleName = null;
            this.buttScene.TabIndex = 3;
            this.buttScene.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttScene.Click += new System.EventHandler(this.buttScene_Click);
            // 
            // tName
            // 
            this.tName.BackColor = System.Drawing.Color.SteelBlue;
            this.tName.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tName.ForeColor = System.Drawing.Color.White;
            this.tName.Location = new System.Drawing.Point(0, 2);
            this.tName.Margin = new System.Windows.Forms.Padding(3, 2, 4, 3);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(184, 20);
            this.tName.TabIndex = 0;
            this.tName.Text = "Object Info";
            // 
            // tVolume
            // 
            this.tVolume.BackColor = System.Drawing.Color.SteelBlue;
            this.tVolume.DataBackColor = System.Drawing.Color.White;
            this.tVolume.DataColor = System.Drawing.Color.Black;
            this.tVolume.DataText = "";
            this.tVolume.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tVolume.Gapx = 0;
            this.tVolume.Gapy = 0;
            this.tVolume.GLBackgroundImage = null;
            this.tVolume.GLVisible = false;
            this.tVolume.GuiAnchor = null;
            this.tVolume.Location = new System.Drawing.Point(3, 30);
            this.tVolume.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tVolume.Name = "tVolume";
            this.tVolume.Size = new System.Drawing.Size(215, 20);
            this.tVolume.StyleName = null;
            this.tVolume.TabIndex = 1;
            this.tVolume.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tVolume.TitleColor = System.Drawing.Color.White;
            this.tVolume.TitleText = "Volume:";
            this.tVolume.TitleWidth = 30;
            // 
            // tCost
            // 
            this.tCost.BackColor = System.Drawing.Color.SteelBlue;
            this.tCost.DataBackColor = System.Drawing.Color.White;
            this.tCost.DataColor = System.Drawing.Color.Black;
            this.tCost.DataText = "";
            this.tCost.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tCost.Gapx = 0;
            this.tCost.Gapy = 0;
            this.tCost.GLBackgroundImage = null;
            this.tCost.GLVisible = false;
            this.tCost.GuiAnchor = null;
            this.tCost.Location = new System.Drawing.Point(3, 50);
            this.tCost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tCost.Name = "tCost";
            this.tCost.Size = new System.Drawing.Size(215, 20);
            this.tCost.StyleName = null;
            this.tCost.TabIndex = 1;
            this.tCost.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tCost.TitleColor = System.Drawing.Color.White;
            this.tCost.TitleText = "Cost:";
            this.tCost.TitleWidth = 30;
            // 
            // tPoints
            // 
            this.tPoints.BackColor = System.Drawing.Color.SteelBlue;
            this.tPoints.DataBackColor = System.Drawing.Color.White;
            this.tPoints.DataColor = System.Drawing.Color.Black;
            this.tPoints.DataText = "";
            this.tPoints.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tPoints.Gapx = 0;
            this.tPoints.Gapy = 0;
            this.tPoints.GLBackgroundImage = null;
            this.tPoints.GLVisible = false;
            this.tPoints.GuiAnchor = null;
            this.tPoints.Location = new System.Drawing.Point(3, 70);
            this.tPoints.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tPoints.Name = "tPoints";
            this.tPoints.Size = new System.Drawing.Size(215, 20);
            this.tPoints.StyleName = null;
            this.tPoints.TabIndex = 1;
            this.tPoints.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tPoints.TitleColor = System.Drawing.Color.White;
            this.tPoints.TitleText = "# Points:";
            this.tPoints.TitleWidth = 30;
            // 
            // tPolys
            // 
            this.tPolys.BackColor = System.Drawing.Color.SteelBlue;
            this.tPolys.DataBackColor = System.Drawing.Color.White;
            this.tPolys.DataColor = System.Drawing.Color.Black;
            this.tPolys.DataText = "";
            this.tPolys.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tPolys.Gapx = 0;
            this.tPolys.Gapy = 0;
            this.tPolys.GLBackgroundImage = null;
            this.tPolys.GLVisible = false;
            this.tPolys.GuiAnchor = null;
            this.tPolys.Location = new System.Drawing.Point(3, 90);
            this.tPolys.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tPolys.Name = "tPolys";
            this.tPolys.Size = new System.Drawing.Size(215, 20);
            this.tPolys.StyleName = null;
            this.tPolys.TabIndex = 1;
            this.tPolys.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tPolys.TitleColor = System.Drawing.Color.White;
            this.tPolys.TitleText = "# Polys:";
            this.tPolys.TitleWidth = 30;
            // 
            // tMin
            // 
            this.tMin.BackColor = System.Drawing.Color.SteelBlue;
            this.tMin.DataBackColor = System.Drawing.Color.White;
            this.tMin.DataColor = System.Drawing.Color.Black;
            this.tMin.DataText = "";
            this.tMin.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMin.Gapx = 0;
            this.tMin.Gapy = 0;
            this.tMin.GLBackgroundImage = null;
            this.tMin.GLVisible = false;
            this.tMin.GuiAnchor = null;
            this.tMin.Location = new System.Drawing.Point(3, 110);
            this.tMin.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tMin.Name = "tMin";
            this.tMin.Size = new System.Drawing.Size(215, 20);
            this.tMin.StyleName = null;
            this.tMin.TabIndex = 1;
            this.tMin.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tMin.TitleColor = System.Drawing.Color.White;
            this.tMin.TitleText = "Min:";
            this.tMin.TitleWidth = 30;
            // 
            // tMax
            // 
            this.tMax.BackColor = System.Drawing.Color.SteelBlue;
            this.tMax.DataBackColor = System.Drawing.Color.White;
            this.tMax.DataColor = System.Drawing.Color.Black;
            this.tMax.DataText = "";
            this.tMax.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tMax.Gapx = 0;
            this.tMax.Gapy = 0;
            this.tMax.GLBackgroundImage = null;
            this.tMax.GLVisible = false;
            this.tMax.GuiAnchor = null;
            this.tMax.Location = new System.Drawing.Point(3, 130);
            this.tMax.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tMax.Name = "tMax";
            this.tMax.Size = new System.Drawing.Size(215, 20);
            this.tMax.StyleName = null;
            this.tMax.TabIndex = 1;
            this.tMax.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tMax.TitleColor = System.Drawing.Color.White;
            this.tMax.TitleText = "Max:";
            this.tMax.TitleWidth = 30;
            // 
            // tSize
            // 
            this.tSize.BackColor = System.Drawing.Color.SteelBlue;
            this.tSize.DataBackColor = System.Drawing.Color.White;
            this.tSize.DataColor = System.Drawing.Color.Black;
            this.tSize.DataText = "";
            this.tSize.Font = new System.Drawing.Font("Arial", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tSize.Gapx = 0;
            this.tSize.Gapy = 0;
            this.tSize.GLBackgroundImage = null;
            this.tSize.GLVisible = false;
            this.tSize.GuiAnchor = null;
            this.tSize.Location = new System.Drawing.Point(3, 150);
            this.tSize.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tSize.Name = "tSize";
            this.tSize.Size = new System.Drawing.Size(215, 20);
            this.tSize.StyleName = null;
            this.tSize.TabIndex = 1;
            this.tSize.TitleBackColor = System.Drawing.Color.SteelBlue;
            this.tSize.TitleColor = System.Drawing.Color.White;
            this.tSize.TitleText = "Size:";
            this.tSize.TitleWidth = 30;
            // 
            // ctlObjectInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.layoutPanel);
            this.Name = "ctlObjectInfo";
            this.Size = new System.Drawing.Size(232, 178);
            this.Resize += new System.EventHandler(this.ctlObjectInfo_Resize);
            this.layoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Label tName;
        private ctlInfoItem tVolume;
        private ctlInfoItem tCost;
        private ctlInfoItem tPoints;
        private ctlInfoItem tPolys;
        private ctlInfoItem tMin;
        private ctlInfoItem tMax;
        private ctlInfoItem tSize;
        private System.Windows.Forms.Panel panel1;
        private ctlImageButton buttScene;
    }
}
