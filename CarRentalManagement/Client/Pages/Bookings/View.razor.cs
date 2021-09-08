using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class View
    {
        [Inject] IHttpRepository<Booking> Client { get; set; }
        [Parameter] public int Id { get; set; }

        Booking booking = new();


        protected async override Task OnParametersSetAsync()
        {
            booking = await Client.Get(EndPoints.BookingsEndPoint, Id);
        }
    }
}
