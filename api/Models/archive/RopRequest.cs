﻿using System.Collections.Generic;
using JCCommon.Clients.FileServices;

namespace Scv.Api.Models.archive
{
    public class RopRequest
    {
        public string PdfFileName { get; set; }
        public string PartId { get; set; }
        public string ProfSequenceNumber { get; set; }
        public CourtLevelCd CourtLevelCode { get; set; } 
        public CourtClassCd CourtClassCode { get; set; }
    }
}
