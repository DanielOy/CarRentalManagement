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
    public partial class Edit : IDisposable
    {
        [Inject] IHttpRepository<Booking> client { get; set; }
        [Inject] NavigationManager navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }
        [Parameter] public int id { get; set; }
        Booking booking = new Booking();


        protected async override Task OnParametersSetAsync()
        {
            _interceptor.MonitorEvent();
            booking = await client.Get(EndPoints.BookingsEndPoint, id);
        }

        async Task EditBooking()
        {
            await client.Update(EndPoints.BookingsEndPoint, booking, id);
            navManager.NavigateTo("/bookings/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
