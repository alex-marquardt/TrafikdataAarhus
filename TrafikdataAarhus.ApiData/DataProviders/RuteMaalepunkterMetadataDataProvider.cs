namespace TrafikdataAarhus.ApiData.DataProviders
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Dapper;
    using TrafikdataAarhus.ApiData.Data;
    using TrafikdataAarhus.ApiData.Data.Models;

    public class RuteMaalepunkterMetadataDataProvider
    {
        // Get data from RuteMaalepunkterMetadata API
        public async Task<RuteMaalepunkterMetadataModel[]> GetruteMaalepunkterMetadataAarhus()
        {
            string url = "http://portal.opendata.dk/api/3/action/datastore_search?resource_id=c3097987-c394-4092-ad1d-ad86a81dbf37";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    RuteMaalepunkterMetadataResultModel models = await response.Content.ReadAsAsync<RuteMaalepunkterMetadataResultModel>();

                    foreach (var model in models.result.records)
                    {
                        await InsertRuteMaalepunkterMetadata(model);
                    }

                    return models.result.records;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        // Save RuteMaalepunkterMetadata data in database
        private async Task InsertRuteMaalepunkterMetadata(RuteMaalepunkterMetadataModel model)
        {
            using (var conn = new SqlConnection(@"Data Source=ALEX-LENOVO530S\SQLEXPRESS;Initial Catalog=AarhusTrafikdata;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model._id);
                parameters.Add("@ReportName", model.REPORT_NAME);
                parameters.Add("@ReportId", model.REPORT_ID);
                parameters.Add("@Organisation", model.ORGANISATION);
                parameters.Add("@RbaId", model.RBA_ID);
                parameters.Add("@Point1Name", model.POINT_1_NAME);
                parameters.Add("@Point1Latitude", model.POINT_1_LAT);
                parameters.Add("@Point1Longitude", model.POINT_1_LNG);
                parameters.Add("@Point1Street", model.POINT_1_STREET);
                parameters.Add("@Point1StreetNumber", model.POINT_1_STREET_NUMBER);
                parameters.Add("@Point1PostalCode", model.POINT_1_POSTAL_CODE);
                parameters.Add("@Point1Country", model.POINT_1_COUNTRY);
                parameters.Add("@Point2Name", model.POINT_2_NAME);
                parameters.Add("@Point2Latitude", model.POINT_2_LAT);
                parameters.Add("@Point2Longitude", model.POINT_2_LNG);
                parameters.Add("@Point2StreetNumber", model.POINT_2_STREET_NUMBER);
                parameters.Add("@Point2PostalCode", model.POINT_2_POSTAL_CODE);
                parameters.Add("@Point2City", model.POINT_2_CITY);
                parameters.Add("@Point2Country", model.POINT_2_COUNTRY);
                parameters.Add("@DurationInSeconds", model.DURATION_IN_SEC);
                parameters.Add("@DistanceInMeters", model.DISTANCE_IN_METERS);
                parameters.Add("@NdtInKmh", model.NDT_IN_KMH);
                parameters.Add("@RoadType", model.ROAD_TYPE);
                parameters.Add("@Point1City", model.POINT_1_CITY);
                parameters.Add("@Point2Street", model.POINT_2_STREET);              

                await conn.ExecuteAsync("InsertRuteMaalepunkterMetadata", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
