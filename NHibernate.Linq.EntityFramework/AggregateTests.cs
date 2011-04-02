using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NHibernate.Linq.EntityFramework
{
	[TestFixture]
	public class AggregateTests
	{
		[Test]
		[ExpectedException]
		public void SimpleAggregation()
		{
            Database db = DatabaseHelper.Create();
		    var sum = db.Primitives.Aggregate("", (agg, item) => agg + item.String);
		    Assert.AreEqual("", sum);
		}

		[Test]
		[ExpectedException]
		public void DecimalAggregation()
		{
            Database db = DatabaseHelper.Create();
            var sum = db.Primitives.Aggregate(0m, (agg, item) => agg + item.Decimal);
			Assert.AreEqual(0m, sum);
		}
	}
}
