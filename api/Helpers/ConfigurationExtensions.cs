﻿using Microsoft.Extensions.Configuration;
using Scv.Api.Helpers.Exceptions;

namespace Scv.Api.Helpers
{
    public static class ConfigurationExtension
    {
        public static string GetNonEmptyValue(this IConfiguration configuration, string key)
        {
            var configurationValue = configuration.GetValue<string>(key);
            return string.IsNullOrEmpty(configurationValue)
                ? throw new ConfigurationException($"Configuration '{key}' is invalid or missing.")
                : configurationValue;
        }
    }
}
