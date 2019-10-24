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

    public class RealtidsTrafikdataDataProvider
    {
        // Get data from RealtidsTrafikdata API
        public async Task<RealtidsTrafikdataModel[]> GetRealtidsTrafikdataAarhus()
        {
            string url = "https://portal.opendata.dk/api/3/action/datastore_search?resource_id=b3eeb0ff-c8a8-4824-99d6-e0a3747c8b0d";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    RealtidsTrafikdataResultModel models = await response.Content.ReadAsAsync<RealtidsTrafikdataResultModel>();

                    foreach (var model in models.result.records)
                    {
                        await InsertRealtidsTrafikdata(model);
                    }

                    return models.result.records;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        // Save RealtidsTrafikdata data in database
        private async Task InsertRealtidsTrafikdata(RealtidsTrafikdataModel model)
        {
            using (var conn = new SqlConnection(@"Data Source=ALEX-LENOVO530S\SQLEXPRESS;Initial Catalog=AarhusTrafikdata;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Id", model._id);
                parameters.Add("@ReportId", model.REPORT_ID);
                parameters.Add("@TimeStamp", model.TIMESTAMP);
                parameters.Add("@Status", model.status);
                parameters.Add("@AvgMeasuredTime", model.avgMeasuredTime);
                parameters.Add("@MedianMeasuredTime", model.medianMeasuredTime);
                parameters.Add("@VehicleCount", model.vehicleCount);
                parameters.Add("@AvgSpeed", model.avgSpeed);

                await conn.ExecuteAsync("InsertRealtidsTrafikdata", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}