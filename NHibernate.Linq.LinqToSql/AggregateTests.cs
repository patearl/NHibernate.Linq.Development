using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NHibernate.Linq.LinqToSql
{
	[TestFixture]
	public class AggregateTests
	{
		[Test]
		[ExpectedException]
		public void SimpleAggregation()
		{
			Database db = DatabaseHelper.Create();
		    var sum = db.Primitive.Aggregate("", (agg, item) => agg + item.String);
		    Assert.AreEqual("", sum);
		}

		[Test]
		[ExpectedException]
		public void DecimalAggregation()
		{
            Database db = DatabaseHelper.Create();
            var sum = db.Primitive.Aggregate(0m, (agg, item) => agg + item.Decimal);
			Assert.AreEqual(0m, sum);
		}
	}
}
