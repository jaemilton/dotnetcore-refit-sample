using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExample.models.MyIp
{
    public class MyIpResponse
    {
        public bool Success { get; set; }
        public string Ip { get; set; }
        public string Type { get; set; }
        public CountryInfo Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public LocationInfo Location { get; set; }
        public string TimeZone { get; set; }
        public AsnInfo Asn { get; set; }
    }

    public class CountryInfo
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class LocationInfo
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }

    public class AsnInfo
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Network { get; set; }
    }
}
