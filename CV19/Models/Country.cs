using System;
using System.Collections.Generic;
using System.Text;
using static CV19.Models.ConfirmedCount;

namespace CV19.Models
{
    internal class Country
    {
        public string name { get; set; }

        public Point Location { get; set; }

        public IEnumerable<ComfirmedCount> Counts { get; set; }
    }
}
