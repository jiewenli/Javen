﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using Javen.Authorization.Roles;
using Javen.MultiTenancy;
using Javen.Users;

namespace Javen.EntityFramework
{
    public class JavenDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public JavenDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in JavenDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of JavenDbContext since ABP automatically handles it.
         */
        public JavenDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public JavenDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public JavenDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
