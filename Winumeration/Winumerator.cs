using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Winumeration.Api;

namespace Winumeration
{
    public class Winumerator
    {
        static Winumerator()
        {
            //var callback = new WinUser.WinEventProc(WinEventProcCallback);
            // bind to window create event
            //var pHook = User32.SetWinEventHook(0,
            //                               uint.MaxValue, IntPtr.Zero, callback, 0, 0, 0);
        }

        public static void WinEventProcCallback(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            return;
            // if we are looking at the handle or the handle is a child of the current handle refresh the properties

            // if there is no parent refresh the process list
        }

        public static IEnumerable<Window> Windows
        {
            get
            {
                var result = new List<Window>();
                User32.EnumWindows((hWnd, lParam) => { result.Add(new Window(hWnd)); return true; }, 0);
                return result;
            }
        }

        public static IEnumerable<Window> TitledWindows
        {
            get
            {
                return Windows.Where(x => x.Title.Length > 0 && x.Visible);
            }
        }
    }
}
