using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmongUsModInstaller
{
    public class AppSetting
    {
        public string AmongUsURL { get; set; } = "";
        public string AmongUsFolder { get; set; } = "";
        public string AmongUsCaptureExe { get; set; } = "";
        public string BetterCrewLinkExe { get; set; } = "";
        public class OtherTool
        {
            public bool ToolRun { get; set; }
            public string ToolName { get; set; }
            public string ToolPath { get; set; }
        }
        public List<OtherTool> OtherTools { get; set; } = new();
    }
}
