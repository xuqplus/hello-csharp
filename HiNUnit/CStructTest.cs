using NUnit.Framework;

namespace HiNUnit
{
    class CStructTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            AA aa = new AA {User = new User("007", "xqq")};
            // aa.User.Id = "7";
            TestContext.WriteLine("aa.user.id={0}, aa.user.name={1}", aa.User.Id, aa.User.Name);
        }
    }

    internal struct User
    {
        public string Id;

        public readonly string Name;

        public User(string id, string name) : this()
        {
            this.Id = id;
            this.Name = name;
        }
    }

    class AA
    {
        public User User { get; set; }
    }
}