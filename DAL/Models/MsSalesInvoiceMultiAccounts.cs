﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvoiceMultiAccounts
    {
        public int SalesMultiAccountId { get; set; }
        public int? InvId { get; set; }
        public string DbtableName { get; set; }
        public int? DbtableId { get; set; }
        public string AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        public int? RectSourceTypeId { get; set; }
        public decimal? RectSourceBalance { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? CostCenterId4 { get; set; }
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public decimal? DebitLocal { get; set; }
        public decimal? CreditLocal { get; set; }
        public string Remarks { get; set; }

        public virtual MsSalesInvoice Inv { get; set; }
    }
}
