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
        static string cs = @"server=localhost;userid=test;password=123456;database=csharp";

        private ITestOutputHelper OutputHelper { get; }

        public MysqlTest(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void TestMysqlVersion()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
            using var con = new MySqlConnection(cs);
            con.Open();
            OutputHelper.WriteLine($"MySQL version : {con.ServerVersion}");
            Assert.True("8.0.23".Equals(con.ServerVersion));
        }

        [Fact]
        public void TestSelectMysqlVersion()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
            using var con = new MySqlConnection(cs);
            con.Open();
            var stm = "SELECT VERSION()";
            var cmd = new MySqlCommand(stm, con);
            var version = cmd.ExecuteScalar().ToString();
            OutputHelper.WriteLine($"MySQL version : {version}");
            Assert.True("8.0.23".Equals(version));
        }

        [Fact]
        public void TestCreateTable()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");

            using var con = new MySqlConnection(cs);
            con.Open();

            using var cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "DROP TABLE IF EXISTS cars";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE cars(id INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, price INT)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Mercedes',57127)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Skoda',9000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volvo',29000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Bentley',350000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Citroen',21000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Hummer',41400)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Volkswagen',21600)";
            cmd.ExecuteNonQuery();

            OutputHelper.WriteLine("Table cars created");
        }


        [Fact]
        public void TestInsertWithValue()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
            using var con = new MySqlConnection(cs);
            con.Open();
            var sql = "INSERT INTO cars(name, price) VALUES(@name, @price)";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", "BMW");
            cmd.Parameters.AddWithValue("@price", 36600);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            OutputHelper.WriteLine("row inserted");
        }

        [Fact]
        public void TestMySqlDataReader()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
            using var con = new MySqlConnection(cs);
            con.Open();
            string sql = "SELECT * FROM cars";
            using var cmd = new MySqlCommand(sql, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                OutputHelper.WriteLine("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
            }
        }

        [Fact]
        public void Test()
        {
            OutputHelper.WriteLine("this is xunit - MysqlTest");
        }


    }
}
