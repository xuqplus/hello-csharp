using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using System.Runtime.InteropServices;

namespace HiXUnit.Mysql
{
    public class EntityFrameworkMysqlTest
    {
        private ITestOutputHelper OutputHelper { get; }

        public EntityFrameworkMysqlTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void Test()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");

            string name = "xqq";

            using (var db = new UserContext())
            {
                User user = new User();
                user.Name = name;
                EntityEntry<User> entityEntry = db.Add(user);
                User entity = entityEntry.Entity;

                OutputHelper.WriteLine("user=>{2}, user.id=>{0}, user.name=>{1}, ", user.Id, user.Name, GetAddr(user));
                OutputHelper.WriteLine("entity=>{2}, entity.id=>{0}, entity.name=>{1}, ", entity.Id, entity.Name, GetAddr(entity));
                Assert.True(0 == entity.Id);
                Assert.True(name.Equals(entity.Name));
                db.SaveChanges();

                OutputHelper.WriteLine("user=>{2}, user.id=>{0}, user.name=>{1}, ", user.Id, user.Name, GetAddr(user));
                OutputHelper.WriteLine("entity=>{2}, entity.id=>{0}, entity.name=>{1}, ", entity.Id, entity.Name, GetAddr(entity));
                Assert.True(0 != entity.Id);
            }
        }

        private string GetAddr(object o)
        {
            return "0x" + GCHandle.ToIntPtr(GCHandle.Alloc(o, GCHandleType.WeakTrackResurrection)).ToString("X");
        }

        [Fact]
        public void TestQuery()
        {
            string name = "xqq";

            using (var db = new UserContext())
            {
                User user = new User();
                user.Name = name;

                User user1 = db.Users.Find(1);

                OutputHelper.WriteLine("user1=>{2}, user1.id=>{0}, user1.name=>{1}, ", user1.Id, user1.Name, GetAddr(user1));
                Assert.True(0 != user1.Id);
            }
        }
    }
}
