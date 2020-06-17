﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JCCommon.Clients.FileServices;

namespace Scv.Api.Models.CourtList
{
    public class HearingRestriction : ClHearingRestriction
    {
        public string HearingRestrictionTypeDesc { get; set; }
        public string AdjInitialsText => !string.IsNullOrEmpty(JudgeName) ? Regex.Replace(JudgeName, @"(?i)(?:^|\s|-)+([^\s-])[^\s-]*(?:(?:\s+)(?:the\s+)?(?:jr|sr|II|2nd|III|3rd|IV|4th)\.?$)?", "$1").ToUpper() : null;
    }
}
