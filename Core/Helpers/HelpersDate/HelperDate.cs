using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.Core.Helpers.HelpersDate
{
    public static class HelperDate
    {
        /// <summary>
        /// 2.1.5 - форматироввание даты в формат yyyy-MM-ddTHH:mm:ss.fffzzz (2021-01-01T16:01:12.257+04:00)
        /// </summary>
        public static string FormatDate(DateTime dateTime)
        {
            var srt = dateTime.ToString($"{dateTime:O}");
            return srt;
        }
    }
}
