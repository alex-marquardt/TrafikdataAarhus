using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafikdataAarhus.ApiData.Data.Models;
using TrafikdataAarhus.ApiData.DataProviders;

namespace TrafikdataAarhus.ApiData.Managers
{
    public class RealtidsTrafikdataManager
    {
        private RealtidsTrafikdataDataProvider _realtidsTrafikdataDataProvider;

        public RealtidsTrafikdataManager()
        {
            _realtidsTrafikdataDataProvider = new RealtidsTrafikdataDataProvider();
        }

        public async Task SaveRealtidsTrafikdata(RealtidsTrafikdataModel[] models)
        {
            foreach (var model in models)
            {
                await _realtidsTrafikdataDataProvider.InsertRealtidsTrafikdata(model);                
            }
        }

    }
}
