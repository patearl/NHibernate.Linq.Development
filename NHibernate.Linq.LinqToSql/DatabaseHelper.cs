using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NHibernate.Linq.LinqToSql
{
    public class DatabaseHelper
    {
        public static Database Create()
        {
            Database d = new Database(@"..\..\..\NHibernate.Linq.Database\Database.sdf");
            d.Log = Console.Out;
            return d;
        }
    }
}
