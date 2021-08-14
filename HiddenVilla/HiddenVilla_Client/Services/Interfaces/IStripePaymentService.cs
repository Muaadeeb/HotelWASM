using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services.Interfaces
{
    public interface IStripePaymentService
    {
        public Task<SuccessModel> CheckOut(StripePaymentDTO stripePaymentDto);
    }
}
