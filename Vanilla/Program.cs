using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using Zeus.Crawler;
using Zeus.Sys.Json;
using Zeus.Crawler.Entity;

namespace Vanilla
{
    public class Program 
    {
        //public Program(TaskResponse taskInfo, CrawlerEngine cEngine)
        //    : base(taskInfo, cEngine, new Autos
        //    {
        //        CabinIsAuto = true
        //    })
        //{
        //}
     //   static void Main(string[] args) { }
        //{
        //    HttpGet httpGet = new HttpGet(string.Format("http://www.vanilla-air.com/m/en/booking/flight/list.json?flightSearch[tripType]=OW&flightSearch[origin]={0}&flightSearch[destination]={1}&flightSearch[outboundTravelData]={2}&flightSearch[returnTravelDate]=true&flightSearch[adultPaxCount]={3}&flightSearch[childPaxCount]=0&flightSearch[infantPaxCount]=0&flightSearch[couponCode]",
        //        "CTS",
        //        "NRT",
        //        "2016-6-6",
        //        3
        //    ));

        //    string json = httpGet.Request();
        //    VanillaReturn data = JsonConvert.DeserializeObject<VanillaReturn>(json);

        //    TaskResultNode resultNode = new TaskResultNode
        //    {
        //        CarrierName = "JW",
        //        OrgCity = "CTS",
        //        DstCity = "NRT",
        //        FromDate = "2016-6-6"
        //    };
        //    List<routing> routings = new List<routing>();

        //    if (data == null || data.OnwardInfo == null)
        //        return;

        //    foreach (var current in data.OnwardInfo.flightList)
        //    {
        //        LevelFareClass levelFare = null;
        //        List<LevelFareClass> list = new List<LevelFareClass>();

        //        if (current.simpleLevelFare != null && current.simpleLevelFare.adult != null && current.simpleLevelFare.Seats != 0 && current.simpleLevelFare.Valid)
        //        {
        //            list.Add(current.simpleLevelFare);
        //        }

        //        if (current.inclusiveLevelFare != null && current.inclusiveLevelFare.adult != null && current.inclusiveLevelFare.Seats != 0 && current.inclusiveLevelFare.Valid)
        //        {
        //            list.Add(current.inclusiveLevelFare);
        //        }

        //        if (current.wakuwakuLevelFare != null && current.wakuwakuLevelFare.adult != null && current.wakuwakuLevelFare.Seats != 0 && current.wakuwakuLevelFare.Valid)
        //        {
        //            list.Add(current.wakuwakuLevelFare);
        //        }

        //        foreach (LevelFareClass current2 in list)
        //        {
        //            if (levelFare == null)
        //            {
        //                levelFare = current2;
        //            }
        //            else
        //            {
        //                if (decimal.Parse(levelFare.TotalBaseFare) > decimal.Parse(current2.TotalBaseFare))
        //                {
        //                    levelFare = current2;
        //                }
        //            }
        //        }
        //        if (levelFare == null)
        //            continue;

