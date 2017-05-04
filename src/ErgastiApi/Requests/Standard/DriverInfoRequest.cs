﻿using ErgastApi.Requests.Attributes;
using ErgastApi.Responses;

namespace ErgastApi.Requests.Standard
{
    public class DriverInfoRequest : StandardRequest<DriverResponse>
    {
        public DriverInfoRequest()
        {
        }

        public DriverInfoRequest(ErgastRequestSettings settings) : base(settings)
        {
        }

        [QueryTerminator]
        public override string DriverId { get; set; }
    }
}