using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Booking> client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Bookings = await this.client.GetAll(EndPoints.BookingsEndPoint);
        }

        async Task Delete(int bookingId)
        {
            var booking = Bookings.First(x => x.Id == bookingId);
            bool confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete the booking of {booking.Customer.EmailAddress}?");
            if (confirm)
            {
                await client.Delete(EndPoints.BookingsEndPoint, booking.Id);
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#bookingsTable");
        }
    }
}
