using System;
using System.Collections.Generic;

namespace Core.CounterPointModels
{
    public partial class Spot
    {
        public int AstCode { get; set; }
        public int AttCode { get; set; }
        public int SpotSeqNum { get; set; }
        public int CpyRotCode { get; set; }
        public string? Advt { get; set; }
        public string? Prod { get; set; }
        public string? TranType { get; set; }
        public DateTime PledgeStartDate { get; set; }
        public DateTime? PledgeEndDate { get; set; }
        public DateTime? PledgeStartTime { get; set; }
        public DateTime? PledgeEndTime { get; set; }
        public DateTime? FeedDate { get; set; }
        public DateTime? FeedTime { get; set; }
        public string? StatusCode { get; set; }
        public int? SpotLen { get; set; }
        public string? Cart { get; set; }
        public string? Isci { get; set; }
        public string? CreativeTitle { get; set; }
        public string? AvailName { get; set; }
        public DateTime? ActualAirDate { get; set; }
        public DateTime? ActualAirtime { get; set; }
        public DateTime? ActualDateTime { get; set; }
        public int? DescrepancyCode { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ExportDate { get; set; }
        public int PostedFlag { get; set; }
        public int ExportedFlag { get; set; }
        public DateTime SentDate { get; set; }
        public string? OrgstatusCode { get; set; }
        public string? GsfCode { get; set; }
        public string? RecType { get; set; }
        public DateTime? RotendDate { get; set; }
        public long? Srlink { get; set; }
        public DateTime EstimatedTime { get; set; }
        public string IsDayPart { get; set; } = null!;
        public string EstimatedDay { get; set; } = null!;
        public string BeforeOrAfter { get; set; } = null!;
        public string TrueDaysPledged { get; set; } = null!;
        public int? Mrreason { get; set; }
        public int? OrgAstCode { get; set; }
        public int? NewAstCode { get; set; }
        public int? SrcAttCode { get; set; }
        public string? ShowVehName { get; set; }
        public string? Source { get; set; }
        public string? FlightDays { get; set; }
        public int? CntrNumber { get; set; }
        public DateTime? FlightStartTime { get; set; }
        public DateTime? FlightEndTime { get; set; }
        public int? AdfCode { get; set; }
        public int? Blackout { get; set; }
        public string? EmbeddedOrRos { get; set; }
        public string? IsOverridable { get; set; }
    }
}
