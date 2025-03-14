using Newtonsoft.Json;
using System;
using System.IO;

namespace MyFinCassa.Helper
{
    public class SettingsJson
    {
        public string ip { get; set; }
        public string printer { get; set; }
        public string printerWaiter { get; set; }
        public float printer_width { get; set; }
        public string name_rest { get; set; }
        public string bottom_check { get; set; }
    }
}
