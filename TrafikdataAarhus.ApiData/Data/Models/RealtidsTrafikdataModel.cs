namespace TrafikdataAarhus.ApiData.Data.Models
{
    using System;

    public class RealtidsTrafikdataModel
    {
        public int _id { get; set; }
        public int REPORT_ID { get; set; }
        public DateTime TIMESTAMP { get; set; }
        public string status { get; set; }
        public int avgMeasuredTime { get; set; }
        public int medianMeasuredTime { get; set; }
        public int vehicleCount { get; set; }
        public int avgSpeed { get; set; }
    }
}