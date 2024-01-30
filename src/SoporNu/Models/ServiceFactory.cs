using SoporNu.Models.Dtos;

namespace SoporNu.Models
{
    internal static class ServiceFactory
    {
        public static Service Create(ServiceDto service)
        {
            var type = GetType(service.ServiceType);

            var lastAction = GetAction(service.GetLastActionAltText(), service.LastActionDateUtc);
            var nextAction = GetAction(service.GetNextActionAltText(), service.NextActionDateUtc);

            return new Service(type, service.NumberOfServices, lastAction, nextAction, service.GetExtraInformation(), service.GetResponsible());
        }

        private static ServiceType GetType(int type) => !Enum.IsDefined(typeof(ServiceType), type) ? ServiceType.Unknown : (ServiceType)type;

        private static Action? GetAction(string? altText, DateTime? dateUtc) => altText is null && dateUtc is null
                ? null
                : new Action(altText, dateUtc is null ? null : DateOnly.FromDateTime(dateUtc.Value));
    }
}
