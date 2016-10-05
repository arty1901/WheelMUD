﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="PlayerRoleRepository.cs" company="WheelMUD Development Team">
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

    /// <summary>Repository for the PlayerRoles table.</summary>
    public partial class PlayerRoleRepository : IPlayerRoleRepository
    {
        public void Add(PlayerRoleRecord playerrole)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Save(playerrole);
                transaction.Commit();
            }
        }

        public void Update(PlayerRoleRecord playerrole)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Update(playerrole);
                transaction.Commit();
            }
        }

        public void Remove(PlayerRoleRecord playerrole)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Delete(playerrole);
                transaction.Commit();
            }
        }

        public PlayerRoleRecord GetById(long playerroleId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<PlayerRoleRecord>("ID = {0}", playerroleId);
        }

        public PlayerRoleRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<PlayerRoleRecord>("Name = {0}", name);
            }
        }

        public ICollection<PlayerRoleRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<PlayerRoleRecord>();
            }
        }
    }
}