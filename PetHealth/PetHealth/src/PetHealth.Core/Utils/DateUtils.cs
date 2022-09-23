using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Utils
{
    public class DateUtils
    {
        public static DateTime GetCurrentDate()
        {
            return TimeZoneInfo.ConvertTimeToUtc(DateTime.Now, TimeZoneInfo.Local);
        }
    }
}
