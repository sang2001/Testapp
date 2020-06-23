using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testapp.Model;

namespace Testapp.Interface
{
   public interface IOrderProcessing<T> where T : class
    {

        PaymentStatus ProcessOrder<T>(T model);
    }
}
