using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UV_DLP_3D_Printer.GUI.CustomGUI;
using System.IO;
using UV_DLP_3D_Printer.Slicing;
using UV_DLP_3D_Printer._3DEngine;
using UV_DLP_3D_Printer.Device_Interface;
using UV_DLP_3D_Printer.Device_Interface.AutoDetect;

namespace UV_DLP_3D_Printer.GUI
{
    public partial class CwMainForm : Form
    {
        #region [ DEF's ]
        
        // the tabview class is used to display a ctlTitle with a panel object on the pnlTopTabs
        // I'm adding this small tracker class so we can add new tabs / controls loaded
        // from plugins or from the guiconfig files.
        private class tabview
        {
            static int idxgen = 0;
            public int m_tabidx;
            public ctlTitle m_title;
            public Control m_panel;
            public string m_name;
            public tabview(string name, ctlTitle title, Control pcontrol)
            {
                m_name = name;
                m_title = title;
                m_panel = pcontrol;
                m_tabidx = idxgen++;
            }
        }
        /*
        private enum eViewTypes
        {
            eV3d,
            eVSlice,
            eVControl,
            eVConfig,
            eNone
        }
         */
        private int m_viewtype;
        public event delBuildStatus BuildStatusInvoked; // rund the build delegate in Form thread
        public string m_appname = "Creation Workshop";
        //frmDLP m_frmdlp = new frmDLP();
        frmSlice m_frmSlice = new frmSlice();
        public ManualControl m_manctl;
        int rightToolsWidth = 0;
        StringBuilder m_logSB;
        List<tabview> m_lsttabs;
        private string SceneFileExt;
        #endregion

        public CwMainForm()
        {
            SceneFileExt = "cws";// default to creation workshop CWS files
            m_lsttabs = new List<tabview>();
            m_logSB = new StringBuilder();
            InitializeComponent();
            UVDLPApp.Instance().m_mainform = this;
            m_manctl = ManualControl.Instance(); // late intialization happens here after the UVDLP app Singleton is initiated.  
            UVDLPApp.Instance().Engine3D.UpdateGrid();
            ctl3DView1.UpdateView(); // initial update
            ctl3DView1.RearrangeGui();
            ctl3DView1.Enable3dView(true);
        }

        private void CwMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            //openFileDialog1.Filter = "3D Model Files (*.stl;*.obj;*.3ds;*.amf)|*.stl;*.obj;*.3ds;*.amf|Scene files (*.cws)|*.cws";
            openFileDialog1.Filter = "3D Model Files (*.stl;*.obj;*.3ds;*.amf)|*.stl;*.obj;*.3ds;*.amf|Scene files (*." + SceneFileExt + ")|*." + SceneFileExt;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    if (filename.Contains("." + SceneFileExt))
                    {
                        //scene file
                        if (SceneFile.Instance().LoadSceneFile(filename))
                        {
                            //set up for newly loaded scene
                            //load gcode
                            UVDLPApp.Instance().PostLoadScene();
                            //raise events
                            //load slicing info?
                            UVDLPApp.Instance().RaiseAppEvent(eAppEvent.eReDraw, "");
                        }
                        else
                        {
                            DebugLogger.Instance().LogError("Error loading scene file : " + filename);
                        }
                    }
                    else
                    {
                        if (UVDLPApp.Instance().LoadModel(filename) == false)
                        {
                            DebugLogger.Instance().LogError("Error loading object file : " + filename);
                        }
                        else
                        {
                            //chkWireframe.Checked = false;
                            //ctl3DView1.UpdateObjectInfo();
                        }
                    }
                }
            }
        }

       
        
    }
}
