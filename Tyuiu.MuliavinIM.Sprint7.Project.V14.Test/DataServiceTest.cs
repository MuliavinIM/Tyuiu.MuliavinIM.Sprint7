using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Tyuiu.MuliavinIM.Sprint7.Project.V14.Lib;

namespace Tyuiu.MuliavinIM.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataService_MIM_Tests
    {
        private DataService_MIM service;
        private List<TransportRoute_MIM> data;

        [TestInitialize]
        public void Init()
        {
            service = new DataService_MIM();
            data = new List<TransportRoute_MIM>
            {
                new TransportRoute_MIM
                {
                    TransportType_MIM = "Автобус",
                    RouteNumber_MIM = "12",
                    StartDate_MIM = new DateTime(2024, 1, 1),
                    StartStop_MIM = "А",
                    EndStop_MIM = "Б",
                    TravelTimeMinutes_MIM = 20,
                    Note_MIM = ""
                },
                new TransportRoute_MIM
                {
                    TransportType_MIM = "Трамвай",
                    RouteNumber_MIM = "5",
                    StartDate_MIM = new DateTime(2024, 1, 2),
                    StartStop_MIM = "В",
                    EndStop_MIM = "Г",
                    TravelTimeMinutes_MIM = 35,
                    Note_MIM = ""
                }
            };
        }


        [TestMethod]
        public void AddRoute_ShouldIncreaseCount()
        {
            service.AddRoute(data, new TransportRoute_MIM());

            Assert.AreEqual(3, data.Count);
        }

        [TestMethod]
        public void EditRoute_ShouldReplaceItem()
        {
            var route = new TransportRoute_MIM
            {
                RouteNumber_MIM = "99",
                TravelTimeMinutes_MIM = 10
            };

            service.EditRoute(data, 0, route);

            Assert.AreEqual("99", data[0].RouteNumber_MIM);
        }

        [TestMethod]
        public void DeleteRoute_ShouldDecreaseCount()
        {
            service.DeleteRoute(data, 0);

            Assert.AreEqual(1, data.Count);
        }

        [TestMethod]
        public void SearchByRouteNumber_ShouldReturnOne()
        {
            var result = service.SearchByRouteNumber(data, "12");

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void FilterByTransportType_ShouldReturnOnlyBus()
        {
            var result = service.FilterByTransportType(data, "Автобус");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Автобус", result[0].TransportType_MIM);
        }


        [TestMethod]
        public void SortByTravelTime_Ascending()
        {
            var result = service.SortByTravelTime(data);

            Assert.AreEqual(20, result[0].TravelTimeMinutes_MIM);
        }

        [TestMethod]
        public void SortByTravelTime_Descending()
        {
            var result = service.SortByTravelTime(data, false);

            Assert.AreEqual(35, result[0].TravelTimeMinutes_MIM);
        }


        [TestMethod]
        public void GetCount_ShouldReturn2()
        {
            Assert.AreEqual(2, service.GetCount(data));
        }

        [TestMethod]
        public void GetSumTime_ShouldReturn55()
        {
            Assert.AreEqual(55, service.GetSumTime(data));
        }

        [TestMethod]
        public void GetAverageTime_ShouldReturn27_5()
        {
            Assert.AreEqual(27.5, service.GetAverageTime(data));
        }

        [TestMethod]
        public void GetMinTime_ShouldReturn20()
        {
            Assert.AreEqual(20, service.GetMinTime(data));
        }

        [TestMethod]
        public void GetMaxTime_ShouldReturn35()
        {
            Assert.AreEqual(35, service.GetMaxTime(data));
        }


        [TestMethod]
        public void SaveAndLoadCsv_ShouldPreserveData()
        {
            string path = "test_routes.csv";

            service.SaveToCsv(path, data);
            var loaded = service.LoadFromCsv(path);

            Assert.AreEqual(2, loaded.Count);
            Assert.AreEqual("12", loaded[0].RouteNumber_MIM);

            File.Delete(path);
        }
    }
}

