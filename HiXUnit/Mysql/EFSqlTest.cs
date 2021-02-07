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
    public class EFSqlTest
    {
        private ITestOutputHelper OutputHelper { get; }

        public EFSqlTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void Test()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");

            string name = "xqq";

            using (var context = new UserContext())
            {
                context.Users.FromSqlRaw("select");
                OutputHelper.WriteLine("idddd=>{2}, ");
                Assert.True(0 != 1);
            }
        }
    }
}
