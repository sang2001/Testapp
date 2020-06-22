using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testapp.Model;

namespace Testapp.Interface
{
    interface IOrderProcessing
    {

        PaymentStatus ProcessOrder<T>(T model);
    }
}
