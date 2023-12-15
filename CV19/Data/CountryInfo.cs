using System.Collections.Generic;


namespace CV19.Data
{
    internal class CountryInfo : PlaceInfo 
    { 
        public IEnumerable<ProvinceInfo> ProvinceCounts { get; set; }
    }
}
