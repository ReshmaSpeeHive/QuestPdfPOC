using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfPOC.Model
{
    public class TankCleaningPerformanceData
    {

        public List<TankCleaningSingleVoyageData> SingleVoyageData { get; set; }

        public TankCleaningTotalVoyagePerformance TotalVoyagePerformance { get; set; }

    }



    public class TankCleaningSingleVoyageData
    {
        public double WarrantedConsumptionFO { get; set; }

        public double WarrantedConsumptionGO { get; set; }

        public string Title { get; set; }
        public List<TankCleaningReportedData> ReportedData { get; set; }
        public TankCleaningSingleVoyagePerformance SingleVoyagePerformance { get; set; }

    }


    public class TankCleaningReportedData
    {
        // Form Reported Datetime from DB
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

    public class TankCleaningSingleVoyagePerformance
    {

        public double WarrantedConsumptionFO { get; set; }

        public double WarrantedConsumptionGO { get; set; }

        public double TotalLossGainFO { get; set; }

        public double TotalLossGainGO { get; set; }

    }

    public class TankCleaningTotalVoyagePerformance
    {

        public double TotalLossGainFO { get; set; }

        public double TotalLossGainGO { get; set; }

    }
}
