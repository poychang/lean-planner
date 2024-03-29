﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace LeanPlanner.Web.Infrastructure
{
    public static class StructureMapBootstrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x=>x.AddRegistry(new LeanPlannerRegistry()));
        }
    }
}
