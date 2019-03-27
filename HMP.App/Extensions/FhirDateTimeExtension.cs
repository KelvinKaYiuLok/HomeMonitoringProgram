using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMP.App.Extensions
{
    public static class FhirDateTimeExtension
    {
        public static string ToDateTimeString(this FhirDateTime fhirDateTime, string format)
        {
            return fhirDateTime?.ToDateTime().Value.ToString(format);
        }
    }
}
