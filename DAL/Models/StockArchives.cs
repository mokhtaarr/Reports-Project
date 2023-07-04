﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockArchives
    {
        public StockArchives()
        {
            StockPortfolioStockArchives = new HashSet<StockPortfolioStockArchives>();
        }

        public int StockArchId { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string RemarksA { get; set; }
        public string RemarksE { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<StockPortfolioStockArchives> StockPortfolioStockArchives { get; set; }
    }
}
