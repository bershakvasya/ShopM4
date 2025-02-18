﻿using ShopM4_DataMigrations.Data;
using ShopM4_DataMigrations.Repository.IReporitory;
using ShopM4_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM4_DataMigrations.Repository
{
    public class RepositoryApplicationUser : Repository<ApplicationUser>, IRepositoryApplicationUser
    {
        public RepositoryApplicationUser(ApplicationDbContext db) : base(db)
        {
        }
    }
}
