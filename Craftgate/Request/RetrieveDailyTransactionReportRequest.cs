using Craftgate.Model;

namespace Craftgate.Request
{
    public class RetrieveDailyTransactionReportRequest
    {
        public string ReportDate { get; set; }
        public ReportFileType? FileType { get; set; }
    }
}