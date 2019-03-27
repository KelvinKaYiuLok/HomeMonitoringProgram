using Hl7.Fhir.Model;
using System.Linq;

namespace HMP.App.Extensions
{
    public static class PatientExtension
    {
        public static string GetFullName(this Patient patient, HumanName.NameUse nameUse)
        {
            if (patient == null)
                return null;

            HumanName name = patient.Name.Where(n => n.Use == nameUse).FirstOrDefault();

            if (name == null)
            {
                name = patient.Name.FirstOrDefault();
            }

            return name == null ? null : $"{name.Family}, {string.Join(" ", name.Given)}" + (name.Prefix.Count() > 0? $"({string.Join(" ", name.Prefix)})" : "");
        }

        public static string GetIdentifier(this Patient patient, string system)
        {
            if (patient == null)
                return null;

            var identifier = patient.Identifier.Where(i => i.System == system).FirstOrDefault();
            if (identifier != null)
            {
                return identifier.Value;
            }

            return null;
        }
    }
}
