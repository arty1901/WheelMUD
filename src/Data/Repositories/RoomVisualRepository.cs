﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="RoomVisualRepository.cs" company="WheelMUD Development Team">
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

    /// <summary>Repository for the RoomVisuals table.</summary>
    public partial class RoomVisualRepository : IRoomVisualRepository
    {
        public void Add(RoomVisualRecord roomvisual)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Save(roomvisual);
                transaction.Commit();
            }
        }

        public void Update(RoomVisualRecord roomvisual)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Update(roomvisual);
                transaction.Commit();
            }
        }

        public void Remove(RoomVisualRecord roomvisual)
        {
            using (IDbCommand session = Helpers.OpenSession())
            using (IDbTransaction transaction = session.Connection.BeginTransaction())
            {
                session.Connection.Delete(roomvisual);
                transaction.Commit();
            }
        }

        public RoomVisualRecord GetById(long roomvisualId)
        {
            using (IDbCommand session = Helpers.OpenSession())
                return session.Connection.SingleWhere<RoomVisualRecord>("ID = {0}", roomvisualId);
        }

        public RoomVisualRecord GetByName(string name)
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.SingleWhere<RoomVisualRecord>("Name = {0}", name);
            }
        }

        public ICollection<RoomVisualRecord> FetchAll()
        {
            using (IDbCommand session = Helpers.OpenSession())
            {
                return session.Connection.Select<RoomVisualRecord>();
            }
        }
    }
}