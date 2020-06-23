using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Testapp.Interface;
using Testapp.Model;
using Testapp.Service.OrderProcessingService;

namespace Testapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinessruleController : ControllerBase
    {
        
        private Type type;
        private IOrderProcessing<BookModel> _ibookserv;

        public BussinessruleController(IOrderProcessing<BookModel> ibookserv)
        {
            _ibookserv =ibookserv;
                
        }
        [HttpGet]
        public async Task<IActionResult> GetOrders(int ordern)
        {
            //futher we can go for enum
            PaymentStatus paystatusobj;
            if (ordern == 1)
            {
                BookModel bookorder = new BookModel();

                paystatusobj = _ibookserv.ProcessOrder(bookorder);
            }

            if (ordern == 2)
            {
                MembershipModel memeberorder = new MembershipModel();

                paystatusobj = _ibookserv.ProcessOrder(memeberorder);
            }

            else
            {
                paystatusobj = null;
            }
            return new OkObjectResult(paystatusobj);
        }



    }
}