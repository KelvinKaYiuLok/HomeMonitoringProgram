using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMP.App.Extensions
{
    public static class DateExtension
    {
        public static string ToDateString(this Date date, string format)
        {
            return date?.ToDateTime().Value.ToString(format);
        }
    }
}
