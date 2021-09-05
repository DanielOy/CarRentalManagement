using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class EndPoints
    {
        public static string Prefix = "api";

        public static string MakesEndPoint = $"{Prefix}/makes";
        public static string VehiclesEndPoint = $"{Prefix}/vehicles";
        public static string ModelsEndPoint = $"{Prefix}/models";
        public static string BookingsEndPoint = $"{Prefix}/bookings";
        public static string ColoursEndPoint = $"{Prefix}/colours";
        public static string CustomersEndPoint = $"{Prefix}/customers";
    }
}
