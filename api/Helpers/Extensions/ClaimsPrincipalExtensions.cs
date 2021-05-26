﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Scv.Api.Helpers.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string ParticipantId(this ClaimsPrincipal claimsPrincipal)
        {
            var identity = (ClaimsIdentity)claimsPrincipal.Identity;
            return identity.Claims.FirstOrDefault(c => c.Type == CustomClaimTypes.JcParticipantId)?.Value;
        }

        public static string AgencyCode(this ClaimsPrincipal claimsPrincipal)
        {
            var identity = (ClaimsIdentity)claimsPrincipal.Identity;
            return identity.Claims.FirstOrDefault(c => c.Type == CustomClaimTypes.JcAgencyCode)?.Value;
        }

        public static string PreferredUsername(this ClaimsPrincipal claimsPrincipal) =>
            claimsPrincipal.FindFirstValue(CustomClaimTypes.PreferredUsername);

        public static List<string> Groups(this ClaimsPrincipal claimsPrincipal)
        {
            var identity = (ClaimsIdentity)claimsPrincipal.Identity;
            return identity.Claims.Where(c => c.Type == CustomClaimTypes.Groups).Select(s => s.Value).ToList();
        }

        public static bool IsServiceAccountUser(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.HasClaim(c => c.Type == CustomClaimTypes.PreferredUsername) && 
               claimsPrincipal.FindFirstValue(CustomClaimTypes.PreferredUsername).Equals("service-account-scv");

        public static bool IsIdirUser(this ClaimsPrincipal claimsPrincipal)
        => claimsPrincipal.HasClaim(c => c.Type == CustomClaimTypes.PreferredUsername) && 
           claimsPrincipal.FindFirstValue(CustomClaimTypes.PreferredUsername).EndsWith("@idir");

        public static bool IsSupremeUser(this ClaimsPrincipal claimsPrincipal)
        => claimsPrincipal.HasClaim(c => c.Type == CustomClaimTypes.IsSupremeUser) && 
           claimsPrincipal.FindFirstValue(CustomClaimTypes.IsSupremeUser).Contains("true");

        public static bool IsVcUser(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.HasClaim(c => c.Type == CustomClaimTypes.PreferredUsername) && 
               claimsPrincipal.FindFirstValue(CustomClaimTypes.PreferredUsername).EndsWith("@vc");
    }
}
