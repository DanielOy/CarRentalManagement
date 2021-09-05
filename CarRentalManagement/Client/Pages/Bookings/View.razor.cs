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
    public partial class View : IDisposable
    {
        [Inject] HttpClient Client { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }
        [Parameter] public int Id { get; set; }

        Booking booking = new();


        protected async override Task OnParametersSetAsync()
        {
            _interceptor.MonitorEvent();
            booking = await Client.GetFromJsonAsync<Booking>($"{EndPoints.BookingsEndPoint}/{Id}");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
