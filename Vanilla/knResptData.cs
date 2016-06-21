using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vanilla
{
    public class knResptData
    {
        [JsonProperty("sessionId")]
        public string SessionId
        {
            get;
            set;
        }
        [JsonProperty("adtNum")]
        public string AdtNum
        {
            get;
            set;
        }
        [JsonProperty("chdNum")]
        public string ChdNum
        {
            get;
            set;
        }
        [JsonProperty("infNum")]
        public string InfNum
        {
            get;
            set;
        }
        [JsonProperty("timeStamp")]
        public object TimeStamp
        {
            get;
            set;
        }
        [JsonProperty("pageSize")]
        public string PageSize
        {
            get;
            set;
        }
        [JsonProperty("shopLandFlightResultNum")]
        public string ShopLandFlightResultNum
        {
            get;
            set;
        }
        [JsonProperty("pageNumber")]
        public string PageNumber
        {
            get;
            set;
        }
        [JsonProperty("travelType")]
        public object TravelType
        {
            get;
            set;
        }
        [JsonProperty("resultType")]
        public string ResultType
        {
            get;
            set;
        }
        [JsonProperty("resultCode")]
        public string ResultCode
        {
            get;
            set;
        }
        [JsonProperty("resultMsg")]
        public string ResultMsg
        {
            get;
            set;
        }
        [JsonProperty("airResultDto")]
        public AirResultDto AirResultDto
        {
            get;
            set;
        }
        [JsonProperty("blockPrice")]
        public int BlockPrice
        {
            get;
            set;
        }
        [JsonProperty("itemType")]
        public string ItemType
        {
            get;
            set;
        }
        [JsonProperty("intervalTime")]
        public string IntervalTime
        {
            get;
            set;
        }
        [JsonProperty("taxCurrency")]
        public string TaxCurrency
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
        [JsonProperty("cabinNames")]
        public CabinNames CabinNames
        {
            get;
            set;
        }
    }
    public class AirResultDto
    {
        [JsonProperty("tripType")]
        public string TripType
        {
            get;
            set;
        }
        [JsonProperty("productUnits")]
        public ProductUnit[] ProductUnits
        {
            get;
            set;
        }
        [JsonProperty("productCode")]
        public string[] ProductCode
        {
            get;
            set;
        }
        [JsonProperty("productAssembleRule")]
        public ProductAssembleRule ProductAssembleRule
        {
            get;
            set;
        }
        [JsonProperty("taxCurrency")]
        public string TaxCurrency
        {
            get;
            set;
        }
        [JsonProperty("packageSaleFlag")]
        public bool PackageSaleFlag
        {
            get;
            set;
        }
        [JsonProperty("resultType")]
        public string ResultType
        {
            get;
            set;
        }
        [JsonProperty("inter")]
        public bool Inter
        {
            get;
            set;
        }
    }
    public class CabinNames
    {
        [JsonProperty("first")]
        public string First
        {
            get;
            set;
        }
        [JsonProperty("business")]
        public string Business
        {
            get;
            set;
        }
        [JsonProperty("economy")]
        public string Economy
        {
            get;
            set;
        }
        [JsonProperty("lowest")]
        public string Lowest
        {
            get;
            set;
        }
        [JsonProperty("more")]
        public string More
        {
            get;
            set;
        }
    }

    public class ProductUnit
    {
        [JsonProperty("index")]
        public int Index
        {
            get;
            set;
        }
        [JsonProperty("flightNoGroup")]
        public string FlightNoGroup
        {
            get;
            set;
        }
        [JsonProperty("currencyCode")]
        public object CurrencyCode
        {
            get;
            set;
        }
        [JsonProperty("fareRank")]
        public object FareRank
        {
            get;
            set;
        }
        [JsonProperty("cabinInfo")]
        public CabinInfo CabinInfo
        {
            get;
            set;
        }
        [JsonProperty("fareInfoView")]
        public FareInfoView[] FareInfoView
        {
            get;
            set;
        }
        [JsonProperty("productInfo")]
        public ProductInfo ProductInfo
        {
            get;
            set;
        }
        [JsonProperty("oriDestOption")]
        public OriDestOption[] OriDestOption
        {
            get;
            set;
        }
        [JsonProperty("loadFlag")]
        public bool LoadFlag
        {
            get;
            set;
        }
        [JsonProperty("priceIcon")]
        public object PriceIcon
        {
            get;
            set;
        }
    }
    public class ProductAssembleRule
    {
        [JsonProperty("CYY")]
        public string CYY
        {
            get;
            set;
        }
        [JsonProperty("SXY")]
        public string SXY
        {
            get;
            set;
        }
        [JsonProperty("HLY")]
        public string HLY
        {
            get;
            set;
        }
        [JsonProperty("CCY")]
        public string CCY
        {
            get;
            set;
        }
    }

    public class FareInfoView
    {
        [JsonProperty("paxType")]
        public string PaxType
        {
            get;
            set;
        }
        [JsonProperty("tourCode")]
        public string TourCode
        {
            get;
            set;
        }
        [JsonProperty("fareBasisCode")]
        public string FareBasisCode
        {
            get;
            set;
        }
        [JsonProperty("ei")]
        public string Ei
        {
            get;
            set;
        }
        [JsonProperty("eiComment")]
        public string EiComment
        {
            get;
            set;
        }
        [JsonProperty("minStay")]
        public string MinStay
        {
            get;
            set;
        }
        [JsonProperty("maxStay")]
        public object MaxStay
        {
            get;
            set;
        }
        [JsonProperty("weighting")]
        public string Weighting
        {
            get;
            set;
        }
        [JsonProperty("baggageAllowance")]
        public string BaggageAllowance
        {
            get;
            set;
        }
        [JsonProperty("validityPeriod")]
        public string ValidityPeriod
        {
            get;
            set;
        }
        [JsonProperty("giftId")]
        public object GiftId
        {
            get;
            set;
        }
        [JsonProperty("ruleInfoDto")]
        public RuleInfoDto RuleInfoDto
        {
            get;
            set;
        }
        [JsonProperty("fare")]
        public Fare Fare
        {
            get;
            set;
        }
        [JsonProperty("gifts")]
        public Gift[] Gifts
        {
            get;
            set;
        }
    }

    public class CabinInfo
    {
        [JsonProperty("cabinCode")]
        public string CabinCode
        {
            get;
            set;
        }
        [JsonProperty("baseCabinCode")]
        public string BaseCabinCode
        {
            get;
            set;
        }
        [JsonProperty("cabinStatusCode")]
        public string CabinStatusCode
        {
            get;
            set;
        }
        [JsonProperty("cabinQuantity")]
        public object CabinQuantity
        {
            get;
            set;
        }
        [JsonProperty("cabinInfoDetail")]
        public object[] CabinInfoDetail
        {
            get;
            set;
        }
    }

    public class ProductInfo
    {
        [JsonProperty("productCode")]
        public string ProductCode
        {
            get;
            set;
        }
        [JsonProperty("productName")]
        public string ProductName
        {
            get;
            set;
        }
        [JsonProperty("purpose")]
        public string Purpose
        {
            get;
            set;
        }
        [JsonProperty("type")]
        public object Type
        {
            get;
            set;
        }
        [JsonProperty("usage")]
        public object Usage
        {
            get;
            set;
        }
        [JsonProperty("discount")]
        public object Discount
        {
            get;
            set;
        }
        [JsonProperty("ticketDesignatorCode")]
        public object TicketDesignatorCode
        {
            get;
            set;
        }
        [JsonProperty("text")]
        public string Text
        {
            get;
            set;
        }
    }

    public class OriDestOption
    {
        [JsonProperty("odNumber")]
        public int OdNumber
        {
            get;
            set;
        }
        [JsonProperty("isDirectionInd")]
        public bool IsDirectionInd
        {
            get;
            set;
        }
        [JsonProperty("flightNumberGroup")]
        public string FlightNumberGroup
        {
            get;
            set;
        }
        [JsonProperty("flights")]
        public Flight[] Flights
        {
            get;
            set;
        }
    }

    public class RuleInfoDto
    {
        [JsonProperty("ruleVersion")]
        public string RuleVersion
        {
            get;
            set;
        }
        [JsonProperty("changeRuleJsonStr")]
        public string ChangeRuleJsonStr
        {
            get;
            set;
        }
        [JsonProperty("refundRuleJsonStr")]
        public string RefundRuleJsonStr
        {
            get;
            set;
        }
        [JsonProperty("saleCheckRuleJsonStr")]
        public object SaleCheckRuleJsonStr
        {
            get;
            set;
        }
        [JsonProperty("nonendRuleJsonStr")]
        public object NonendRuleJsonStr
        {
            get;
            set;
        }
    }

    public class Fare
    {
        [JsonProperty("baseClassFullPrice")]
        public string BaseClassFullPrice
        {
            get;
            set;
        }
        [JsonProperty("salePrice")]
        public string SalePrice
        {
            get;
            set;
        }
        [JsonProperty("fdPrice")]
        public string FdPrice
        {
            get;
            set;
        }
        [JsonProperty("standardPrice")]
        public string StandardPrice
        {
            get;
            set;
        }
        [JsonProperty("fareContainsTax")]
        public object FareContainsTax
        {
            get;
            set;
        }
        [JsonProperty("fareDescription")]
        public object FareDescription
        {
            get;
            set;
        }
        [JsonProperty("memberLevel")]
        public object MemberLevel
        {
            get;
            set;
        }
        [JsonProperty("referenceTax")]
        public object ReferenceTax
        {
            get;
            set;
        }
        [JsonProperty("currencyCode")]
        public string CurrencyCode
        {
            get;
            set;
        }
    }

    public class Gift
    {
        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [JsonProperty("quantity")]
        public string Quantity
        {
            get;
            set;
        }
        [JsonProperty("description")]
        public object Description
        {
            get;
            set;
        }
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }

    public class Flight
    {
        [JsonProperty("index")]
        public int Index
        {
            get;
            set;
        }
        [JsonProperty("departureAirport")]
        public DepartureAirport DepartureAirport
        {
            get;
            set;
        }
        [JsonProperty("arrivalAirport")]
        public ArrivalAirport ArrivalAirport
        {
            get;
            set;
        }
        [JsonProperty("stopLocationMessage")]
        public string StopLocationMessage
        {
            get;
            set;
        }
        [JsonProperty("departureDateTime")]
        public string DepartureDateTime
        {
            get;
            set;
        }
        [JsonProperty("arrivalDateTime")]
        public string ArrivalDateTime
        {
            get;
            set;
        }
        [JsonProperty("stopQuantity")]
        public int StopQuantity
        {
            get;
            set;
        }
        [JsonProperty("flightNumber")]
        public string FlightNumber
        {
            get;
            set;
        }
        [JsonProperty("flownMileageQty")]
        public object FlownMileageQty
        {
            get;
            set;
        }
        [JsonProperty("stopoverInd")]
        public bool StopoverInd
        {
            get;
            set;
        }
        [JsonProperty("distance")]
        public object Distance
        {
            get;
            set;
        }
        [JsonProperty("dateChangeNbr")]
        public object DateChangeNbr
        {
            get;
            set;
        }
        [JsonProperty("specialFlightCode")]
        public bool SpecialFlightCode
        {
            get;
            set;
        }
        [JsonProperty("isCodeShareAirline")]
        public bool IsCodeShareAirline
        {
            get;
            set;
        }
        [JsonProperty("isSpecialSeg")]
        public bool IsSpecialSeg
        {
            get;
            set;
        }
        [JsonProperty("specialSegType")]
        public object SpecialSegType
        {
            get;
            set;
        }
        [JsonProperty("specialSegNumber")]
        public object SpecialSegNumber
        {
            get;
            set;
        }
        [JsonProperty("marketingAirline")]
        public MarketingAirline MarketingAirline
        {
            get;
            set;
        }
        [JsonProperty("operatingAirline")]
        public OperatingAirline OperatingAirline
        {
            get;
            set;
        }
        [JsonProperty("equipment")]
        public Equipment Equipment
        {
            get;
            set;
        }
        [JsonProperty("bookingClassAvail")]
        public BookingClassAvail BookingClassAvail
        {
            get;
            set;
        }
        [JsonProperty("duration")]
        public string Duration
        {
            get;
            set;
        }
        [JsonProperty("stayTime")]
        public object StayTime
        {
            get;
            set;
        }
    }

    public class DepartureAirport
    {
        [JsonProperty("cityCode")]
        public string CityCode
        {
            get;
            set;
        }
        [JsonProperty("cityContext")]
        public string CityContext
        {
            get;
            set;
        }
        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }
        [JsonProperty("codeContext")]
        public string CodeContext
        {
            get;
            set;
        }
        [JsonProperty("terminal")]
        public string Terminal
        {
            get;
            set;
        }
        [JsonProperty("gate")]
        public object Gate
        {
            get;
            set;
        }
        [JsonProperty("region")]
        public string Region
        {
            get;
            set;
        }
        [JsonProperty("arriveTime")]
        public object ArriveTime
        {
            get;
            set;
        }
        [JsonProperty("departTime")]
        public object DepartTime
        {
            get;
            set;
        }
        [JsonProperty("distance")]
        public object Distance
        {
            get;
            set;
        }
    }

    public class ArrivalAirport
    {
        [JsonProperty("cityCode")]
        public string CityCode
        {
            get;
            set;
        }
        [JsonProperty("cityContext")]
        public string CityContext
        {
            get;
            set;
        }
        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }
        [JsonProperty("codeContext")]
        public string CodeContext
        {
            get;
            set;
        }
        [JsonProperty("terminal")]
        public string Terminal
        {
            get;
            set;
        }
        [JsonProperty("gate")]
        public object Gate
        {
            get;
            set;
        }
        [JsonProperty("region")]
        public string Region
        {
            get;
            set;
        }
        [JsonProperty("arriveTime")]
        public object ArriveTime
        {
            get;
            set;
        }
        [JsonProperty("departTime")]
        public object DepartTime
        {
            get;
            set;
        }
        [JsonProperty("distance")]
        public object Distance
        {
            get;
            set;
        }
    }

    public class MarketingAirline
    {
        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }
        [JsonProperty("codeContext")]
        public string CodeContext
        {
            get;
            set;
        }
        [JsonProperty("countryCode")]
        public object CountryCode
        {
            get;
            set;
        }
        [JsonProperty("flightNumber")]
        public string FlightNumber
        {
            get;
            set;
        }
    }

    public class BookingClassAvail
    {
        [JsonProperty("meal")]
        public object[] Meal
        {
            get;
            set;
        }
        [JsonProperty("cabinCode")]
        public string CabinCode
        {
            get;
            set;
        }
        [JsonProperty("cabinStatusCode")]
        public string CabinStatusCode
        {
            get;
            set;
        }
        [JsonProperty("cabinQuantity")]
        public object CabinQuantity
        {
            get;
            set;
        }
        [JsonProperty("isAsr")]
        public bool IsAsr
        {
            get;
            set;
        }
    }

    public class OperatingAirline
    {
        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }
        [JsonProperty("codeContext")]
        public string CodeContext
        {
            get;
            set;
        }
        [JsonProperty("countryCode")]
        public object CountryCode
        {
            get;
            set;
        }
        [JsonProperty("flightNumber")]
        public string FlightNumber
        {
            get;
            set;
        }
    }

    public class Equipment
    {
        [JsonProperty("airEquipType")]
        public string AirEquipType
        {
            get;
            set;
        }
    }

}

