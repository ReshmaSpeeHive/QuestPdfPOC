using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfPOC.Model
{
    public class CargoHeatingPerformanceData
    {
        public List<CargoHeatingSingleVoyageData> SingleVoyageData { get; set; }

        public CargoHeatingTotalVoyagePerformance TotalVoyagePerformance { get; set; }

    }



    public class CargoHeatingSingleVoyageData
    {
        public double WarrantedConsumptionFO { get; set; }

        public double WarrantedConsumptionGO { get; set; }

        public string Title { get; set; }
        public List<CargoHeatingReportedData> ReportedData { get; set; }
        public CargoHeatingSingleVoyagePerformance SingleVoyagePerformance { get; set; }

    }


    public class CargoHeatingReportedData
    {
        // Form Reported Datetime from DB
        public string Operation { get; set; }
        public DateTime ReportedDateTime { get; set; }

        public double HoursOfTankCleaned { get; set; }

        public int NumberOfTanksCleaned { get; set; }

        // From Terms
        public int TotalNumberOfTanks { get; set; }

        public double ActualConsumptionFO { get; set; }

        public double ActualConsumptionGO { get; set; }

        public double WarrantedConsumptionFO { get; set; }

        public double WarrantedConsumptionGO { get; set; }

        public double FuelLossGainFO { get; set; }

        public double FuelLossGainGO { get; set; }

    }

    public class CargoHeatingSingleVoyagePerformance
    {

        public double WarrantedConsumptionFO { get; set; }

        public double WarrantedConsumptionGO { get; set; }

        public double TotalLossGainFO { get; set; }

        public double TotalLossGainGO { get; set; }

    }

    public class CargoHeatingTotalVoyagePerformance
    {

        public double TotalLossGainFO { get; set; }

        public double TotalLossGainGO { get; set; }

    }
}
