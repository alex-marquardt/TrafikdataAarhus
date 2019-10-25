namespace TrafikdataAarhus.Gmap.DataProviders
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using Dapper;
    using TrafikdataAarhus.Gmap.Data;

    public class TrafikdataDataProvider
    {
        // Get all trafikdata in Aarhus from database
        public IEnumerable<TrafikdataModel> GetTrafikdataAarhus()
        {
            using (var conn = new SqlConnection(@"Data Source=ALEX-LENOVO530S\SQLEXPRESS;Initial Catalog=AarhusTrafikdata;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();

                return conn.Query<TrafikdataModel>("SelectAllTrafikdata", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
