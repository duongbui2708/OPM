using System;
using System.Collections.Generic;
using System.Text;

namespace OPM.OPMEnginee
{
    interface ISiteInfo
    {
        public int GetSiteInfo(string idSiteInfo,ref SiteInfo siteInfo);
    }
}
