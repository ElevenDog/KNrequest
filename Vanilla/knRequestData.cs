using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vanilla
{
    public class knRequestData
    {
        [JsonProperty("tripType")]
        public string TripType
        {
            get;
            set;
        }
        [JsonProperty("adtCount")]
        public int AdtCount
        {
            get;
            set;
        }
        [JsonProperty("chdCount")]
        public int ChdCount
        {
            get;
            set;
        }
        [JsonProperty("infCount")]
        public int InfCount
        {
            get;
            set;
        }
        [JsonProperty("currency")]
        public string Currency
        {
            get;
            set;
        }
        [JsonProperty("sortType")]
        public string SortType
        {
            get;
            set;
        }
        [JsonProperty("segmentList")]
        public List<SegmentInfo> SegmentList
        {
            get;
            set;
        }
        [JsonProperty("sortExec")]
        public string SortExec
        {
            get;
            set;
        }
        [JsonProperty("page")]
        public string Page
        {
            get;
            set;
        }
    }
    public class SegmentInfo
    {
        [JsonProperty("deCd")]
        public string DeptCd
        {
            get;
            set;
        }
        [JsonProperty("arrCd")]
        public string ArrCd
        {
            get;
            set;
        }
        [JsonProperty("deptDt")]
        public string DeptDt
        {
            get;
            set;
        }
        [JsonProperty("deptCityCode")]
        public string DeptCityCode
        {
            get;
            set;
        }
        [JsonProperty("arrCityCode")]
        public string ArrCityCode
        {
            get;
            set;
        }
    }

}
