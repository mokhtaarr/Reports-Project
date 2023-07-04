﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrderJobs
    {
        public int JobJobId { get; set; }
        public int? JobOrderId { get; set; }
        public int? TaskJobJoinId { get; set; }
        public int? JobId { get; set; }
        public int? TaskId { get; set; }
        public int? JorderEmpDocId { get; set; }
        public int? JorderEmpDocDetailId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? RequestedNumber { get; set; }
        public int? RealNumber { get; set; }
        public decimal? TimeBeforFormat { get; set; }
        public byte? TimeUnit { get; set; }
        public decimal? Minutes { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Days { get; set; }
        public decimal? Months { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ProdJobOrder JobOrder { get; set; }
    }
}
