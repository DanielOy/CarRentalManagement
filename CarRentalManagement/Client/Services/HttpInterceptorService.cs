using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly NavigationManager _navigation;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navigation)
        {
            this._interceptor = interceptor;
            this._navigation = navigation;
        }

        public void MonitorEvent() => _interceptor.AfterSend += InterceptResponse;

        private void InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    case HttpStatusCode.NotFound:
                        _navigation.NavigateTo("/404");
                        message = "The requested resource was not found.";
                        break;
                    case HttpStatusCode.Unauthorized:
                    case HttpStatusCode.Forbidden:
                        _navigation.NavigateTo("/unauthorized");
                        message = "You are not autorized to access this resource.";
                        break;
                    default:
                        _navigation.NavigateTo("/500");
                        message = "Something went wrong, please contact Administrator.";
                        break;
                }

                throw new HttpRequestException(message);
            }
        }

        public void DisposeEvent() => _interceptor.AfterSend -= InterceptResponse;
    }
}
