﻿using System.Collections.Generic;
using JCCommon.Clients.FileServices;
using Scv.Api.Models.CourtList;

namespace Scv.Api.Models.Civil.CourtList
{
    public class CivilCourtList : ClCivilCourtList
    {
        public string EstimatedTimeHour { get; set; }
        public string EstimatedTimeMin { get; set; }
        public bool CfcsaFile { get; set; }
        public bool Video { get; set; }
        public bool RemoteVideo { get; set; }
        public string ActivityClassCd { get; set; }
        public string ActivityClassDesc { get; set; }
        public string OutOfTownJudge { get; set; }
        public string SupplementalEquipment { get; set; }
        public string SecurityRestriction { get; set; }
        public string AppearanceReasonDesc { get; set; }
        public string AppearanceReasonCd { get; set; }
        public string AppearanceStatusCd { get; set; }
        public string JudgeInitials { get; set; }
        public string CommentToJudgeText { get; set; }
        public string FileCommentText { get; set; }
        public string TrialRemarkTxt { get; set; }

        public new ICollection<ScheduledAppearance> ScheduledAppearance { get; set; }
        public new ICollection<HearingRestriction> HearingRestriction { get; set; }
        public new ICollection<CivilClDocument> Document { get; set; }
    }
}
