using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Winumeration.Api
{
    public static class UxTheme
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Margin
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }
    }
}
