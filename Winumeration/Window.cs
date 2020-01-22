using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winumeration.Api;
using System.Diagnostics;
using System.IO;

namespace Winumeration
{
    public class Window
    {
        public IntPtr Handle { get; private set; }
        public Process Process { get; private set; }

        public Window(IntPtr hWnd)
        {
            Handle = hWnd;
            int pid;
            var creator = User32.GetWindowThreadProcessId(Handle, out pid);
            Process = Process.GetProcessById(pid);
        }

        public string Title
        {
            get
            {
                var sb = new StringBuilder(1024);
                User32.GetWindowText(Handle, sb, sb.MaxCapacity);
                return sb.ToString();
            }
            set
            {
                User32.SetWindowText(Handle, value);
            }
        }

        public bool Visible
        {
            get
            {
                return User32.IsWindowVisible(Handle);
            }
            set
            {
                User32.ShowWindow(Handle, value ? WinUser.ShowWindow.SW_SHOW : WinUser.ShowWindow.SW_HIDE);
            }
        }

        public string Filename
        {
            get
            {
                IntPtr pic = Kernel32.OpenProcess(WinBase.ProcessAccess.PROCESS_ALL_ACCESS, true, Process.Id);
                var sb = new StringBuilder(4096);
                PsApi.GetProcessImageFileName(pic, sb, sb.MaxCapacity);
                return sb.ToString();
            }
        }
    }
}
