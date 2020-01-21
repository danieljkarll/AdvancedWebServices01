﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modas.Models
{
    interface IEventRepository
    {
        IQueryable<Event> Events { get; }
        IQueryable<Location> Locations { get; }
    }
}