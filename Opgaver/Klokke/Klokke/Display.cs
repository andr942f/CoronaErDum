using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klokke
{
    public class Display : ClockInfo
    {
        public static string TimeNow() => DateTime.Now.ToString(Format);
    }
}
