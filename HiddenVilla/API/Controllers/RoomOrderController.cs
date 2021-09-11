using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Repository.IRepository;
using Models;
using Stripe.Checkout;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    //[Route("api/[controller]")]
    [ApiController]
    public class RoomOrderController : ControllerBase
    {
        private readonly IRoomOrderDetailRepository _roomOrderDetailRepository;

        public RoomOrderController(IRoomOrderDetailRepository roomOrderDetailRepository)
        {
            _roomOrderDetailRepository = roomOrderDetailRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RoomOrderDetailDTO details)
        {
            if (ModelState.IsValid)
            {
                var result = await _roomOrderDetailRepository.CreateAsync(details);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Room Details/Booking"
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] RoomOrderDetailDTO details)
        {
            var service = new SessionService();
            //var sessionDetails = service.Get(details.StripeSessionId);
            var sessionDetails = await service.GetAsync(details.StripeSessionId);

            if (sessionDetails.PaymentStatus == "paid")
            {
                var result = await _roomOrderDetailRepository.MarkPaymentSuccessfulAsync(details.Id);
                if (result == null)
                {
                    return BadRequest(new ErrorModel()
                    {
                        ErrorMessage = "Can not mark payment as successful"
                    }); 
                }

                return Ok(result);
            }

            return BadRequest(new ErrorModel()
            {
                ErrorMessage = "Can not mark payment as successful"
            });

        }
    }
}
