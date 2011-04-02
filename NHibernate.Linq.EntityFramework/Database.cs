using System.Data.EntityClient;

namespace NHibernate.Linq.EntityFramework
{
    public class Database : DatabaseEntities
    {
        public Database(EntityConnection connection) : base(connection)
        {
            
        }
    }
}