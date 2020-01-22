using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Winumeration.Api;
using System.Drawing;

namespace Appifier
{
    public class Utilities
    {
        private static WinDef.RECT _DesktopRect;

        static Utilities()
        {
            IntPtr DesktopHandle = User32.GetDesktopWindow();
            User32.GetWindowRect(DesktopHandle, out _DesktopRect);
        }

        static bool EnumThreadCallback(IntPtr hWnd, IntPtr lParam)
        {
            GCHandle gch = GCHandle.FromIntPtr(lParam);
            List<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
            {
                throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
            }
            list.Add(hWnd);
            return true;
        }

        internal static bool IsValidUIWnd(IntPtr hWnd)
        {
            bool res = false;
            if (hWnd == IntPtr.Zero || !User32.IsWindow(hWnd) || !User32.IsWindowVisible(hWnd))
                return false;
            WinDef.RECT CrtWndRect;
            if (!User32.GetWindowRect(hWnd, out CrtWndRect))
                return false;
            if (CrtWndRect.Height > 0 && CrtWndRect.Width > 0)
            {// a valid rectangle means the right window is the mainframe and it intersects the desktop
                WinDef.RECT visibleRect;//if the rectangle is outside the desktop, it's a dummy window
                if (User32.IntersectRect(out visibleRect, ref _DesktopRect, ref CrtWndRect)
                    && !User32.IsRectEmpty(ref visibleRect))
                    res = true;
            }
            return res;
        }

        internal static void GetThreadWindows(ProcessThread pt, IntPtr list)
        {
            User32.EnumThreadWindows((uint)pt.Id, new WinUser.EnumThreadWndProc(EnumThreadCallback), list);
        }

        internal static IntPtr GetLargestWindowHandle(List<IntPtr> windowHandles)
        {
            WinDef.RECT MaxRect = default(WinDef.RECT);//init with 0

            //get the biggest visible window in the current proc
            IntPtr MaxHWnd = IntPtr.Zero;
            foreach (IntPtr hWnd in windowHandles)
            {
                WinDef.RECT CrtWndRect = default(WinDef.RECT);
                //do we have a valid rect for this window
                if (User32.IsWindowVisible(hWnd) &&
                User32.GetWindowRect(hWnd, out CrtWndRect) &&
                CrtWndRect.Height > MaxRect.Height &&
                CrtWndRect.Width > MaxRect.Width)
                {   //if the rect is outside the desktop, it's a dummy window
                    WinDef.RECT visibleRect;
                    if (User32.IntersectRect(out visibleRect, ref _DesktopRect,
                                    ref CrtWndRect)
                        && !User32.IsRectEmpty(ref visibleRect))
                    {
                        MaxHWnd = hWnd;
                        MaxRect = CrtWndRect;
                    }
                }
                Debug.WriteLine(CrtWndRect.Width + "x" + CrtWndRect.Height);
            }
            if (MaxHWnd != IntPtr.Zero && MaxRect.Width > 0 && MaxRect.Height > 0)
            {
                return MaxHWnd;
            }
            return IntPtr.Zero;
        }

        // this is mostly from http://www.codeproject.com/Articles/19192/How-to-capture-a-Window-as-an-Image-and-save-it
        internal static IntPtr UIApp(System.Diagnostics.Process proc)
        {
            var windowHandles = new List<IntPtr>();
            GCHandle listHandle = default(GCHandle);
            try
            {
                if (proc.MainWindowHandle == IntPtr.Zero)
                    throw new ApplicationException
                    ("Can't add a process with no MainFrame");

                if (IsValidUIWnd(proc.MainWindowHandle))
                {
                    return proc.MainWindowHandle;
                }
                // the mainFrame is size == 0, so we look for the 'real' window
                listHandle = GCHandle.Alloc(windowHandles);
                foreach (ProcessThread pt in proc.Threads)
                {
                    GetThreadWindows(pt, GCHandle.ToIntPtr(listHandle));
                }

                var largest = GetLargestWindowHandle(windowHandles);
                if (largest != IntPtr.Zero)
                    return largest;
                else
                    return proc.MainWindowHandle;
                //just add something even if it's a bad window

            }//try ends
            finally
            {
                if (listHandle != default(GCHandle) && listHandle.IsAllocated)
                    listHandle.Free();
            }
        }

