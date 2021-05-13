using System;
using NUnit.Framework;

namespace HiNUnit
{
    public class PropertiesTest
    {
        [Test]
        public void Test()
        {
            UserAA aa = new UserAA("q", "qq");
            aa.Id = "007";
            Console.WriteLine(aa);
        }
    }

    class UserAA
    {
        public UserAA(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"id={Id},name={Name}";
        }
    }
}