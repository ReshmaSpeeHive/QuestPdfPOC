using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfPOC.Data
{
    using QuestPdfPOC.Model;
    using System;
    using System.Collections.Generic;

    public class DataSeeder
    {
        private readonly Random random = new Random();

        public TankCleaningPerformanceData TankCleaningSeedData()
        {
            var tankCleaningData = new TankCleaningPerformanceData
            {
                SingleVoyageData = TankCleaningSeedSingleVoyageData(),
                TotalVoyagePerformance = TankCleaningSeedTotalVoyagePerformance()
            };

            return tankCleaningData;
        }

        private List<TankCleaningSingleVoyageData> TankCleaningSeedSingleVoyageData()
        {
            var singleVoyageDataList = new List<TankCleaningSingleVoyageData>();

            for (int i = 0; i < 5; i++)
            {
                var singleVoyageData = new TankCleaningSingleVoyageData
                {
                    WarrantedConsumptionFO = Math.Round(random.NextDouble(), 2),
                    WarrantedConsumptionGO = Math.Round(random.NextDouble(), 2),
                    Title = "Voyage " + (i + 1),
                    ReportedData = TankCleaningSeedReportedData(),
                    SingleVoyagePerformance = TankCleaningSeedSingleVoyagePerformance()
                };

                singleVoyageDataList.Add(singleVoyageData);
            }

            return singleVoyageDataList;
        }

        private List<TankCleaningReportedData> TankCleaningSeedReportedData()
        {
            var reportedDataList = new List<TankCleaningReportedData>();

            for (int i = 0; i < 10; i++) 
            {
                var reportedData = new TankCleaningReportedData
                {
                    ReportedDateTime = DateTime.Now.AddDays(-i),
                    HoursOfTankCleaned = Math.Round(random.NextDouble(), 2),
                    NumberOfTanksCleaned = random.Next(1, 10),
                    TotalNumberOfTanks = random.Next(10, 20),
                    ActualConsumptionFO = Math.Round(random.NextDouble(), 2),
                    ActualConsumptionGO = Math.Round(random.NextDouble(), 2),
                    WarrantedConsumptionFO = Math.Round(random.NextDouble(), 2),
                    WarrantedConsumptionGO = Math.Round(random.NextDouble(), 2),
                    FuelLossGainFO = Math.Round(random.NextDouble(), 2),
                    FuelLossGainGO = Math.Round(random.NextDouble(), 2)
                };

                reportedDataList.Add(reportedData);
            }

            return reportedDataList;
        }

        private TankCleaningSingleVoyagePerformance TankCleaningSeedSingleVoyagePerformance()
        {
            return new TankCleaningSingleVoyagePerformance
            {
                WarrantedConsumptionFO = Math.Round(random.NextDouble(), 2),
                WarrantedConsumptionGO = Math.Round(random.NextDouble(), 2),
                TotalLossGainFO = Math.Round(random.NextDouble(), 2),
                TotalLossGainGO = Math.Round(random.NextDouble(), 2)
            };
        }

        private TankCleaningTotalVoyagePerformance TankCleaningSeedTotalVoyagePerformance()
        {
            return new TankCleaningTotalVoyagePerformance
            {
                TotalLossGainFO = Math.Round(random.NextDouble(), 2),
                TotalLossGainGO = Math.Round(random.NextDouble(), 2)
            };
        }

        public CargoHeatingPerformanceData CargoHeatingSeedData()
        {
            var CargoHeatingData = new CargoHeatingPerformanceData
            {
                SingleVoyageData = CargoHeatingSeedSingleVoyageData(),
                TotalVoyagePerformance = CargoHeatingSeedTotalVoyagePerformance()
            };

            return CargoHeatingData;
        }

        private List<CargoHeatingSingleVoyageData> CargoHeatingSeedSingleVoyageData()
        {
            var singleVoyageDataList = new List<CargoHeatingSingleVoyageData>();

            for (int i = 0; i < 5; i++)
            {
                var singleVoyageData = new CargoHeatingSingleVoyageData
                {
                    WarrantedConsumptionFO = Math.Round(random.NextDouble(), 2),
                    WarrantedConsumptionGO = Math.Round(random.NextDouble(), 2),
                    Title = "Voyage " + (i + 1),
                    ReportedData = CargoHeatingSeedReportedData(),
                    SingleVoyagePerformance = CargoHeatingSeedSingleVoyagePerformance()
                };

                singleVoyageDataList.Add(singleVoyageData);
            }

            return singleVoyageDataList;
        }

        private List<CargoHeatingReportedData> CargoHeatingSeedReportedData()
        {
            var reportedDataList = new List<CargoHeatingReportedData>();
            var operationNames = new List<string> { "Loading", "Unloading", "Maintaining Temperature", "Storage", "Inspection" };

            for (int i = 0; i < 10; i++)
            {
                var reportedData = new CargoHeatingReportedData
                {
                    Operation = GetRandomOperation(operationNames),
                    ReportedDateTime = DateTime.Now.AddDays(-i),
                    HoursOfTankCleaned = Math.Round(random.NextDouble(), 2),
                    NumberOfTanksCleaned = random.Next(1, 10),
                    TotalNumberOfTanks = random.Next(10, 20),
                    ActualConsumptionFO = Math.Round(random.NextDouble(), 2),
                    ActualConsumptionGO = Math.Round(random.NextDouble(), 2),
                    WarrantedConsumptionFO = Math.Round(random.NextDouble(), 2),
                    WarrantedConsumptionGO = Math.Round(random.NextDouble(), 2),
                    FuelLossGainFO = Math.Round(random.NextDouble(), 2),
                    FuelLossGainGO = Math.Round(random.NextDouble(), 2)
                };

                reportedDataList.Add(reportedData);
            }

            return reportedDataList;
        }
        // Helper method to get a random operation name from the list
        private string GetRandomOperation(List<string> operationNames)
        {
            int randomIndex = random.Next(0, operationNames.Count);
            return operationNames[randomIndex];
        }
        private CargoHeatingSingleVoyagePerformance CargoHeatingSeedSingleVoyagePerformance()
        {
            return new CargoHeatingSingleVoyagePerformance
            {
                WarrantedConsumptionFO = Math.Round(random.NextDouble(), 2),
                WarrantedConsumptionGO = Math.Round(random.NextDouble(), 2),
                TotalLossGainFO = Math.Round(random.NextDouble(), 2),
                TotalLossGainGO = Math.Round(random.NextDouble(), 2)
            };
        }

        private CargoHeatingTotalVoyagePerformance CargoHeatingSeedTotalVoyagePerformance()
        {
            return new CargoHeatingTotalVoyagePerformance
            {
                TotalLossGainFO = Math.Round(random.NextDouble(), 2),
                TotalLossGainGO = Math.Round(random.NextDouble(), 2)
            };
        }

        public PumpingPerformanceData SeedPumpingPerformanceData()
        {
            var performanceData = new PumpingPerformanceData
            {
                SingleVoyageData = SeedPumpingSingleVoyageData()
            };

            return performanceData;
        }

        private List<PumpingSingleVoyageData> SeedPumpingSingleVoyageData()
        {
            var singleVoyageDataList = new List<PumpingSingleVoyageData>();

            for (int i = 0; i < 5; i++)
            {
                var singleVoyageData = new PumpingSingleVoyageData
                {
                    Title = "Voyage " + (i + 1),
                    CargoGradeName = "Grade " + (i + 1),
                    CargoType = "Type " + (i + 1),
                    ReportedData = SeedPumpingReportedData(),
                    SingleVoyagePerformance = SeedPumpingSingleVoyagePerformance()
                };

                singleVoyageDataList.Add(singleVoyageData);
            }

            return singleVoyageDataList;
        }

        private List<PumpingReportedData> SeedPumpingReportedData()
        {
            var reportedDataList = new List<PumpingReportedData>();

            for (int i = 0; i < 10; i++)
            {
                var reportedData = new PumpingReportedData
                {
                    VoyageNo =  1,
                    TotalCargoVolume = random.Next(1000, 10000),
                    Activity = "Activity " + (i + 1),
                    ActivityStartTime = DateTime.Now.AddHours(-i).ToString(),
                    ActivityEndTime = DateTime.Now.AddHours(-i + 1).ToString(),
                    ActivityActualTime = DateTime.Now.AddHours(-i + 2).ToString(),
                    Manifold = Math.Round(random.NextDouble(), 2),
                    TotalManifold = Math.Round(random.NextDouble(), 2),
                    CagoPumped = Math.Round(random.NextDouble(), 2),
                    MaxRate = Math.Round(random.NextDouble(), 2),
                    COWHours = Math.Round(random.NextDouble(), 2),
                    PressureAdjustment = Math.Round(random.NextDouble(), 2),
                    ManifoldAdj = Math.Round(random.NextDouble(), 2),
                    RateAdjustment = Math.Round(random.NextDouble(), 2),
                    ActivityCPTime = Math.Round(random.NextDouble(), 2),
                    AdjustedCPTime = Math.Round(random.NextDouble(), 2),
                    PSIWeighting = Math.Round(random.NextDouble(), 2),
                    WeightedAverage = Math.Round(random.NextDouble(), 2)
                };

                reportedDataList.Add(reportedData);
            }

            return reportedDataList;
        }

        private PumpingSingleVoyagePerformance SeedPumpingSingleVoyagePerformance()
        {
            return new PumpingSingleVoyagePerformance
            {
                StartOfOperation = DateTime.Now.AddHours(-5),
                EndOfOperation = DateTime.Now,
                ActualTimeTaken = Math.Round(random.NextDouble() * 10, 2),
                CPTime = Math.Round(random.NextDouble() * 10, 2),
                TimeLossGain = (random.Next(2) == 0) ? "Loss" : "Gain"
            };
        }
    }

}