        //        routing routing = new routing();
        //        routing.adultPrice = decimal.Parse(levelFare.TotalBaseFare);
        //        routing.childPrice = routing.adultPrice;
        //        routing.adultTax = decimal.Parse(levelFare.adult.Tax);
        //        routing.childTax = routing.adultTax;
        //        routing.fromSegments = new List<Segment>();
        //        DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
        //        dateTimeFormatInfo.ShortDatePattern = "dd-MM-yyyy HH:mm";
        //        string[] array = current.SDT.Split(new string[]
        //        {
        //            "#"
        //        }, StringSplitOptions.RemoveEmptyEntries);
        //        string value = array[0] + " " + array[1];
        //        DateTime dateTime = Convert.ToDateTime(value, dateTimeFormatInfo);
        //        string[] array2 = current.SAT.Split(new string[]
        //        {
        //            "#"
        //        }, StringSplitOptions.RemoveEmptyEntries);
        //        string value2 = array2[0] + " " + array2[1];
        //        DateTime dateTime2 = Convert.ToDateTime(value2, dateTimeFormatInfo);
        //        routing.fromSegments.Add(new Segment
        //        {
        //            carrier = current.AirlineCode,
        //            depAirport = current.SDT,
        //            depTime = dateTime.ToString("yyyyMMddHHmm"),
        //            arrAirport = current.SAT,
        //            arrTime = dateTime2.ToString("yyyyMMddHHmm"),
        //            aircraftCode = current.AircraftType,
        //            flightNumber = current.AirlineCode.Trim() + current.FlightNumber.Trim(),
        //            cabin = levelFare.adult.FareClass,
        //            seatCount = levelFare.Seats
        //        });
        //        routings.Add(routing);
        //    }
        //    resultNode.routings = routings;
        //}

        
        //public override bool GetFlight()
        static void Main(string[] args)
        {
            knResptData knResptData = null;
            DateTime now = DateTime.Now;
            bool flag = false;
            string text;
            while (true)
            {
                bool flag2 = (DateTime.Now - now).TotalSeconds > 15.0;
                if (flag2)
                {
                    break;
                }
                Random random = new Random(Guid.NewGuid().GetHashCode());
                HttpPost httpPost = new HttpPost("http://www.flycua.com/otabooking/flight-search!doFlightSearch.shtml?rand=" + random.NextDouble().ToString());
                httpPost.HttpTimeOut = 10000;
                knRequestData knRequestData = new knRequestData
                {
                    TripType = "OW",
                    AdtCount = 1,
                    ChdCount = 0,
                    InfCount = 0,
                    Currency = "CNY",
                    SortType = "a",
                    SortExec = "a",
                    Page = "0",
                    SegmentList = new List<SegmentInfo>()
                };
                knRequestData.SegmentList.Add(new SegmentInfo
                {
                    DeptCd = "SHA",
                    DeptCityCode = "SHA",
                    ArrCd = "DAT",
                    ArrCityCode = "DAT",
                    DeptDt = "2016-06-23"
                });

                httpPost.PostData = "searchCond=" + JsonHelper.ObjectToJson(knRequestData);
                httpPost.Accept = "application/json, text/javascript, */*; q=0.01";
                httpPost.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:43.0) Gecko/20100101 Firefox/43.0";
                httpPost.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                httpPost.Host = "www.flycua.com";
                text = httpPost.Request();
                bool flag3 = !text.Contains("flightSearchResultDto");
                if (flag3)
                {
                    goto Block_2;
                }
            }
            goto IL_1C2;
        Block_2:
            knResptData = JsonHelper.JsonToObject<knResptData>(text);
            flag = true;
        IL_1C2:
            bool flag4 = !flag;
            bool result;
            if (flag4)
            {
                Console.WriteLine("抓取超时");
                result = false;
            }
            else
            {
                bool flag5 = knResptData.AirResultDto == null;
                if (flag5)
                {
                    Console.WriteLine(knResptData.ResultCode + " " + knResptData.ResultMsg);
                    bool flag6 = knResptData.ResultCode == "OTR20000" || knResptData.ResultCode == "RSD10004";
                    if (flag6)
                    {
                        result = false;
                        //return result;
                    }
                }
                else
                {
                    Dictionary<string, ProductUnit> dictionary = new Dictionary<string, ProductUnit>();
                    ProductUnit[] productUnits = knResptData.AirResultDto.ProductUnits;
                    for (int i = 0; i < productUnits.Length; i++)
                    {
                        ProductUnit productUnit = productUnits[i];
                        bool flag7 = dictionary.ContainsKey(productUnit.FlightNoGroup);
                        if (flag7)
                        {
                            bool flag8 = dictionary[productUnit.FlightNoGroup].ProductInfo.ProductCode == "SXY";
                            if (flag8)
                            {
                                dictionary[productUnit.FlightNoGroup] = productUnit;
                            }
                            else
                            {
                                bool flag9 = dictionary[productUnit.FlightNoGroup].ProductInfo.ProductCode == "CCY" && productUnit.ProductInfo.ProductCode != "SXY";
                                if (flag9)
                                {
                                    dictionary[productUnit.FlightNoGroup] = productUnit;
                                }
                                else
                                {
                                    bool flag10 = dictionary[productUnit.FlightNoGroup].ProductInfo.ProductCode == "CYY" && productUnit.ProductInfo.ProductCode == "HLY";
                                    if (flag10)
                                    {
                                        dictionary[productUnit.FlightNoGroup] = productUnit;
                                    }
                                }
                            }
                        }
                        else
                        {
                            dictionary.Add(productUnit.FlightNoGroup, productUnit);
                        }
                    }
                    foreach (KeyValuePair<string, ProductUnit> current in dictionary)
                    {
                        ProductUnit value = current.Value;
                        Routing routing = new Routing();
                        routing.adultPrice = decimal.Parse(value.FareInfoView[0].Fare.SalePrice);
                        routing.childPrice = routing.adultPrice;
                        routing.fromSegments = new List<FromSegment>();
                        OriDestOption[] oriDestOption = value.OriDestOption;
                        for (int j = 0; j < oriDestOption.Length; j++)
                        {
                            OriDestOption oriDestOption2 = oriDestOption[j];
                            routing.fromSegments.Add(new FromSegment
                            {
                                //carrier = base.CarrierCode,
                                flightNumber = oriDestOption2.FlightNumberGroup,
                                depAirport = oriDestOption2.Flights[0].DepartureAirport.Code,
                                arrAirport = oriDestOption2.Flights[0].ArrivalAirport.Code,
                                depTime = DateTime.Parse(oriDestOption2.Flights[0].DepartureDateTime).ToString("yyyyMMddHHmm"),
                                arrTime = DateTime.Parse(oriDestOption2.Flights[0].ArrivalDateTime).ToString("yyyyMMddHHmm"),
                                cabin = oriDestOption2.Flights[0].BookingClassAvail.CabinCode
                            });
                        }
                       // this.fResp.routings.Add(routing);
                    }
                }
                result = true;
            }
            //return result;
        }
    
    }
}
