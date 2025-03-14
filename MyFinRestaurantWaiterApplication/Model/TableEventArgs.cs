using System;

namespace MyFinCassa.Model
{
    public class TableEventArgs : EventArgs
    {
        public Tables SelectedTable { get; set; }
    }
}
