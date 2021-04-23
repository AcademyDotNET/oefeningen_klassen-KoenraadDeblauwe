using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HiddenBookmark
{
    class Bookmark
    {
        public string Naam { get; set; }
        public string URL { get; set; }
        public virtual void OpenSite()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);  //Voeg bovenaan using System.Diagnostics; toe
        }
    }
}
