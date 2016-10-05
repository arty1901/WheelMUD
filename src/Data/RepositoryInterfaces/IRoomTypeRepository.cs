﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IRoomTypeRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by RepositoryInterface.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using System.Collections.Generic;

    /// <summary>Repository interface for the RoomType entity.</summary>
    public interface IRoomTypeRepository
    {
        void Add(RoomTypeRecord roomtype);
        void Update(RoomTypeRecord roomtype);
        void Remove(RoomTypeRecord roomtype);
        RoomTypeRecord GetById(long roomtypeId);
        RoomTypeRecord GetByName(string name);
        ICollection<RoomTypeRecord> FetchAll();
    }
}