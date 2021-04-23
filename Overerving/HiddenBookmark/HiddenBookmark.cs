using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HiddenBookmark
{
    class HiddenBookmark:Bookmark
    {
        public override void OpenSite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe","-incognito "+ URL);
        }
    }
}
