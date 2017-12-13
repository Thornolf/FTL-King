using System;
using System.Collections.Generic;

namespace Script
{
    public class NameListed
    {
        public List<String> NameList { get; set; }

        public NameListed()
        {
            NameList = new List<string> ();
            NameList.Add ("Pascal");
            NameList.Add ("Eugène");
            NameList.Add ("Heimdall");
            NameList.Add ("Balgr");
            NameList.Add ("Fenrir");
            NameList.Add ("Jormundgar");
            NameList.Add ("Einerihar");
            NameList.Add ("Midgard");
        }
    }
}