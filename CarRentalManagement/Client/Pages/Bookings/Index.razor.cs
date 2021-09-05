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
        [Inject] HttpClient client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            Bookings = await this.client.GetFromJsonAsync<List<Booking>>(EndPoints.BookingsEndPoint);
        }

        async Task Delete(int bookingId)
        {
            var booking = Bookings.First(x => x.Id == bookingId);
            bool confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete the booking of {booking.Customer.EmailAddress}?");
            if (confirm)
            {
                _interceptor.MonitorEvent();
                await client.DeleteAsync($"{EndPoints.BookingsEndPoint}/{booking.Id}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
