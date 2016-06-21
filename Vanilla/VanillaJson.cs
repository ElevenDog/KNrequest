using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vanilla
{
    public class VanillaReturn
    {
        public OnwardInfoClass OnwardInfo { set; get; }
    }
    public class OnwardInfoClass
    {
        public string AircraftType { set; get; }
        public string AircraftVersion { set; get; }
        public string BoardPoint { set; get; }
        public string DayChange { set; get; }
        public string FlightInfo { set; get; }
        public string JourneyTime { set; get; }
        public string OffPoint { set; get; }
        public string OperatingCarrierInfo { set; get; }
        public string SAT { set; get; }
        public string SDT { set; get; }
        public string Status { set; get; }
        public string Stops { set; get; }
        public Boolean currentValid { set; get; }
        public Boolean currentNoFlight { set; get; }
        public string currentDay { set; get; }
        public string currentDayLowPrice { set; get; }
        public string isDeiExists { set; get; }
        public string isIropIndicator { set; get; }
        public Boolean nextValid { set; get; }
        public Boolean nextNoFlight { set; get; }
        public string nextDay { set; get; }
        public string nextDayLowPrice { set; get; }
        public Boolean previousValid { set; get; }
        public Boolean previousNoFlight { set; get; }
        public string previousDay { set; get; }
        public string previousDayLowPrice { set; get; }
        public List<FlightInfoClass> flightList { set; get; }
    }
    public class FlightInfoClass
    {
        public string AircraftType { set; get; }
        public string AircraftVersion { set; get; }
        public string BoardPoint { set; get; }
        public string DayChange { set; get; }
        public string FlightInfo { set; get; }
        public string AirlineCode { set; get; }
        public string FlightNumber { set; get; }
        public string JourneyTime { set; get; }
        public string OffPoint { set; get; }
        public string OperatingCarrierInfo { set; get; }
        public string SAT { set; get; }
        public string SDT { set; get; }
        public string SATtime { set; get; }
        public string SDTtime { set; get; }
        public string Status { set; get; }
        public string Stops { set; get; }
        public string cabin { set; get; }
        public string isDeiExists { set; get; }
        public string isIropIndicator { set; get; }
        public LevelFareClass inclusiveLevelFare { set; get; }
        public LevelFareClass simpleLevelFare { set; get; }
        public LevelFareClass wakuwakuLevelFare { set; get; }
    }
    public class LevelFareClass
    {
        public Boolean Valid { set; get; }
        public int Seats { set; get; }
        public string TotalAppliedFare { set; get; }
        public string TotalBaseFare { set; get; }
        public string TotalDisplayFare { set; get; }
        public PassagerClass adult { set; get; }
        public PassagerClass child { set; get; }
        public PassagerClass infant { set; get; }
    }
    public class PassagerClass
    {
        public string AppliedFare { set; get; }
        public string BaseFare { set; get; }
        public string Basis { set; get; }
        public string DisplayFare { set; get; }
        public string FareClass { set; get; }
        public string FareID { set; get; }
        public string FareTransactionID { set; get; }
        public string GuestType { set; get; }
        public string InventoryStatus { set; get; }
        public string Level { set; get; }
        public string ReturnRestrictionInd { set; get; }
        public string SubType { set; get; }
        public string Surcharge { set; get; }
        public string Tax { set; get; }
        public string Type { set; get; }
        public string TypeLocal { set; get; }
    }
}
