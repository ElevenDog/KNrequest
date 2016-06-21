using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vanilla
{
    public class TaskResultNode
    {
        public List<routing> routings
        {
            get;
            set;
        }
        public string OrgCity { get; set; }
        public string DstCity { get; set; }
        public string CarrierName { get; set; }
        public string FromDate { get; set; }
    }

    public class routing
    {
        public decimal adultPrice
        {
            get;
            set;
        }

        public decimal adultTax
        {
            get;
            set;
        }

        public decimal childPrice
        {
            get;
            set;
        }

        public decimal childTax
        {
            get;
            set;
        }

        public List<Segment> fromSegments
        {
            get;
            set;
        }
    }

    public class Segment
    {
        public string carrier
        {
            get;
            set;
        }

        public string depAirport
        {
            get;
            set;
        }

        public string depTime
        {
            get;
            set;
        }

        public string arrAirport
        {
            get;
            set;
        }

        public string arrTime
        {
            get;
            set;
        }

        public string stopCities
        {
            get;
            set;
        }

        public bool codeShare
        {
            get;
            set;
        }

        public string cabin
        {
            get;
            set;
        }

        public int seatCount
        {
            get;
            set;
        }

        public string aircraftCode
        {
            get;
            set;
        }

        public string flightNumber
        {
            get;
            set;
        }

        public Segment()
        {
            this.carrier = "";
            this.depAirport = "";
            this.depTime = "";
            this.arrAirport = "";
            this.arrTime = "";
            this.stopCities = "";
            this.codeShare = false;
            this.cabin = "";
            this.aircraftCode = "";
            this.flightNumber = "";
            this.seatCount = 9;
        }
    }
}
