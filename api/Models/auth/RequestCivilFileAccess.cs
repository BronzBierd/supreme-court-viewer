﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scv.Api.Models.auth
{
    public class RequestCivilFileAccess
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FileId { get; set; }
        public string AgencyId { get; set; }
        public string PartId { get; set; }
    }
}
