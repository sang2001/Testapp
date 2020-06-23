using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testapp.Interface;
using Testapp.Model;

namespace Testapp.Service.OrderProcessingService
{
    public class VideoService : IOrderProcessing<VideoModel>
    {
        public PaymentStatus ProcessOrder<T>(T model)
        {
            throw new NotImplementedException();
        }
    }
}
