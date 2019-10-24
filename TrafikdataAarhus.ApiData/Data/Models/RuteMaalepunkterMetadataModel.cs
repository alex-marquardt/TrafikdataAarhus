namespace TrafikdataAarhus.ApiData.Data.Models
{
    public class RuteMaalepunkterMetadataModel
    {
        public int _id { get; set; }
        public string REPORT_NAME { get; set; }
        public int REPORT_ID { get; set; }
        public string ORGANISATION { get; set; }
        public int RBA_ID { get; set; }
        public string POINT_1_NAME { get; set; }
        public float POINT_1_LAT { get; set; }
        public float POINT_1_LNG { get; set; }
        public string POINT_1_STREET { get; set; }
        public string POINT_1_STREET_NUMBER { get; set; }
        public string POINT_1_POSTAL_CODE { get; set; }
        public string POINT_1_COUNTRY { get; set; }
        public string POINT_2_NAME { get; set; }
        public float POINT_2_LAT { get; set; }
        public float POINT_2_LNG { get; set; }
        public string POINT_2_STREET_NUMBER { get; set; }
        public string POINT_2_POSTAL_CODE { get; set; }
        public string POINT_2_CITY { get; set; }
        public string POINT_2_COUNTRY { get; set; }
        public int DURATION_IN_SEC { get; set; }
        public int DISTANCE_IN_METERS { get; set; }
        public int NDT_IN_KMH { get; set; }
        public string ROAD_TYPE { get; set; }
        public string POINT_1_CITY { get; set; }
        public string POINT_2_STREET { get; set; }
    }
}