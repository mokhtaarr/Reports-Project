﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitInstallTemp
    {
        public int ProjUnitInstallTempId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? InstallTempId { get; set; }

        public virtual CodInstallmentTemps InstallTemp { get; set; }
        public virtual ProjProjUnits ProjUnit { get; set; }
    }
}
