﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="MonthNameRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by Repository.cst on 4/9/2013 4:29:50 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using ServiceStack.OrmLite;
    using WheelMUD.Data.Entities;

    /// <summary>Repository for the MonthNames table.</summary>
    public partial class MonthNameRepository : IMonthNameRepository
    {
        public void Add(MonthNameRecord monthname)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Save(monthname);
                transaction.Commit();
            }
        }

        public void Update(MonthNameRecord monthname)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Update(monthname);
                transaction.Commit();
            }
        }

        public void Remove(MonthNameRecord monthname)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Delete(monthname);
                transaction.Commit();
            }
        }

        public MonthNameRecord GetById(long monthnameId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<MonthNameRecord>("ID = {0}", monthnameId);
        }

        public MonthNameRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<MonthNameRecord>("Name = {0}", name);
            }
        }

        public ICollection<MonthNameRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<MonthNameRecord>();
            }
        }
    }
}