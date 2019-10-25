namespace TrafikdataAarhus.Gmap.Data
{
    using System;

    public class TrafikdataModel
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Status { get; set; }
        public int AvgMeasuredTime { get; set; }
        public int MedianMeasuredTime { get; set; }
        public int VehicleCount { get; set; }
        public int AvgSpeed { get; set; }
        public string ReportName { get; set; }
        public string Organisation{ get; set; }
        public int RbaId { get; set; }
        public string Point1Name { get; set; }
        public float Point1Latitude { get; set; }
        public float Point1Longitude { get; set; }
        public string Point1Street { get; set; }
        public string Point1StreetNumber { get; set; }
        public string Point1PostalCode { get; set; }
        public string Point1City { get; set; }
        public string Point1Country { get; set; }
        public string Point2Name { get; set; }
        public float Point2Latitude { get; set; }
        public float Point2Longitude { get; set; }
        public string Point2Street { get; set; }
        public string Point2StreetNumber { get; set; }
        public string Point2PostalCode { get; set; }
        public string Point2City { get; set; }
        public string Point2Country { get; set; }
        public int DurationInSeconds { get; set; }
        public int DistanceInMeters { get; set; }
        public int NdtInKmh { get; set; }
        public string RoadType { get; set; }
    }
}
