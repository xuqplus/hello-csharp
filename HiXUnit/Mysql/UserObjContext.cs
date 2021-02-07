using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Text;

namespace HiXUnit.Mysql
{
    public class UserObjContext : ObjectContext
    {
        public UserObjContext(EntityConnection connection) : base(connection)
        {
        }

        public UserObjContext(string connectionString) : base(connectionString)
        {
        }

        public UserObjContext(EntityConnection connection, bool contextOwnsConnection) : base(connection, contextOwnsConnection)
        {
        }

        protected UserObjContext(string connectionString, string defaultContainerName) : base(connectionString, defaultContainerName)
        {
        }

        protected UserObjContext(EntityConnection connection, string defaultContainerName) : base(connection, defaultContainerName)
        {
        }
    }
}
