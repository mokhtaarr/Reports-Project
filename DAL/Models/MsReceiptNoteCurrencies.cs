﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsReceiptNoteCurrencies
    {
        public int RecCurId { get; set; }
        public int? RectId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public decimal? Value { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual MsReceiptNote Rect { get; set; }
    }
}