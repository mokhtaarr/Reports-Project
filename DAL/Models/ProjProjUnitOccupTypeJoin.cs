﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitOccupTypeJoin
    {
        public int ProjUnitOccupTypeJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? UnitOccuTypeId { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }

        public virtual ProjProjUnits ProjUnit { get; set; }
        public virtual CodUnitOccupancyTypes UnitOccuType { get; set; }
    }
}
