using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static CV19.Models.ConfirmedCount;

namespace CV19.Models
{
    internal class PlaceInfo 
    {
        public string name { get; set; }

        public Point Location { get; set; }

        public IEnumerable<ConfirmedCount> Counts { get; set; }
    }
}
