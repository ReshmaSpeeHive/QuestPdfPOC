using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPdfPOC.Model
{
    public class PumpingPerformanceData
    {
        public List<PumpingSingleVoyageData> SingleVoyageData { get; set; }

    
    }
    public class PumpingSingleVoyageData
    {
       
        public string Title { get; set; }

        public string CargoGradeName { get; set; }
        public string CargoType { get; set; }
        public string DischargePort { get; set; }
        public List<PumpingReportedData> ReportedData { get; set; }
        public PumpingSingleVoyagePerformance SingleVoyagePerformance { get; set; }

    }
    public class PumpingReportedData
    {
        public long VoyageNo { get; set; }
        public long TotalCargoVolume { get; set; }
        public string? Activity { get; set; }
        public string? ActivityStartTime { get; set; }
        public string? ActivityEndTime { get; set; }
        public string? ActivityActualTime { get; set; }
        public double Manifold { get; set; }
        public double TotalManifold { get; set; }
        public double CagoPumped { get; set; }
        public double MaxRate { get; set; }
        public double COWHours { get; set; }
        public double PressureAdjustment { get; set; }
        public double ManifoldAdj { get; set; }
        public double RateAdjustment { get; set; }
        public double ActivityCPTime { get; set; }
        public double AdjustedCPTime { get; set; }
        public double PSIWeighting { get; set; }
        public double WeightedAverage { get; set; }
    }
    public class PumpingSingleVoyagePerformance
    {
        public DateTime StartOfOperation { get;  set; }
        public DateTime EndOfOperation { get; set;}
        public double ActualTimeTaken { get; set; }
        public double CPTime { get; set; }
        public string TimeLossGain{ get; set; }
    }
}
