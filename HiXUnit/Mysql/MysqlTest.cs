using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace HiXUnit.Mysql
{
    public class MysqlTest
    {
        private ITestOutputHelper OutputHelper { get; }

        public MysqlTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void TestMysqlVersion()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
            string cs = @"server=localhost;userid=test;password=123456;database=csharp";
            using var con = new MySqlConnection(cs);
            con.Open();
            OutputHelper.WriteLine($"MySQL version : {con.ServerVersion}");
            Assert.True("8.0.23".Equals(con.ServerVersion));
        }

        [Fact]
        public void TestSelectMysqlVersion()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
            string cs = @"server=localhost;userid=test;password=123456;database=csharp";
            using var con = new MySqlConnection(cs);
            con.Open();
            var stm = "SELECT VERSION()";
            var cmd = new MySqlCommand(stm, con);
            var version = cmd.ExecuteScalar().ToString();
            OutputHelper.WriteLine($"MySQL version : {version}");
            Assert.True("8.0.23".Equals(version));
        }


    }
}
