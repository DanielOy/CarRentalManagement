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
    public partial class Create : IDisposable
    {
        [Inject] IHttpRepository<Booking> client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Booking booking = new()
        {
            DateOut = DateTime.Now.Date
        };

        private async Task CreateBooking()
        {
            await client.Create($"{EndPoints.BookingsEndPoint}", booking);
            navManager.NavigateTo("/bookings/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
