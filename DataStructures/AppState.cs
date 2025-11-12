using System.Collections.Generic;

namespace TableValleyMunicipalApp.DataStructures
{
    public static class AppState
    {
        public static List<ServiceRequest> ServiceRequests { get; private set; }

        public static void Initialize()
        {
            ServiceRequests = new List<ServiceRequest>()
            {
                new ServiceRequest(100, "Pothole on the Main Road", "Roads", "Pending", 2),
                new ServiceRequest(100, "Pothole on the Main Road", "Roads", "Pending", 2),
                new ServiceRequest(100, "Pothole on the Main Road", "Roads", "Pending", 2),
                new ServiceRequest(100, "Pothole on the Main Road", "Roads", "Pending", 2),
                new ServiceRequest(100, "Pothole on the Main Road", "Roads", "Pending", 2)
            };
        }
    }
}
