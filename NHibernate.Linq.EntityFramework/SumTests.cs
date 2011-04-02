using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NHibernate.Linq.EntityFramework
{
	[TestFixture]
	public class SumTests
	{
		[Test]
		[ExpectedException]
		public void EmptySumDecimal()
		{
            DatabaseEntities db = new DatabaseEntities();
            decimal sum = db.Primitives.Where(a => false).Sum(a => a.Decimal);
			Assert.AreEqual(0, sum);
		}

		[Test]
		public void EmptySumCastNullableDecimal()
		{
            DatabaseEntities db = new DatabaseEntities();
            decimal? sum = db.Primitives.Where(a => false).Sum(a => (decimal?)a.Decimal);
			Assert.AreEqual(null, sum);
		}

		[Test]
		public void EmptySumNullableDecimal()
		{
            DatabaseEntities db = new DatabaseEntities();
            decimal? sum = db.Primitives.Where(a => false).Sum(a => a.NullableDecimal);
			Assert.AreEqual(null, sum);
		}
	}
}
