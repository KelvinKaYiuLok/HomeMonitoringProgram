using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMP.App.Extensions
{
    public static class ElementExtension
    {
        public static FhirDateTime GetFhirDateTime(this Element element)
        {
            if (element is FhirDateTime)
            {
                return (FhirDateTime)element;
            }

            return null;
        }

        public static Period GetPeriod(this Element element)
        {
            if (element is Period)
            {
                return (Period)element;
            }

            return null;
        }

        public static FhirString GetString(this Element element)
        {
            if (element is FhirString)
            {
                return (FhirString)element;
            }

            return null;
        }

        public static Age GetAge(this Element element)
        {
            if (element is Age)
            {
                return (Age)element;
            }

            return null;
        }

        public static Range GetRange(this Element element)
        {
            if (element is Range)
            {
                return (Range)element;
            }

            return null;
        }
    }
}