        /*public Image DrawToBitmap(IntPtr hWnd)
        {
            Bitmap image = new Bitmap(this.ClientSize.Width, this.ClientSize.Height,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(image))
            {
                IntPtr hdcFrom = WindowsApi.GetDC(hWnd);
                WindowsApi.SendMessage(hWnd, WindowsApi.WM_PRINT, hdcFrom, WindowsApi.PRF_CLIENT | WindowsApi.PRF_CHILDREN | WindowsApi.PRF_ERASEBKGND);
                graphics.ReleaseHdc(hdcFrom);
            }
            return image;
        }*/

        public static Bitmap createBitmap(IntPtr hWnd)
        {
            Bitmap bmp = null;
            //IntPtr hdcWindow = WindowsApi.GetDC(hWnd);
            IntPtr hdcWindow = User32.GetWindowDC(hWnd);
            IntPtr hmbWindow = Gdi32.CreateCompatibleDC(hdcWindow);
            WinDef.RECT rcWindow;
            User32.GetWindowRect(hWnd, out rcWindow);
            WinDef.RECT rcClient;
            User32.GetClientRect(hWnd, out rcClient);

            // stretch screen in to windowUser32
            //WindowsApi.SetStretchBltMode(hdcWindow, WindowsApi.STRETCH_HALFTONE);

            //The source DC is the entire screen and the destination DC is the current window (HWND)
            //WindowsApi.StretchBlt(hdcWindow, 
            //    0, 0, 
            //    rcWindow.Right, rcWindow.Bottom,
            //    hdcScreen,
            //    0, 0,
            //    WindowsApi.GetSystemMetrics(WindowsApi.SystemMetric.SM_CXSCREEN),
            //    WindowsApi.GetSystemMetrics(WindowsApi.SystemMetric.SM_CYSCREEN),
            //    WindowsApi.SRCCOPY);

            //X and Y coordinates of window
            IntPtr hBitmap = Gdi32.CreateCompatibleBitmap(hdcWindow, rcWindow.Right - rcWindow.Left, rcWindow.Bottom - rcWindow.Top);
            if (hBitmap != IntPtr.Zero)
            {
                // adjust and copy
                IntPtr hLocalBitmap = Gdi32.SelectObject(hmbWindow, hBitmap);
                User32.SetActiveWindow(hWnd);
                User32.SendMessage(hWnd, WinUser.WindowMessage.WM_PRINT, hdcWindow, WinUser.PrintFlags.PRF_NONCLIENT | WinUser.PrintFlags.PRF_CLIENT | WinUser.PrintFlags.PRF_CHILDREN | WinUser.PrintFlags.PRF_ERASEBKGND);
                Gdi32.BitBlt(hmbWindow, 0, 0, rcWindow.Right - rcWindow.Left, rcWindow.Bottom - rcWindow.Top, hdcWindow, 0, 0, WinGdi.TernaryRasterOperations.SRCCOPY);
                //WindowsApi.PrintWindow(hWnd, hBitmap, 0);

                Gdi32.SelectObject(hmbWindow, hLocalBitmap);
                //We delete the memory device context.
                Gdi32.DeleteDC(hmbWindow);
                //We release the screen device context.
                User32.ReleaseDC(hWnd, hdcWindow);
                //Image is created by Image bitmap handle and assigned to Bitmap variable.
                bmp = System.Drawing.Image.FromHbitmap(hBitmap);
                //Delete the compatible bitmap object.
                Gdi32.DeleteObject(hBitmap);
                //bmp.Save("C:\\Users\\bjcullinan\\Documents\\Visual Studio 2012\\Projects\\Appifier\\Appifier\\bin\\Debug\\test.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            return bmp;
        }
    }
}
