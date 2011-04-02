using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.EntityClient;
using System.Linq;
using System.Text;
using EFProviderWrapperToolkit;
using EFTracingProvider;

namespace NHibernate.Linq.EntityFramework
{
    class DatabaseHelper
    {
        public static Database Create()
        {
            EFTracingProviderConfiguration.LogToConsole = true;
            EntityConnection connection = EntityConnectionWrapperUtils.CreateEntityConnectionWithWrappers(
                ConfigurationManager.ConnectionStrings["DatabaseEntities"].ConnectionString,
                "EFTracingProvider");
            return new Database(connection);
        }
    }
}
