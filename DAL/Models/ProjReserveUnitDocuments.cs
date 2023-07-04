﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjReserveUnitDocuments
    {
        public int ReservDocId { get; set; }
        public int? ReservId { get; set; }
        public Guid Fsid { get; set; }
        public int? OwnShipBondId { get; set; }
        public int? ShelvId { get; set; }
        public string PaperNo { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public long? AttachSerial { get; set; }
        public string SearchTags { get; set; }
        public string AttachPath { get; set; }
        public byte[] Fdata { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public string IssuePlace { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }

        public virtual ProjUnitReservation Reserv { get; set; }
    }
}
