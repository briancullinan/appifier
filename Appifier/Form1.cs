using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using Winumeration;
using System.Runtime.InteropServices;
using Windows.UI.Xaml;
using System.Threading;
using System.Security.Permissions;

namespace Appifier
{
    public partial class Form1 : Form
    {
        #region Variables
        private IntPtr gpsHandle = IntPtr.Zero;
        private Process gpsProcess = null;
        private ProcessStartInfo gpsPSI = new ProcessStartInfo();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Panel to Contain Controls
                gpsPSI.FileName = openFileDialog1.FileName;
                gpsPSI.Arguments = "";
                gpsPSI.WindowStyle = ProcessWindowStyle.Maximized;
                gpsProcess = System.Diagnostics.Process.Start(gpsPSI);
                gpsProcess.WaitForInputIdle();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // set up a rendered for our metro style cover
            ApplicationActivationManager appActiveManager = new ApplicationActivationManager();//Class not registered
            uint pid;
            appActiveManager.ActivateApplication("Microsoft.SDKSamples.BasicControls.CS_8wekyb3d8bbwe!SDKSample.App", null, ActivateOptions.None, out pid);
        }

        private bool runOnce;

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            if (gpsProcess != null)
            {
                var handle = Utilities.UIApp(gpsProcess);
                if (handle != IntPtr.Zero)
                {
                    // make sure the window parent is set
                    /*
                    var curParent = WindowsApi.GetParent(handle);  // doesn't seem to work
                    if (!runOnce)
                    {
                        WindowsApi.SetParent(handle, tabControl1.TabPages[0].Handle);
                        WindowsApi.SetWindowLong(handle, WindowsApi.GWL_STYLE, WindowsApi.GetWindowLong(handle, WindowsApi.GWL_STYLE) | WindowsApi.WS_MAXIMIZE);
                        runOnce = true;
                    }
                    // reset the dwm extend into client area because this looks funny, DwmExtendFrameIntoClientArea
                    var margin = new WindowsApi.Margin
                    {
                        cxLeftWidth = -1,
                        cxRightWidth = -1,
                        cyBottomHeight = -1,
                        cyTopHeight = -1
                    };
                    WindowsApi.DwmExtendFrameIntoClientArea(handle, ref margin);
                    WindowsApi.MoveWindow(handle, 0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height, true);
                    */
                    var bitmap = Utilities.createBitmap(handle);
                    e.Graphics.DrawImageUnscaled(bitmap, 0, 0, tabPage2.Width, tabPage2.Height);
                }
            }
        }
    }
}
