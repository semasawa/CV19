using System.Collections.Generic;
using System.Drawing;


namespace CV19.Data
{
    internal class PlaceInfo    
    {
        public string name {  get; set; }

        public Point Location { get; set; }

        public IEnumerable<ComfirmedCount> Counts { get; set; }
    }
}
