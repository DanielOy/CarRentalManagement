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
    public partial class FormComponent:IDisposable
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Booking Booking { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Inject] HttpClient client { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private IList<Customer> customers;
        private IList<Vehicle> vehicles;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            customers = await this.client.GetFromJsonAsync<List<Customer>>(EndPoints.CustomersEndPoint);
            vehicles = await this.client.GetFromJsonAsync<List<Vehicle>>(EndPoints.VehiclesEndPoint);
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
