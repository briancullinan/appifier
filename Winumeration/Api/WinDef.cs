using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Winumeration.Api
{
    public static class WinDef
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public override string ToString()
            {
                return string.Format("Left = {0}, Top = {1}, Right = {2}, Bottom ={3}",
                    Left, Top, Right, Bottom);
            }
            public int Width
            {
                get { return Math.Abs(Right - Left); }
            }
            public int Height
            {
                get { return Math.Abs(Bottom - Top); }
            }
        }
    }
}
