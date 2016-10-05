﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="IDoorRepository.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by RepositoryInterface.cst on 7/7/2012 4:24:10 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using System.Collections.Generic;

    /// <summary>Repository interface for the Door entity.</summary>
    public interface IDoorRepository
    {
        void Add(DoorRecord door);
        void Update(DoorRecord door);
        void Remove(DoorRecord door);
        DoorRecord GetById(long doorId);
        DoorRecord GetByName(string name);
        ICollection<DoorRecord> FetchAll();
    }
}