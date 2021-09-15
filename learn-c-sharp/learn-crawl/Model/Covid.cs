using Newtonsoft.Json;

namespace learn_crawl.Model
{
    /// <summary>
    /// death and treating, cases, recovered
    /// </summary>
    public class BaseInfo
    {
        [JsonProperty("death")]
        public int Death { get; set; }
        
        [JsonProperty("treating")]
        public int Treating { get; set; }
        
        [JsonProperty("cases")]
        public int Cases { get; set; }
        
        [JsonProperty("recovered")]
        public int Recovered { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not BaseInfo) return false;
            var baseInfo = (BaseInfo) obj;
            return baseInfo.Cases == Cases && baseInfo.Death == Death && baseInfo.Recovered == Recovered &&
                   baseInfo.Treating == Treating;
        }
    }
    
    /// <summary>
    /// total and today
    /// </summary>
    public class Info
    {
        [JsonProperty("internal")]
        public BaseInfo Internal { get; set; }
        
        [JsonProperty("world")]
        public BaseInfo World { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Info) return false;
            var info = (Info) obj;
            return Internal.Equals(info.Internal) && World.Equals(info.World);
        }
    }

    /// <summary>
    /// Location
    /// </summary>
    public class Location : BaseInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("casesToday")]
        public int CasesToday { get; set; }
    }

    /// <summary>
    /// All
    /// </summary>
    public class Covid
    {
        [JsonProperty("total")]
        public Info Total { get; set; }
        
        [JsonProperty("today")]
        public Info Today { get; set; }
        
        [JsonProperty("locations")]
        public Location[] Locations { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Covid) return false;
            var covid = (Covid) obj;
            return covid.Today.Equals(Today) && covid.Total.Equals(Total);
        }
    }
}