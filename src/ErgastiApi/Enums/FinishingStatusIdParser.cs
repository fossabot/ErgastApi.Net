﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ErgastApi.Enums
{
    // TODO: Maybe move
    public static class FinishingStatusIdParser
    {
        public static FinishingStatusId Parse(string value)
        {
            FinishingStatusId statusId;

            var lapsMatch = Regex.Match(value, @"\+(\d+) Laps?", RegexOptions.IgnoreCase);
            if (lapsMatch.Success)
            {
                value = "Laps" + lapsMatch.Groups[1].Value;
                if (Enum.TryParse(value, out statusId))
                    return statusId;
            }

            value = Regex.Replace(value, @"\s", "");

            Enum.TryParse(value, out statusId);

            return statusId;
        }
    }
}
