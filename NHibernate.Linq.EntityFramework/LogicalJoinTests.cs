using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace NHibernate.Linq.EntityFramework
{
    [TestFixture]
    public class LogicalJoinTests
    {
        [Test]
        public void BasicPropertyEquality()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => ea.Primitive.NullableDecimal == 1).ToList();
            Assert.AreEqual(1, entityAs.Count);
            Assert.AreEqual(1, entityAs[0].Primitive.NullableDecimal);
        }

        [Test]
        public void BasicPropertyEquality2()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => ea.Primitive.NullableDecimal == 2).ToList();
            Assert.AreEqual(2, entityAs.Count);
            Assert.AreEqual(2, entityAs[0].Primitive.NullableDecimal);
            Assert.AreEqual(2, entityAs[1].Primitive.NullableDecimal);
        }

        [Test]
        public void BasicPropertyInequality()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => ea.Primitive.NullableDecimal != 1).ToList();
            Assert.AreEqual(2, entityAs.Count);
            Assert.AreEqual(2, entityAs[0].Primitive.NullableDecimal);
            Assert.AreEqual(2, entityAs[1].Primitive.NullableDecimal);
        }

        [Test]
        public void BasicPropertyInequality2()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => ea.Primitive.NullableDecimal != 2).ToList();
            Assert.AreEqual(1, entityAs.Count);
            Assert.AreEqual(1, entityAs[0].Primitive.NullableDecimal);
        }

        [Test]
        public void InvertedInequality()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => !(ea.Primitive.NullableDecimal == 1)).ToList();
            Assert.AreEqual(2, entityAs.Count);
            Assert.AreEqual(2, entityAs[0].Primitive.NullableDecimal);
            Assert.AreEqual(2, entityAs[1].Primitive.NullableDecimal);
        }

        [Test]
        public void InvertedInequality2()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => !(ea.Primitive.NullableDecimal == 2)).ToList();
            Assert.AreEqual(1, entityAs.Count);
            Assert.AreEqual(1, entityAs[0].Primitive.NullableDecimal);
        }

        [Test]
        public void NullEquality()
        {
            Database db = DatabaseHelper.Create();
            var entityAs = db.EntityAs.Where(ea => ea.Primitive.NullableDecimal == null).ToList();
            Assert.AreEqual(2, entityAs.Count);
        }
    }
}
