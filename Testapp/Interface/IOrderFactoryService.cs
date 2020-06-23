using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testapp.Interface
{
    public interface IOrderFactoryService<T> where T : class
    {
        T getinstance { get;}

    }
}
