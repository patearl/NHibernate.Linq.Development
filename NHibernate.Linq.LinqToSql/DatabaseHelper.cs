using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernate.Linq.LinqToSql
{
    public class DatabaseHelper
    {
        public static Database Create()
        {
            return new Database(@"..\..\..\NHibernate.Linq.Database\Database.sdf");
        }
    }
}
